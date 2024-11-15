# How to restrict the tooltip on a WPF Chart
WPF Chart Tooltip displays data information over a chart segment by setting the [ShowTooltip](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_ShowTooltip) property to true. This section explains how to restrict the tooltip hovering over a segment and how to show the tooltip hovering over a marker of the segment.

To display the tooltip over a marker in the segment, you can use the [ShowMarker](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase.html#Syncfusion_UI_Xaml_Charts_ChartAdornmentInfoBase_ShowMarker) property of the chart segment and set it to true. This will display markers on the chart segment, and the tooltip will appear over the marker when the pointer has hovered over it. 

This is the actual behavior of tooltip rendering over a segment with a pointer position. You can set the [Position](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartTooltipBehavior.html?tabs=tabid-1#Syncfusion_UI_Xaml_Charts_ChartTooltipBehavior_Position) of the tooltip as Pointer, it will display the information on every hover over the segment.

![MainWindow-2023-02-13-10-26-12](https://user-images.githubusercontent.com/105496706/218442257-01ef4449-bf11-4304-a09d-11d90229f929.gif)

The tooltip rendering on the segment has been restricted according to the code snippet below: 

**[C#]**
```
public class LineSeriesExt : LineSeries
{
	protected override void OnMouseMove(MouseEventArgs e)
	{
		//To restrict tooltip when hover on the line segment
		if (e.OriginalSource is Line)
			return;
		base.OnMouseMove(e);
	}
}
```
**[XAML]**
```
<chart:SfChart>
    <chart:SfChart.PrimaryAxis>
        <chart:CategoryAxis PlotOffset="20" ShowGridLines="False" />
    </chart:SfChart.PrimaryAxis>

    <chart:SfChart.SecondaryAxis>
        <chart:NumericalAxis Maximum="120" Minimum="0" ShowGridLines="False" PlotOffset="12"/>
    </chart:SfChart.SecondaryAxis>

    <chart:SfChart.Behaviors>
        <chart:ChartTooltipBehavior Position="Pointer"/>
    </chart:SfChart.Behaviors>

    <local:LineSeriesExt ItemsSource="{Binding Data}"
                         XBindingPath="XValue"
                         YBindingPath="YValue"
                         ShowTooltip="True"
                         Palette="Metro">
        <local:LineSeriesExt.AdornmentsInfo>
            <chart:ChartAdornmentInfo ShowLabel="True" Background="Transparent" 
                                      SymbolHeight="40" SymbolInterior="White"
                                      SymbolWidth="40" Symbol="Ellipse" 
                                      SymbolStroke="Black" ShowMarker="True" />
        </local:LineSeriesExt.AdornmentsInfo>
    </local:LineSeriesExt>
</chart:SfChart>
```
![MainWindow-2023-02-13-10-33-56](https://user-images.githubusercontent.com/105496706/218442232-1de8fd3c-8c86-41bf-91fe-43c85ea0891e.gif)

**See Also,**
<br>[How to provide animation effects for tooltip?](https://help.syncfusion.com/wpf/charts/interactive-features/tooltip#animation-for-tooltip)
<br>[How to customize the tooltip in chart?](https://help.syncfusion.com/wpf/charts/interactive-features/tooltip#customizing-the-appearance)
<br>[How to view the tooltip when segment is underneath the axis line?](https://www.syncfusion.com/kb/4722/how-to-show-tooltip-when-segment-is-underneath-axis-line-of-wpf-chart-sfchart)

