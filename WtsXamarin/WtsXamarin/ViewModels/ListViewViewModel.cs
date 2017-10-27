using System.Collections.Generic;
using System.Collections.ObjectModel;
using WtsXamarin.Core.Helpers;
using WtsXamarin.Core.Models;
using WtsXamarin.Core.Services;
using WtsXamarin.Core.ViewModels;

namespace WtsXamarin.ViewModels
{
    public class ListViewViewModel : ListViewModelBase<SampleOrder>
    {
        public override IEnumerable<SampleOrder> GetData()
        {
            return SampleDataService.GetGridSampleData();
        }
    }
}
