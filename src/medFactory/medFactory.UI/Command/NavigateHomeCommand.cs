using medFactory.UI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medFactory.UI.Command
{
    public class NavigateHomeCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateHomeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            
        }
    }
}
