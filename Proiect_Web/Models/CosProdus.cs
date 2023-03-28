namespace Proiect_Web.Models
{
    public class CosProdus
    {

        public int Id { get; set; }
        public int ProdusId { get; set; }
        public int Cantitate { get; set; }
        public int CosId { get; set; }
        public Produs Produs { get; set; }
        public virtual Cos Cos { get; set; }
    }
}
