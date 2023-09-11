using System;
using System.Collections.Generic;
using Avalonia.Controls.Primitives;
using Avalonia.Controls;
using System.Collections.ObjectModel;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels
{
	public class RibbonViewModel : ViewModelBase
    {
        public ObservableCollection<HeaderedItemsControl> RibbonTabs { get; set; }

        public ObservableCollection<TabItem> TabItems1 { get; set; }
        public ObservableCollection<TabItem> TabItems2 { get; set; }
        public ObservableCollection<TabItem> TabItems3 { get; set; }
        public RibbonViewModel()
        {
            TabItems1 = new ObservableCollection<TabItem>()
            {
                new TabItem()
                {
                    Header = "1 таб айтем",
                    Content = new Button()
                },
                new TabItem()
                {
                    Header = "2 таб айтем",
                    Content = new Label()
                }
            };

            TabItems2 = new ObservableCollection<TabItem>()
            {
                new TabItem()
                {
                    Header = "3 таб айтем",
                    Content = new TextBlock()
                },
                new TabItem()
                {
                    Header = "4 таб айтем",
                    Content = new Label()
                }
            };

            TabItems3 = new ObservableCollection<TabItem>()
            {
                new TabItem()
                {
                    Header = "5 таб айтем",
                    Content = new Label()
                }
            };



            RibbonTabs = new ObservableCollection<HeaderedItemsControl>()
            {
                new HeaderedItemsControl()
                {
                    Header = "Первый контекстный таб",
                    ItemsSource = TabItems1
                },
                new HeaderedItemsControl()
                {
                    Header = "Второй контекстный таб",
                    ItemsSource = TabItems2
                },
                new HeaderedItemsControl()
                {
                    Header = "Третий контекстный таб",
                    ItemsSource = TabItems3
                }

            };
        }
    }
}