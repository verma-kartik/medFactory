using medFactory.UI.Views;
using Prism.Regions;

namespace medFactory.UI.ViewModels
{
    public partial class DashboardContentViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        public DashboardContentViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion(Region.Regions.RibbonRegion, typeof(RibbonView));
            _regionManager.RegisterViewWithRegion(Region.Regions.EditingRegion, typeof(DashboardEditingBaseView));
        }
    }
}
