﻿using medFactory.UI.Views;
using Prism.Regions;

namespace medFactory.UI.ViewModels
{
    public partial class DashboardViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        public DashboardViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion(Region.Regions.MenuRegion, typeof(DashboardMenuBarView));
        }

    }
}
