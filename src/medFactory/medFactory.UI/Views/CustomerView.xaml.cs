using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using ImTools;
using medFactory.Domain.Models;
using medFactory.EF;
using medFactory.EF.Repository;
using medFactory.Services.Contracts;
using medFactory.Services.Services;

namespace medFactory.UI.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        private readonly IServiceManager _service;
        public CustomerView()
        {
            InitializeComponent();
            _service = new ServiceManager(new UnitOfWork(new DesignTimeDbContext()));
            Load_Data();
        }

        #region Load_Data
        private void Load_Data()
        {
            try
            {
                var customers = _service.CustomerService.GetCustomers();
                var coll = customers.ToList();
                CustomerDataGrid.ItemsSource = coll;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "ERROR Loading");
            }

        }
    }
        #endregion
}

