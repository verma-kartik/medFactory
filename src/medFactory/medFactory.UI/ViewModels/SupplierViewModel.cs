using Prism.Commands;
using Prism.Regions;
using System;

namespace medFactory.UI.ViewModels
{
    public class SupplierViewModel : ViewModelBase
    {
        public DelegateCommand NewSupplierCommand { get; private set; }
        private readonly IRegionManager _regionManager;

        public SupplierViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NewSupplierCommand = new DelegateCommand(ToNewSupplier);
        }

        private void ToNewSupplier()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("AddSupplierView", UriKind.RelativeOrAbsolute));
        }
    }
}
