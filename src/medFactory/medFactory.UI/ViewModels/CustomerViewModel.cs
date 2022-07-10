using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.UI.ViewModels
{ 
    public class CustomerViewModel : ViewModelBase
    {
        public DelegateCommand NewCustomerCommand { get; private set; }
        private readonly IRegionManager _regionManager;

        public CustomerViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NewCustomerCommand = new DelegateCommand(ToNewCustomer);
        }

        private void ToNewCustomer()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("AddCustomerView", UriKind.RelativeOrAbsolute));
        }
    }
}
