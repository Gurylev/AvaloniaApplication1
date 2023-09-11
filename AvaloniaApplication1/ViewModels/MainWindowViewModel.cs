using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using System.Collections.ObjectModel;

namespace AvaloniaApplication1.ViewModels
{  
    public class MainWindowViewModel : ViewModelBase
    {
        public RibbonViewModel RibbonTabs { get; set; }

    
        public MainWindowViewModel()
        {
            RibbonTabs = new RibbonViewModel();
        }

    }
}
