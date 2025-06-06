using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using StockMaster.BLL;
using StockMaster.DAL;

namespace StockMaster
{
    public partial class Form1 : Form
    {
        private ProductService productService;
        private int categorieIdSelectata;
        private int categorieIdHotel;

        

        public Form1(int idHotel) // Constructor cu codul hotelului
        {
            
            InitializeComponent();
            productService = new ProductService();
            categorieIdHotel = idHotel;

            

            string numeHotel = GetHotelName(idHotel);
            lblNumeHotel.Text ="-"+numeHotel;
            lblNumeHotel.Visible = true;

            
            btnAfisareProduse.Visible = false;
            btnAdaugaProdus.Visible = false;
            btnInapoi.Visible = false;
            btnModificaCantitate.Visible = false;
            btnCautare.Visible = false;
            txtCautare.Visible = false;
            
        }

        private void AfiseazaProdusePeCategorie(string categorie)
        {
            var toateProdusele = productService.GetAllProducts();
            var produseFiltrate = toateProdusele
                .Where(p => p.Descriere != null && p.Descriere.ToLower().Contains(categorie.ToLower()))
                .ToList();

            dataGridProduse.DataSource = produseFiltrate;
        }

       public void VerificaStocMic(int idHotel)
        {
            
            string connStr = ConfigurationManager.ConnectionStrings["OptiStocConnectionString"].ConnectionString;
            List<string> produseCritice = new List<string>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT Nume, Cantitate_In_Stoc FROM Produse WHERE ID_Hotel = @id AND Cantitate_In_Stoc < 4";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idHotel);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string denumire = reader["Nume"].ToString();
                            int stoc = Convert.ToInt32(reader["Cantitate_In_Stoc"]);
                            produseCritice.Add($"{denumire} - {stoc} bucăți");
                        }
                    }
                }
            }

            if (produseCritice.Count > 0)
            {
                string mesaj = "⚠️ Produse cu stoc critic:\n\n" + string.Join("\n", produseCritice);
                MessageBox.Show(mesaj, "Stoc redus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStoc_Click(object sender, EventArgs e)
        {
            VerificaStocMic(categorieIdHotel);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // buton inapoi
            btnAfisareProduse.Visible = false;
            btnAdaugaProdus.Visible = false;
            btnInapoi.Visible = false;
            btnModificaCantitate.Visible = false;
            btnCautare.Visible = false;
            txtCautare.Visible = false;
            dataGridProduse.DataSource = null;
            btnBar.Visible = true;
            btnBucatarie.Visible = true;
            btnCategorie.Visible = false;
            txtidCTG.Visible = false;
            btnNume.Visible = false;
            txtNumeProdus.Visible = false;
            btnDescriere.Visible = false;
            txtDescriereProdus.Visible = false;
            btnCantitate.Visible = false;
            PretProdus.Visible = false;
            btnPret.Visible = false;
            btnSalveazaProdusNou.Visible = false;
            PretProdus.Visible = false;
            dataGridProduse.Visible = false;
            btnStoc.Visible = false;
        }

        private void btnBucatarie_Click(object sender, EventArgs e)
        {
            categorieIdSelectata = 1;
            AfiseazaActiuniCategorie();
            dataGridProduse.Visible = true;
            
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            categorieIdSelectata = 2;
            AfiseazaActiuniCategorie();
            dataGridProduse.Visible = true;
        }

        private void AfiseazaActiuniCategorie()
        {
            btnAfisareProduse.Visible = true;
            btnAdaugaProdus.Visible = true;
            btnInapoi.Visible = true;
            btnModificaCantitate.Visible = true;
            btnCautare.Visible = true;
            txtCautare.Visible = true;
            dataGridProduse.DataSource = null;
            btnStoc.Visible = true;
        }

        private void btnAfisareProduse_Click_1(object sender, EventArgs e)
        {
            var produse = productService.GetProductsByCategoryAndHotel(categorieIdSelectata, categorieIdHotel);
            dataGridProduse.DataSource = produse;

            dataGridProduse.Columns["ID_Categorie"].Visible = false;
        }

        private void btnModificaCantitate_Click(object sender, EventArgs e)
        {
            if (dataGridProduse.SelectedRows.Count > 0)
            {
                var produsSelectat = (Product)dataGridProduse.SelectedRows[0].DataBoundItem;
                ModificareCantitateForm form = new ModificareCantitateForm(produsSelectat);
                form.ShowDialog();
                dataGridProduse.Refresh();
            }
            else
            {
                MessageBox.Show("Te rog să selectezi un produs din listă.");
            }
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            string cautareText = txtCautare.Text.ToLower();
            var produseToate = productService.GetAllProducts();
            var produseGasite = produseToate
                .Where(p => p.Nume.ToLower().Contains(cautareText))
                .ToList();

            dataGridProduse.DataSource = produseGasite;
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            txtNumeProdus.Visible = true;
            txtDescriereProdus.Visible = true;
            numeCantitate.Visible = true;
            PretProdus.Visible = true;
            txtidCTG.Visible = true;
            btnSalveazaProdusNou.Visible = true;
            btnNume.Visible = true;
            btnCantitate.Visible = true;
            btnDescriere.Visible = true;
            btnPret.Visible = true;
            btnCategorie.Visible = true;
        }

        private void btnSalveazaProdusNou_Click(object sender, EventArgs e)
        {
            string numeProdus = txtNumeProdus.Text;
            string idText = txtidCTG.Text;
            string descriereProdus = txtDescriereProdus.Text;
            string cantitateText = numeCantitate.Text;
            decimal pretProdus = PretProdus.Value;

            if (string.IsNullOrWhiteSpace(numeProdus) || string.IsNullOrWhiteSpace(descriereProdus) ||
                string.IsNullOrWhiteSpace(cantitateText) || string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Te rog completează toate câmpurile!");
                return;
            }

            if (!int.TryParse(idText, out int idCategorie))
            {
                MessageBox.Show("ID-ul categoriei trebuie să fie un număr valid.");
                return;
            }

            if (!int.TryParse(cantitateText, out int cantitate))
            {
                MessageBox.Show("Cantitatea trebuie să fie un număr întreg valid.");
                return;
            }

            if (pretProdus <= 0)
            {
                MessageBox.Show("Prețul trebuie să fie mai mare decât 0.");
                return;
            }

            Product produsNou = new Product
            {
                Nume = numeProdus,
                ID_Categorie = idCategorie,
                Descriere = descriereProdus,
                Cantitate_In_Stoc = cantitate,
                Pret_Unitar = pretProdus
            };

            productService.AddProduct(produsNou);

            var produseActualizate = productService.GetAllProducts();
            dataGridProduse.DataSource = produseActualizate;

            MessageBox.Show("Produsul a fost adăugat cu succes!");
        }

        private void lblNumeHotel_Click(object sender, EventArgs e)
        {

        }

        private string GetHotelName(int idHotel)
        {
            string connStr = ConfigurationManager.ConnectionStrings["OptiStocConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT Nume FROM Hoteluri WHERE ID_Hotel = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idHotel);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "Hotel necunoscut";
                }
            }
        }

        private void btnInapoiLogare_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
