using StockMaster.BLL;
using StockMaster.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMaster
{
    public partial class ModificareCantitateForm : Form
    {
      
        private Product produs;

        public ModificareCantitateForm(Product produsSelectat)
        {
            InitializeComponent();
            produs = produsSelectat;

           
            txtCantitate.Text = produs.Cantitate_In_Stoc.ToString();
        }

        private void btnSalvareDate_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtCantitate.Text, out int cantitateNoua))
            {
                if (cantitateNoua >= 0)
                {
                    
                    produs.Cantitate_In_Stoc = cantitateNoua;

                    
                    var productService = new ProductService();
                    productService.UpdateProduct(produs);
                    MessageBox.Show("Cantitatea a fost actualizată cu succes!");
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Cantitatea trebuie să fie un număr pozitiv.");
                }
            }
            else
            {
                MessageBox.Show("Te rog să introduci o cantitate validă.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
