using System;
using Xamarin.Forms;
using System.Windows.Input;
using WtsXamarin.Helpers;

namespace WtsXamarin.ViewModels
{
    public class WebViewViewModel : Observable
    {
        protected const string DefaultUrl = "https://developer.microsoft.com/en-us/windows/apps";
        
        private WebView _webView;
        private WebViewSource _source;
        private bool _canGoBack, _canGoForward;

        public WebViewViewModel()
        {
            Source = new UrlWebViewSource
            {
                Url = DefaultUrl
            };

            GoBack = new Command(
                canExecute: () => CanGoBack,
                execute: () => _webView?.GoBack());

            GoForward = new Command(
                canExecute: () => CanGoForward,
                execute: () => _webView?.GoForward());

            Refresh = new Command(
                execute: () => _webView.Source = (_webView.Source as UrlWebViewSource).Url);

            OpenInBrowser = new Command(
                execute: () => Device.OpenUri(new Uri(DefaultUrl)));           
        }

        public ICommand GoBack { protected set; get; }
        public ICommand GoForward { protected set; get; }
        public ICommand Refresh { protected set; get; }
        public ICommand OpenInBrowser { get; protected set; }

        public WebViewSource Source
        {
            set
            {
                Set(ref _source, value);
            }
            get
            {
                return _source;
            }
        }

        public bool CanGoBack
        {
            set
            {
                if (Set(ref _canGoBack, value))
                {
                    (GoBack as Command).ChangeCanExecute();
                }
            }
            get
            {
                return _canGoBack;
            }
        }

        public bool CanGoForward
        {
            set
            {
                if (Set(ref _canGoForward, value))
                {
                    (GoForward as Command).ChangeCanExecute();
                }
            }
            get
            {
                return _canGoForward;
            }
        }

        public void Initialize(WebView webView)
        {
            _webView = webView;
        }
    }
}
