using Proiect_Web.Models;

namespace Proiect_Web.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public ICollection<Produs>? Produs { get; set; }
    }
}

