using medFactory.UI.Views;
using Prism.Regions;
using System;
using System.Windows.Threading;

namespace medFactory.UI.ViewModels
{
    public class LoadingPageViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;
        readonly DispatcherTimer _timer;

        public LoadingPageViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _timer = new DispatcherTimer();
            _timer.Tick += DispatcherTimer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 10);
            _timer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            _regionManager.RequestNavigate(Region.Regions.MainRegion, new Uri("UserLoginView", UriKind.RelativeOrAbsolute));
            _timer.Stop();
        }
    }
}
