using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace StockMaster.DAL
{
    public class ProductRepository
    {
        private string connectionString;

        public ProductRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["OptiStocConnectionString"].ConnectionString;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> produse = new List<Product>();

            using (SqlConnection conexiune = new SqlConnection(connectionString))
            {
                conexiune.Open();
                string query = "SELECT ID_Produs, Nume, Descriere, Cantitate_In_Stoc, Pret_Unitar FROM Produse";

                using (SqlCommand comanda = new SqlCommand(query, conexiune))
                using (SqlDataReader reader = comanda.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produse.Add(new Product
                        {
                            ID_Produs = (int)reader["ID_Produs"],
                            Nume = reader["Nume"].ToString(),
                            Descriere = reader["Descriere"].ToString(),
                            Cantitate_In_Stoc = (int)reader["Cantitate_In_Stoc"],
                            Pret_Unitar = (decimal)reader["Pret_Unitar"]
                        });
                    }
                }
            }

            return produse;
        }

        public List<Product> GetProductsByCategoryAndHotel(int categoryId, int hotelId)
        {
            List<Product> produse = new List<Product>();

            string query = "SELECT ID_Produs, Nume, Descriere, Cantitate_In_Stoc, Pret_Unitar FROM Produse WHERE Id_Categorie = @CategoryId AND Id_Hotel = @HotelId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("@HotelId", hotelId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            produse.Add(new Product
                            {
                                ID_Produs = (int)reader["ID_Produs"],
                                Nume = reader["Nume"].ToString(),
                                Descriere = reader["Descriere"].ToString(),
                                Cantitate_In_Stoc = (int)reader["Cantitate_In_Stoc"],
                                Pret_Unitar = (decimal)reader["Pret_Unitar"]
                            });
                        }
                    }
                }
            }

            return produse;
        }



        public void Update(Product produs)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Produse SET Cantitate_In_Stoc = @Cantitate WHERE ID_Produs = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cantitate", produs.Cantitate_In_Stoc);
                    cmd.Parameters.AddWithValue("@Id", produs.ID_Produs);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddProduct(Product product)
        {
            string query = "INSERT INTO Produse (Nume, Descriere, Cantitate_In_Stoc, Pret_Unitar, ID_Categorie) " +
                           "VALUES (@Nume, @Descriere, @Cantitate_In_Stoc, @Pret_Unitar, @ID_Categorie)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nume", product.Nume);
                    cmd.Parameters.AddWithValue("@Descriere", product.Descriere);
                    cmd.Parameters.AddWithValue("@Cantitate_In_Stoc", product.Cantitate_In_Stoc);
                    cmd.Parameters.AddWithValue("@Pret_Unitar", product.Pret_Unitar);
                    cmd.Parameters.AddWithValue("@ID_Categorie", product.ID_Categorie);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
