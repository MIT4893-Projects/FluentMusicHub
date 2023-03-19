using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;

namespace FluentMusicHub.Views.Sidebar
{
    /// <summary>
    /// Represents a view for a search button in sidebar's navigation view.
    /// </summary>
    public sealed partial class SearchButtonView : UserControl, ISidebarNavigationItem
    {
        /// <summary>
        /// Event handler for Selecting when it's value changed.
        /// </summary>
        public event RoutedEventHandler SelectingChanged;

        /// <summary>
        /// Field for Selectng property.
        /// </summary>
        private bool SelectingProperty = false;

        /// <summary>
        /// Presents this object is currenly selecting or not.
        /// </summary>
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

        /// <summary>
        /// Create a new instance of SearchButtonView and configure event handlers.
        /// </summary>
        public SearchButtonView()
        {
            this.InitializeComponent();

            SelectingChanged += SelectingChangedHandler;
        }

        /// <summary>
        /// Change button's image when Selecting property changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectingChangedHandler(object sender, RoutedEventArgs e)
        {
            Uri unselectingImageSource = new("ms-appx:///Assets/search-outline-size-48-white.png");
            Uri selectingImageSource = new("ms-appx:///Assets/search-fill-size-48-white.png");
            ButtonImage.Source = new BitmapImage(Selecting ? selectingImageSource : unselectingImageSource);
        }
    }
}
