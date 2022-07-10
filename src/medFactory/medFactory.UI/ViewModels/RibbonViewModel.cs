using Prism.Commands;
using Prism.Regions;
using System;

namespace medFactory.UI.ViewModels
{
    public partial class RibbonViewModel : ViewModelBase
    {
        
        private readonly IRegionManager _regionManager;

        public RibbonViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
           
        }

        private void ToDashboardContent()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("AddCustomerView", UriKind.RelativeOrAbsolute));
        }
    }
}
