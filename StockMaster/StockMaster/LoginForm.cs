using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StockMaster
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtParola.PasswordChar = '*';
            txtParola.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string utilizator = txtUtilizator.Text.Trim();
            string parola = txtParola.Text.Trim();

            string rezultat = VerificaAutentificare(utilizator, parola);

            if (rezultat == "admin")
            {
                btnAdaugareH.Visible = true;
                btnStergeH.Visible = true;
                txtUtilizator.Visible = false;
                txtParola.Visible = false;
                lblUtilizator.Visible = false;
                lblParola.Visible = false;
                btnLogin.Visible = false;
            }
            else if (rezultat != null)
            {
               


                int idHotel = int.Parse(rezultat);
             
                
               
                Form1 mainForm = new Form1(idHotel);
                
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Nume utilizator sau parolă greșite.");
            }
        }
        

           


        private string VerificaAutentificare(string utilizator, string parola)
        {
            if (utilizator == "admin" && parola == "admin123")
                return "admin";

            string connStr = ConfigurationManager.ConnectionStrings["OptiStocConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT ID_Hotel FROM Hoteluri WHERE Username = @user AND Parola = @pass";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", utilizator);
                    cmd.Parameters.AddWithValue("@pass", parola);

                    object result = cmd.ExecuteScalar();
                    return result?.ToString(); // întoarce ID_Hotel sau null
                }
            }
        }

        private void btnAdaugareH_Click(object sender, EventArgs e)
        {
            btnStergeH.Visible = false;
            lbIdentificator.Visible = true;
            txtIdentificator.Visible = true;
            lblNumeAfacere.Visible = true;
            txtNumeAfacere.Visible = true;
            txtEmail.Visible = true;
            lblemail.Visible = true;
            lblParola.Visible = false;
            txtParola.Visible =false;
            btnLogin.Visible = false;
            btnSalvareHotel.Visible = true;
            lblUserName.Visible=true;
            txtUsername.Visible = true;
            lnlNumeAdmin.Visible = true;
            txtNumeAdmin.Visible = true;
            lblParolaAdmin.Visible = true;
            txtParolaAdmin.Visible = true;


        }

        private void btnSalvareHotel_Click(object sender, EventArgs e)
        {
            string numeHotel = txtNumeAfacere.Text.Trim();
            string numeAdmin = txtNumeAdmin.Text.Trim();
            string parolaAdmin = txtParolaAdmin.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();

            // Validare simplă
            if (string.IsNullOrWhiteSpace(numeHotel) ||
                string.IsNullOrWhiteSpace(parolaAdmin) ||
                string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Completează toate câmpurile obligatorii.");
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["OptiStocConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string insertQuery = @"
                INSERT INTO Hoteluri (Nume, Nume_Administrator, Prenume_Administrator, Parola, Email, Username)
                VALUES (@nume, @numeAdmin, '', @parola, @email, @username)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nume", numeHotel);
                        cmd.Parameters.AddWithValue("@numeAdmin", numeAdmin);
                        cmd.Parameters.AddWithValue("@parola", parolaAdmin);
                        cmd.Parameters.AddWithValue("@email", (object)email ?? DBNull.Value); // acceptă null
                        cmd.Parameters.AddWithValue("@username", username);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hotelul a fost adăugat cu succes!");

                // opțional: golește câmpurile după salvare
                txtNumeAfacere.Clear();
                txtNumeAdmin.Clear();
                txtParolaAdmin.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
                txtIdentificator.Clear();

                btnSalvareHotel.Visible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
