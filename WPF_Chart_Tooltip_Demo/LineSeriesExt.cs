﻿using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Shapes;

namespace WPF_Chart_Tooltip_Demo
{
    public class LineSeriesExt : LineSeries
    {
        protected override void OnMouseMove(MouseEventArgs e)
        {
            //To restrict tooltip when hover on line segment
            if (e.OriginalSource is Line)
                return;
            base.OnMouseMove(e);
        }
    }
}
