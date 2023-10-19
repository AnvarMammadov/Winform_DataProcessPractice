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
    public partial class UcProductDisplay : UserControl
    {

        public string pName { get=>lblName.Text; set { SetLabelContent(lblName, panelName, value); lblName.Text=value; } }    
        public string Description { get=>lblDesc.Text; set { SetLabelContent(lblDesc, panelDesc, value); lblDesc.Text=value;  } }
        public double Price { get=>Convert.ToDouble(lblPrice.Text); set { SetLabelContent(lblPrice, panelPrice, value.ToString("0.00")); lblPrice.Text=value.ToString("0.00");} }
        public List<Product> Products { get; set; }
        public FlowLayoutPanel Panel { get; set; }
        public UcProductDisplay()
        {
            InitializeComponent();
        }
        private void SetLabelContent(Label label,Guna2Panel panel,string content)
        {
            try
            {
                label.Text = content;
                if (label.Width > panel.Width)
                {
                    label.Width = panel.Width;
                }
                if (label.Height > panel.Height)
                {
                    label.Height = panel.Height;
                }
            }
            catch (Exception ex)
            {
                FileManage.LogError(ex);
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FormUpdate frmUpdate = new FormUpdate();
                frmUpdate.proName = pName;
                frmUpdate.proDesc = Description;
                frmUpdate.proPrice = Convert.ToDouble(Price);
                frmUpdate.products = Products;
                frmUpdate.panel = Panel;
                frmUpdate.oldProduct = Products.FirstOrDefault(p => p.Name == pName && p.Description == Description && p.Price == Price);

                frmUpdate.ShowDialog();
            }
            catch (Exception ex)
            {
                FileManage.LogError(ex);
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
