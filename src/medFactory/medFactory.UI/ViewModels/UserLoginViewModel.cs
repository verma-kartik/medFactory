using Prism.Commands;
using Prism.Regions;
using System;
using System.Windows;
using System.Windows.Input;

namespace medFactory.UI.ViewModels
{
    public class UserLoginViewModel : ViewModelBase
    {
        public DelegateCommand SubmitCommand { get; private set; }
        private readonly IRegionManager _regionManager;

        public UserLoginViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            SubmitCommand = new DelegateCommand(Submit, CanSubmit);
        }

        private void Submit()
        {
            _regionManager.RequestNavigate(Region.Regions.MainRegion, new Uri("DashboardView", UriKind.RelativeOrAbsolute));
        }

        private bool CanSubmit()
        {
            return true;
        }
    }
}
