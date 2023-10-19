using Guna.UI2.WinForms;
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
    public partial class FormAdd : Form
    {
        public List<Product> products { get; set; }
        public FlowLayoutPanel panel { get; set; }
        public FormAdd()
        {
            InitializeComponent();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    if (!char.IsControl(e.KeyChar) && e.KeyChar != ',')
                    {
                        e.Handled = true;
                    }

                    if ((e.KeyChar == ',') && txtPrice.Text.Contains(","))
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                FileManage.LogError(ex);
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearOrDefault();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newProduct = Product.GetProduct(txtName.Text, txtDesc.Text, Convert.ToDouble(txtPrice.Text));
                products.Add(newProduct);

                panel.Controls.Clear();

                int y = this.panel.Location.Y;
                foreach (var product in products)
                {
                    UcProductDisplay uc = new UcProductDisplay();
                    uc.Products = products;
                    uc.Panel = panel;
                    uc.pName = product.Name;
                    uc.Description = product.Description;
                    uc.Price = product.Price;
                    uc.Location = new System.Drawing.Point(uc.Location.X, y);
                    this.panel.Controls.Add(uc);
                    y += uc.Height;
                }
                MessageBox.Show("Product Added..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                FileManage.LogError(ex);
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearOrDefault();
            }
        }

        private void ClearOrDefault()
        {
            txtName.Text= string.Empty; 
            txtDesc.Text= string.Empty;
            txtPrice.Text= string.Empty;
        }
    }
}
