using medFactory.UI.Views;
using Prism.Navigation;
using Prism.Regions;
using System;
using System.Windows.Threading;

namespace medFactory.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

#pragma warning disable S1450 // Private fields only used as local variables in methods should become local variables
        private readonly IRegionManager _regionManager;
#pragma warning restore S1450 // Private fields only used as local variables in methods should become local variables

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion(Region.Regions.MainRegion, typeof(LoadingPageView));
        }
    }
}
