using Prism.Commands;
using Prism.Regions;
using System;

namespace medFactory.UI.ViewModels
{
    public class ManufacturerViewModel : ViewModelBase
    {
        public DelegateCommand NewManufacturerCommand { get; private set; }
        private readonly IRegionManager _regionManager;

        public ManufacturerViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NewManufacturerCommand = new DelegateCommand(ToNewManufacturer);
        }

        private void ToNewManufacturer()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("AddManufacturerView", UriKind.RelativeOrAbsolute));
        }
    }
}
