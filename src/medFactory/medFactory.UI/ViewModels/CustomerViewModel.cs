using Prism.Commands;
using Prism.Regions;
using System;
using medFactory.Services.Contracts;

namespace medFactory.UI.ViewModels
{ 
    public class CustomerViewModel : ViewModelBase
    {
        public DelegateCommand NewCustomerCommand { get; private set; }
        private readonly IRegionManager _regionManager;
        private readonly IServiceManager _service;

        public CustomerViewModel(IRegionManager regionManager, IServiceManager service)
        {
            _regionManager = regionManager;
            _service = service;
            NewCustomerCommand = new DelegateCommand(ToNewCustomer);
        }

        private void ToNewCustomer()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("AddCustomerView", UriKind.RelativeOrAbsolute));
        }
    }
}
