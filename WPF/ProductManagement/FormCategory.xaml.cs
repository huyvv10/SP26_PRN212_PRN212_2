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
    /// Interaction logic for FormCategory.xaml
    /// </summary>
    public partial class FormCategory : Window
    {
        CategoryBLL _catBLL = new();
        public FormCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FillCategoryDataGrid()
        {
            dgCategory.ItemsSource = null;
            dgCategory.ItemsSource = _catBLL.GetAllCategory();
        }
        private void frmCategory_Loaded(object sender, RoutedEventArgs e)
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            FillCategoryDataGrid();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string id = txtId.Text.Trim();
            string name = txtName.Text.Trim();
            if (id.Length > 0 && name.Length > 0)
            {
                Category x = new Category();
                x.CatId = id;
                x.CatName = name;
                _catBLL.AddNewCategory(x);
                FillCategoryDataGrid();
            }
        }

        private void dgCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category? x = dgCategory.SelectedItem as dynamic;
            if (x != null)
            {
                txtId.Text = x.CatId;
                txtName.Text = x.CatName;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Category? x = dgCategory.SelectedItem as Category;
            if (x != null)
            {
                if (MessageBox.Show("Do you really want to delete?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    _catBLL.DeleteCategory(x);
                    FillCategoryDataGrid();
                }
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Category? x = dgCategory.SelectedItem as Category;
            if (x != null)
            {
                string id = txtId.Text.Trim();
                string name = txtName.Text.Trim();
                if (id.Length > 0 && name.Length > 0)
                {
                    if (MessageBox.Show("Do you really want to update?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        x.CatName = name;
                        _catBLL.UpdateCategory(x);
                        FillCategoryDataGrid();
                    }
                }
            }
        }
    }
}