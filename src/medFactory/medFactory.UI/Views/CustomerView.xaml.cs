using Microsoft.Data.SqlClient;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace medFactory.UI.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        public CustomerView()
        {
            InitializeComponent();
            Load_Data();
        }

        #region Load_Data
        private void Load_Data()
        {
            SqlConnection connection = new("Server=localhost,1433;Database = medfactory;User Id = SA;Password = medFactory@1");
            using (connection) //use your connection string here
            {
                string SelectQuery = "Select * From dbo.Customers";
                using SqlDataAdapter adapter = new(SelectQuery, connection);
                try
                {
                    SqlCommandBuilder commandBuilder = new(adapter);

                    System.Data.DataTable table = new("dbo.Customers");
                    adapter.Fill(table);
                    CustomerDataGrid.ItemsSource = table.DefaultView;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
                }
                finally
                {
                    connection.Close();
                }

            }
        }
        #endregion

    }
}
