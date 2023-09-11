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
                    Header = "1 ��� �����",
                    Content = new Button()
                },
                new TabItem()
                {
                    Header = "2 ��� �����",
                    Content = new Label()
                }
            };

            TabItems2 = new ObservableCollection<TabItem>()
            {
                new TabItem()
                {
                    Header = "3 ��� �����",
                    Content = new TextBlock()
                },
                new TabItem()
                {
                    Header = "4 ��� �����",
                    Content = new Label()
                }
            };

            TabItems3 = new ObservableCollection<TabItem>()
            {
                new TabItem()
                {
                    Header = "5 ��� �����",
                    Content = new Label()
                }
            };



            RibbonTabs = new ObservableCollection<HeaderedItemsControl>()
            {
                new HeaderedItemsControl()
                {
                    Header = "������ ����������� ���",
                    ItemsSource = TabItems1
                },
                new HeaderedItemsControl()
                {
                    Header = "������ ����������� ���",
                    ItemsSource = TabItems2
                },
                new HeaderedItemsControl()
                {
                    Header = "������ ����������� ���",
                    ItemsSource = TabItems3
                }

            };
        }
    }
}