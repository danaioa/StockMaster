namespace StockMaster.DAL
{
    public class Product
    {
        public int ID_Produs { get; set; }
        
        public int ID_Categorie { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int Cantitate_In_Stoc { get; set; }
        public decimal Pret_Unitar { get; set; }
    }
}
