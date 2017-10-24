using System.Collections.ObjectModel;
using WtsXamarin.Helpers;
using WtsXamarin.Models;
using WtsXamarin.Services;

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
            private set
            {
                Set(ref _sampleData, value);
            }

            get
            {
                return _sampleData;
            }
        }

        public SampleOrder SelectedItem
        {
            set
            {
                Set(ref _selectedItem, value);
            }
            get
            {
                return _selectedItem;
            }
        }
    }
}
