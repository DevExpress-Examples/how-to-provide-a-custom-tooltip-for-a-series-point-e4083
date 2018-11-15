<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ToolTipPointTemplate/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/ToolTipPointTemplate/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/ToolTipPointTemplate/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ToolTipPointTemplate/MainWindow.xaml.vb))
<!-- default file list end -->
# How to provide a custom tooltip for a series point


<p>This example shows how to implement a custom tooltip that displays another chart with a GDP history for the selected country when hovering over a bar. </p><p>To accomplish this, it is necessary to create the<strong> System.Windows.DataTemplate </strong>object that specifies the custom tooltip appearance, and assign it to the <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsSeries_ToolTipPointTemplatetopic"><u>Series.ToolTipPointTemplate</u></a> property.  </p><p>You also need to bind both charts to the GDP datasource and write the GetDataSource() and GetGDPs() methods. These methods allow you to get the GDP data from a datasource  for each selected country to display it on a chart tooltip. </p>


<h3>Description</h3>

<p><br />
</p>

<br/>


