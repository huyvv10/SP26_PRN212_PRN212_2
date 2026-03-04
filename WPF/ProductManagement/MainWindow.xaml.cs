using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            FormCategory frmCategory = new FormCategory();
            frmCategory.Show();
            this.Close();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            FormProduct frmProduct = new FormProduct();
            frmProduct.Show();
            this.Close();   
        }
    }
}