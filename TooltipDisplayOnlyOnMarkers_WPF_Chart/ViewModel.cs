using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooltipDisplayOnlyOnMarkers_WPF_Chart
{
	public class ViewModel
	{
		public ObservableCollection<Model> Data { get; set; }

		public ViewModel()
		{
			Data = new ObservableCollection<Model>()
			{
				new Model() {XValue="Jan", YValue = 20},
				new Model() {XValue="Feb",YValue = 40},
				new Model() {XValue="Mar",YValue = 60},
				new Model() {XValue= "Apr",YValue = 80},
				new Model() {XValue="May",YValue = 100},
			};

		}
	}

	public class Model
	{
		public string XValue { get; set; }
		public double YValue { get; set; }
	}
}
