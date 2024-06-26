<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570123/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4083)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ToolTipPointTemplate/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ToolTipPointTemplate/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ToolTipPointTemplate/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ToolTipPointTemplate/MainWindow.xaml.vb))
<!-- default file list end -->
# How to provide a custom tooltip for a series point


<p>This example shows how to implement a custom tooltip that displays another chart with a GDP history for the selected country when hovering over a bar. </p><p>To accomplish this, it is necessary to create the<strong> System.Windows.DataTemplate </strong>object that specifies the custom tooltip appearance, and assign it to the <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsSeries_ToolTipPointTemplatetopic"><u>Series.ToolTipPointTemplate</u></a> property.  </p><p>You also need to bind both charts to the GDP datasource and write the GetDataSource() and GetGDPs() methods. These methods allow you to get the GDP data from a datasource  for each selected country to display it on a chart tooltip. </p>


<h3>Description</h3>

<p><br />
</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-provide-a-custom-tooltip-for-a-series-point-e4083&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-provide-a-custom-tooltip-for-a-series-point-e4083&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
