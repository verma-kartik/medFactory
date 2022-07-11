using Prism.Commands;
using Prism.Regions;
using System;

namespace medFactory.UI.ViewModels
{
    public partial class DashboardMenuBarViewModel : ViewModelBase
    {
        public DelegateCommand CustomerCommand { get; private set; }
        public DelegateCommand DashboardEditingBaseCommand { get; private set; }
        public DelegateCommand SupplierCommand { get; private set; }
        public DelegateCommand ManufacturerCommand { get; private set; }

        private readonly IRegionManager _regionManager;

        public DashboardMenuBarViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            CustomerCommand = new DelegateCommand(ToCustomer);
            SupplierCommand = new DelegateCommand(ToSupplier);
            ManufacturerCommand = new DelegateCommand(ToManufacturer);
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

        private void ToSupplier()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("SupplierView", UriKind.RelativeOrAbsolute));
        }

        private void ToManufacturer()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("ManufacturerView", UriKind.RelativeOrAbsolute));
        }
    }
}
