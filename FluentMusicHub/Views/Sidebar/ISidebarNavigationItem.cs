using Microsoft.UI.Xaml;

namespace FluentMusicHub.Views.Sidebar
{
    /// <summary>
    /// Represents an interface for a item in sidebar's navigation view.
    /// </summary>
    interface ISidebarNavigationItem
    {
        /// <summary>
        /// Event handler when Selecting property changed.
        /// </summary>
        public event RoutedEventHandler SelectingChanged;

        /// <summary>
        /// Represent this object is selecting in navigation view or not.
        /// </summary>
        public bool Selecting { get; set; }

        /// <summary>
        /// Event handler's function to handle Selecting property's changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectingChangedHandler(object sender, RoutedEventArgs e);
    }
}
