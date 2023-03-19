using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentMusicHub.Views.Sidebar
{
    interface ISidebarNavigationItem
    {
        public event RoutedEventHandler SelectingChanged;
        public bool Selecting { get; set; }
        public void SelectingChangedHandler(object sender, RoutedEventArgs e);
    }
}
