using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.UI.ViewModels
{
    public class AddCustomerViewModel : ViewModelBase
    {
        public DelegateCommand SaveCustomerCommand { get; private set; }
        public DelegateCommand CancelCustomerCommand { get; private set; }
        private readonly IRegionManager _regionManager;

        public AddCustomerViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            SaveCustomerCommand = new DelegateCommand(ToCustomer);
            CancelCustomerCommand = new DelegateCommand(ToCustomer);
        }

        private void ToCustomer()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("CustomerView", UriKind.RelativeOrAbsolute));
        }
    }
}
