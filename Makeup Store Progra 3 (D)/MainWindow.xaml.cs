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

namespace Makeup_Store_Progra_3__D_
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Producto> inventario;

        public MainWindow()
        {
            InitializeComponent();
            inventario = new List<Producto>();
        }

        private void AgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            DateTime fechaCaducidad = dpFechaCaducidad.SelectedDate ?? DateTime.MinValue;

            Producto producto = new Producto { Nombre = nombre, Cantidad = cantidad, FechaCaducidad = fechaCaducidad };
            inventario.Add(producto);

            lstProductos.ItemsSource = null;
            lstProductos.ItemsSource = inventario;
        }
    }
}
