using medFactory.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.UI.Stores
{
    public class NavigationStore
    {
        public ViewModelBase? CurrentViewModel { get; set; }
    }
}
