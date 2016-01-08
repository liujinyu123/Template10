﻿using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Template10.Services.NavigationService
{
    // DOCS: https://github.com/Windows-XAML/Template10/wiki/Docs-%7C-NavigationService
    public class NavigatingEventArgs: NavigatedEventArgs
    {
        public NavigatingEventArgs() { }
        public NavigatingEventArgs(NavigatingCancelEventArgs e, Page page, object parameter)
        {
            this.NavigationMode = e.NavigationMode;
            this.PageType = e.SourcePageType;
            this.Page = page;
            this.Parameter = parameter;
        }
        public bool Cancel { get; set; } = false;
        public bool Suspending { get; set; } = false;
    }
}