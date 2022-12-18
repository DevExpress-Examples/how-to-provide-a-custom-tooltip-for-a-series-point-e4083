Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Media
Imports System.Xml.Linq
Imports System.Windows.Resources
Imports System.Globalization

Namespace ToolTipPointTemplate

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.chart.DataSource = GetDataSource()
        End Sub

        Private Function GetDataSource() As List(Of G8Member)
            Dim GDPs As List(Of GDP) = GetGDPs()
            Dim countries As List(Of G8Member) = New List(Of G8Member)()
            Const yearsInDecade As Integer = 10
            For countryCounter As Integer = 0 To 8 - 1
                Dim countryGDPs As List(Of GDP) = New List(Of GDP)()
                For countryValuesCounter As Integer = 0 To yearsInDecade - 1
                    countryGDPs.Add(GDPs(countryCounter * yearsInDecade + countryValuesCounter))
                Next

                countries.Add(New G8Member(countryGDPs))
            Next

            Return countries
        End Function

        Private Function GetGDPs() As List(Of GDP)
            Dim document As XDocument = DataLoader.LoadXmlFromResources("/Data/GDPofG8.xml")
            Dim result As List(Of GDP) = New List(Of GDP)()
            If document IsNot Nothing Then
                For Each element As XElement In document.Element("G8GDPs").Elements()
                    Dim country As String = element.Element("Country").Value
                    Dim year As Integer = Integer.Parse(element.Element("Year").Value)
                    Dim product As Decimal = Convert.ToDecimal(element.Element("Product").Value, CultureInfo.InvariantCulture)
                    result.Add(New GDP(country, year, product))
                Next
            End If

            Return result
        End Function

        Public NotInheritable Class DataLoader

            Public Shared Function LoadXmlFromResources(ByVal fileName As String) As XDocument
                Try
                    fileName = "/ToolTipPointTemplate;component" & fileName
                    Dim uri As Uri = New Uri(fileName, UriKind.RelativeOrAbsolute)
                    Dim info As StreamResourceInfo = Application.GetResourceStream(uri)
                    Return XDocument.Load(info.Stream)
                Catch
                    Return Nothing
                End Try
            End Function
        End Class

        Private Sub ChartToolTipController_ToolTipOpening(ByVal sender As Object, ByVal e As DevExpress.Xpf.Charts.ChartToolTipEventArgs)
            Dim toolTipData As ToolTipData = TryCast(e.Hint, ToolTipData)
            Dim colorNumber As Integer = e.Series.Points.IndexOf(e.SeriesPoint)
            Dim seriesColor As Color = e.ChartControl.Palette(colorNumber)
            toolTipData.SeriesBrush = New SolidColorBrush(seriesColor)
        End Sub
    End Class

    Public Class GDP

        Private _Country As String, _Year As Integer, _Product As Decimal

        Public Property Country As String
            Get
                Return _Country
            End Get

            Private Set(ByVal value As String)
                _Country = value
            End Set
        End Property

        Public Property Year As Integer
            Get
                Return _Year
            End Get

            Private Set(ByVal value As Integer)
                _Year = value
            End Set
        End Property

        Public Property Product As Decimal
            Get
                Return _Product
            End Get

            Private Set(ByVal value As Decimal)
                _Product = value
            End Set
        End Property

        Public Sub New(ByVal country As String, ByVal year As Integer, ByVal product As Decimal)
            Me.Country = country
            Me.Year = year
            Me.Product = product
        End Sub
    End Class

    Public Class G8Member

        Private _GDPin2010 As Decimal, _CountryName As String

        Public Property GDPin2010 As Decimal
            Get
                Return _GDPin2010
            End Get

            Private Set(ByVal value As Decimal)
                _GDPin2010 = value
            End Set
        End Property

        Public Property CountryName As String
            Get
                Return _CountryName
            End Get

            Private Set(ByVal value As String)
                _CountryName = value
            End Set
        End Property

        Public Property ToolTipData As ToolTipData

        Public Sub New(ByVal GDPs As List(Of GDP))
            ToolTipData = New ToolTipData(GDPs, GDPs(0).Country)
            CountryName = GDPs(0).Country
            GDPin2010 = GDPs(9).Product
        End Sub
    End Class

    Public Class ToolTipData

        Private _GDPs As List(Of ToolTipPointTemplate.GDP), _Title As String

        Public Property GDPs As List(Of GDP)
            Get
                Return _GDPs
            End Get

            Private Set(ByVal value As List(Of GDP))
                _GDPs = value
            End Set
        End Property

        Public Property SeriesBrush As SolidColorBrush

        Public Property Title As String
            Get
                Return _Title
            End Get

            Private Set(ByVal value As String)
                _Title = value
            End Set
        End Property

        Public Sub New(ByVal gdps As List(Of GDP), ByVal countryName As String)
            Me.GDPs = gdps
            Title = countryName & " GDP History"
        End Sub
    End Class
End Namespace
