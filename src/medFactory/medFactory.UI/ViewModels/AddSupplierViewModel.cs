using Prism.Commands;
using Prism.Regions;
using System;

namespace medFactory.UI.ViewModels
{
    public class AddSupplierViewModel : ViewModelBase
    {
        public DelegateCommand SaveSupplierCommand { get; private set; }
        public DelegateCommand CancelSupplierCommand { get; private set; }
        private readonly IRegionManager _regionManager;

        public AddSupplierViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            SaveSupplierCommand = new DelegateCommand(ToSupplier);
            CancelSupplierCommand = new DelegateCommand(ToSupplier);
        }

        private void ToSupplier()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("SupplierView", UriKind.RelativeOrAbsolute));
        }
    }
}
