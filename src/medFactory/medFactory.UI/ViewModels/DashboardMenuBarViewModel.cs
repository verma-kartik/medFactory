using Prism.Commands;
using Prism.Regions;
using System;

namespace medFactory.UI.ViewModels
{
    public partial class DashboardMenuBarViewModel : ViewModelBase
    {
        public DelegateCommand CustomerCommand { get; private set; }
        public DelegateCommand DashboardEditingBaseCommand { get; private set; }
        private readonly IRegionManager _regionManager;

        public DashboardMenuBarViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            CustomerCommand = new DelegateCommand(ToCustomer);
            DashboardEditingBaseCommand = new DelegateCommand(ToDashBoardEditingBase);
        }

        private void ToDashBoardEditingBase()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("DashboardEditingBaseView", UriKind.RelativeOrAbsolute));
        }

        private void ToCustomer()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("CustomerView", UriKind.RelativeOrAbsolute));
        }
    }
}
