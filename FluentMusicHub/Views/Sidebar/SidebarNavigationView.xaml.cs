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

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FluentMusicHub.Views.Sidebar
{
    public sealed partial class SidebarNavigationView : UserControl
    {
        public SidebarNavigationView()
        {
            this.InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView listView = sender as ListView;
            int selectingIdx = listView.SelectedIndex;
            for (int idx = 0; idx < listView.Items.Count; ++idx)
            {
                ISidebarNavigationItem item = listView.Items[idx] as ISidebarNavigationItem;
                item.Selecting = idx == selectingIdx;
            }
        }
    }
}
