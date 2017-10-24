using WtsXamarin.Helpers;

namespace WtsXamarin.ViewModels
{
    public class BlankViewModel : Observable
    {
        public BlankViewModel()
        {
        }

        public string ExampleText { get; private set; } = "This is a blank page.";
    }
}
