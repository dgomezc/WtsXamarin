using System.Collections.ObjectModel;
using WtsXamarin.Core.Helpers;
using WtsXamarin.Core.Models;
using WtsXamarin.Core.Services;

namespace WtsXamarin.ViewModels
{
    public class ListViewViewModel : Observable
    {
        private ObservableCollection<SampleOrder> _sampleData;
        private SampleOrder _selectedItem;

        public ListViewViewModel()
        {
            SampleData = SampleDataService.GetGridSampleData();
            SelectedItem = SampleData[0];
        }

        public ObservableCollection<SampleOrder> SampleData
        {
            get => _sampleData;
            private set => Set(ref _sampleData, value);
        }

        public SampleOrder SelectedItem
        {
            get => _selectedItem;
            set => Set(ref _selectedItem, value);
        }
    }
}
