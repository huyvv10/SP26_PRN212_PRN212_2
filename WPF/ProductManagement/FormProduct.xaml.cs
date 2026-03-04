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
using System.Windows.Shapes;
using ProductManagement.BLL;
using ProductManagement.Models;

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for FormProduct.xaml
    /// </summary>
    public partial class FormProduct : Window
    {
        public ProductBLL _prdBLL = new();
        public CategoryBLL _catBLL = new();
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FillCbCategory()
        {
            cbCategory.ItemsSource = null;
            cbCategory.ItemsSource = _catBLL.GetAllCategory();
        }

        private void FillDataGridProducts()
        {
            dgProducts.ItemsSource = null;
            dgProducts.ItemsSource = _prdBLL.GetAllProduct();
        }
        private void frmFormProduct_Loaded(object sender, RoutedEventArgs e)
        {
            FillCbCategory();
            FillDataGridProducts();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow frmMain = new MainWindow();
            frmMain.Show();
            this.Close();
        }


        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string kwName = txtSearch.Text;
            var prodList = _prdBLL.SearchByName(kwName);
            dgProducts.ItemsSource = null;
            dgProducts.ItemsSource = prodList;
        }
        private void clear()
        {
            txtPId.Text= string.Empty;
            txtPName.Text= string.Empty;
            txtPrice.Text= string.Empty;
            txtQty.Text= string.Empty;
            txtUnit.Text= string.Empty;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string id = txtPId.Text.Trim();
            string name = txtPName.Text.Trim();
            string unit = txtUnit.Text.Trim();
            int qty, price;
            int.TryParse(txtQty.Text.Trim(), out qty);
            int.TryParse(txtPrice.Text.Trim(), out price);
            string? catId = cbCategory.SelectedValue.ToString();
            Product x = new Product();
            x.PId = id;
            x.PName = name;
            x.Unit = unit;
            x.Qty = qty;
            x.Price = price;
            x.CatId = catId;
            _prdBLL.AddNewProduct(x);
            FillDataGridProducts();
            clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Product? x = dgProducts.SelectedItem as dynamic;
            if (x != null)
            {
                if (MessageBox.Show("Do you really want to delete?","Delete verification", MessageBoxButton.YesNo, MessageBoxImage.Warning)==MessageBoxResult.Yes)
                {
                    _prdBLL.DeleteProduct(x);
                    FillDataGridProducts();
                }
            }
        }

        private void dgProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
