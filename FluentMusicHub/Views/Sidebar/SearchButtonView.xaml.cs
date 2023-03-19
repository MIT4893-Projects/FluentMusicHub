// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Media.Imaging;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FluentMusicHub.Views.Sidebar
{
    public sealed partial class SearchButtonView : UserControl, ISidebarNavigationItem
    {
        private bool SelectingProperty = false;
        public bool Selecting
        {
            get
            {
                return SelectingProperty;
            }
            set
            {
                SelectingProperty = value;
                SelectingChanged?.Invoke(this, new());
            }
        }

        public event RoutedEventHandler SelectingChanged;

        public SearchButtonView()
        {
            this.InitializeComponent();

            SelectingChanged += SelectingChangedHandler;
        }

        public void SelectingChangedHandler(object sender, RoutedEventArgs e)
        {
            Uri unselectingImageSource = new("ms-appx:///Assets/search-outline-size-48-white.png");
            Uri selectingImageSource = new("ms-appx:///Assets/search-fill-size-48-white.png");
            ButtonImage.Source = new BitmapImage(Selecting ? selectingImageSource : unselectingImageSource);
        }
    }
}
