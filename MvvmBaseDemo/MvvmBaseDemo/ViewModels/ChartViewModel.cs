using System;
using System.Collections.ObjectModel;

using MvvmBaseDemo.Helpers;
using MvvmBaseDemo.Models;
using MvvmBaseDemo.Services;

namespace MvvmBaseDemo.ViewModels
{
    public class ChartViewModel : Observable
    {
        public ChartViewModel()
        {
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }
    }
}
