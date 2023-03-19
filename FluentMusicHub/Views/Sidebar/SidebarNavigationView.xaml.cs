using Microsoft.UI.Xaml.Controls;

namespace FluentMusicHub.Views.Sidebar
{
    /// <summary>
    /// Represents a view to navigate between pages in application, place in sidebar.
    /// </summary>
    public sealed partial class SidebarNavigationView : UserControl
    {
        /// <summary>
        /// Create a new instance of sidebar navigation view.
        /// </summary>
        public SidebarNavigationView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Represents an event handler for the SelectionChanged event of a button.
        /// </summary>
        /// <remarks>
        /// Triggers children's SelectingChanged event.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
