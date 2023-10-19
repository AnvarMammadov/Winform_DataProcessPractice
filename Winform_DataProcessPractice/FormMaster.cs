using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_DataProcessPractice
{
    public partial class FormMaster : Form
    {
        List<Product> products = new List<Product> {
            new Product{Name="Iphone X" , Description="Smartphone",Price=1100},
            new Product{Name="Galaxy S11 Ultra" , Description="Smartphone",Price=1200},
            new Product{Name="MSI G66" , Description="Laptop",Price=3100},
            new Product{Name="Asus Rog 5" , Description="Smartphone",Price=2100},
            new Product{Name="HP 16" , Description="Laptop",Price=2500},
        };
        public FormMaster()
        {
            try
            {
                InitializeComponent();
                int y = this.panelProductDisplay.Location.Y;
                foreach (var product in products)
                {
                    UcProductDisplay uc = new UcProductDisplay();
                    uc.Products = products;
                    uc.Panel = panelProductDisplay;
                    uc.pName = product.Name;
                    uc.Description = product.Description;
                    uc.Price = product.Price;
                    uc.Location = new System.Drawing.Point(uc.Location.X, y);
                    this.panelProductDisplay.Controls.Add(uc);
                    y += uc.Height;
                }
            }
            catch (Exception ex)
            {
                FileManage.LogError(ex);
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            PanelScrollHelper scrollHelper = new PanelScrollHelper(panelProductDisplay, scrlBarPanel,true);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                FormAdd frmAdd = new FormAdd();
                frmAdd.products = products;
                frmAdd.panel = panelProductDisplay;
                frmAdd.ShowDialog();
            }
            catch (Exception ex)
            {
                FileManage.LogError(ex);
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
