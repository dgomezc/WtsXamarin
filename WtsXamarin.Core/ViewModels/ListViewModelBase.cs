using System.Collections.Generic;
using System.Collections.ObjectModel;
using WtsXamarin.Core.Helpers;
using WtsXamarin.Core.Models;
using WtsXamarin.Core.Services;

namespace WtsXamarin.Core.ViewModels
{
    public abstract class ListViewModelBase<T> : Observable where T: SampleOrder
    {
        private ObservableCollection<T> _sampleData;
        private T _selectedItem;

        public ListViewModelBase()
        {
            SampleData = new ObservableCollection<T>(GetData());
            SelectedItem = SampleData[0];
        }

        public ObservableCollection<T> SampleData
        {
            get => _sampleData;
            private set => Set(ref _sampleData, value);
        }

        public T SelectedItem
        {
            get => _selectedItem;
            set => Set(ref _selectedItem, value);
        }

        public abstract IEnumerable<T> GetData();
    }
}
