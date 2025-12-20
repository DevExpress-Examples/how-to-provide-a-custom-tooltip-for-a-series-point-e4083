<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4083)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Chart for WPF - How to Create a Custom Tooltip for a Series Point

This example implements a custom tooltip that displays another chart with a GDP history for the selected country when hovering over a bar.

![chart](./images/chart.png)

## Implementation Details

The `System.Windows.DataTemplate` object specifies the custom tooltip appearance. The object is assigned to the [Series.ToolTipPointTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Series.ToolTipPointTemplate) property. The `GetDataSource()` and `GetGDPs()` methods supply charts with data from the GDP datasource. 

## Files to Review 
* [MainWindow.xaml](./CS/ToolTipPointTemplate/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ToolTipPointTemplate/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ToolTipPointTemplate/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ToolTipPointTemplate/MainWindow.xaml.vb))

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-chart-create-a-custom-tooltip-for-a-series-point&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-chart-create-a-custom-tooltip-for-a-series-point&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
