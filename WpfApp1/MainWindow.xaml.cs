using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BCustomer productBusiness;

        public MainWindow()
        {
            InitializeComponent();
            productBusiness = new BCustomer(); // Configura la cadena de conexión a la base de datos.
        }
        private void BuscarProductosPorNombre_Click(object sender, RoutedEventArgs e)
        {
            string productName = TextBoxNombreProducto.Text; // Obtener el nombre ingresado por el usuario

            // Llama a la función de la capa de negocio para obtener los productos por nombre
            List<Customer> products = productBusiness.GetCustomersByName(productName);

            // Asigna los resultados al ListView
            ListViewResultados.ItemsSource = products;
        }
    }
}