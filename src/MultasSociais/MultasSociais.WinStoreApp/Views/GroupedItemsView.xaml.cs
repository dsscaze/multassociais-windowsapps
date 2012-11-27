﻿using MultasSociais.WinStoreApp.DataModel;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MultasSociais.WinStoreApp.DataModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

namespace MultasSociais.WinStoreApp.Views
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class GroupedItemsView
    {
        public GroupedItemsView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when a group header is clicked.
        /// </summary>
        /// <param name="sender">The Button used as a group header for the selected group.</param>
        /// <param name="e">Event data that describes how the click was initiated.</param>
        //void Header_Click(object sender, RoutedEventArgs e)
        //{
        //    // Determine what group the Button instance represents
        //    var group = (sender as FrameworkElement).DataContext;

        //    // Navigate to the appropriate destination page, configuring the new page
        //    // by passing required information as a navigation parameter
        //    this.Frame.Navigate(typeof(GroupDetailView), ((SampleDataGroup)group).UniqueId);
        //}

        /// <summary>
        /// Invoked when an item within a group is clicked.
        /// </summary>
        /// <param name="sender">The GridView (or ListView when the application is snapped)
        /// displaying the item clicked.</param>
        /// <param name="e">Event data that describes the item clicked.</param>
        void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Navigate to the appropriate destination page, configuring the new page
            // by passing required information as a navigation parameter
            var itemId = ((SampleDataItem)e.ClickedItem).UniqueId;
            this.Frame.Navigate(typeof(ItemDetailView), itemId);
        }
    }
}
