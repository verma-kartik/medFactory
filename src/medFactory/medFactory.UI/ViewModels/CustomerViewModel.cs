using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using medFactory.Domain.Models;
using medFactory.EF;
using medFactory.EF.Repository;
using medFactory.Services.Contracts;
using medFactory.Services.Services;

namespace medFactory.UI.ViewModels
{
    public class CustomerViewModel : ViewModelBase
    {
        public DelegateCommand NewCustomerCommand { get; private set; }
        public DelegateCommand ShowCustomerCommand { get; private set; }
        private readonly IRegionManager _regionManager;
        private IServiceManager _service;
        private readonly BackgroundWorker worker; 

        public CustomerViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _service = new ServiceManager(new UnitOfWork(new DesignTimeDbContext()));
            NewCustomerCommand = new DelegateCommand(ToNewCustomer);
            ShowCustomerCommand = new DelegateCommand(LoadCustomerRecords);
            //LoadCustomerRecords();
        }

        private ObservableCollection<Customer> _customers = new();

        public ObservableCollection<Customer> Customers
        {
            get => _customers;
            set
            {
                if(_customers == value) return;
                _customers = value;
                OnPropertyChanged(nameof(Customers));
            }
        }
        
        private void ToNewCustomer()
        {
            _regionManager.RequestNavigate(Region.Regions.EditingRegion, new Uri("AddCustomerView", UriKind.RelativeOrAbsolute));
        }

        private void LoadCustomerRecords()
        {
            try
            {
                var bgWorker = new BackgroundWorker();
                bgWorker.DoWork += (sender, e) => LoadItemsWithOutAnimation(sender, e);
                bgWorker.RunWorkerAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "ERROR Loading");
            }
        }
        
        private void LoadItemsWithOutAnimation(object sender, DoWorkEventArgs e)
        {
            var ListofCustomers = _service.CustomerService.GetCustomers();
            var coll = new ObservableCollection<Customer>(ListofCustomers);
            Customers = coll;
        }
   }
}
