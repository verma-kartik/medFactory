using Prism.Commands;
using Prism.Regions;
using System;

namespace medFactory.UI.ViewModels
{
    public class AddManufacturerViewModel : ViewModelBase
    {
        public DelegateCommand SaveManufacturerCommand { get; private set; }
        public DelegateCommand CancelManufacturerCommand { get; private set; }
        private readonly IRegionManager _regionManager;

        public AddManufacturerViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            SaveManufacturerCommand = new DelegateCommand(ToManufacturer);
            CancelManufacturerCommand = new DelegateCommand(ToManufacturer);
        }

        private void ToManufacturer()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("ManufacturerView", UriKind.RelativeOrAbsolute));
        }
    }
}
