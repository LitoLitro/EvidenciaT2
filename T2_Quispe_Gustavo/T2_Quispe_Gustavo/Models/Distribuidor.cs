using System.ComponentModel.DataAnnotations;

namespace T2_Quispe_Gustavo.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }
        public string NombreDistribuidor { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public int AnioInicioOperacion { get; set; }
        public string Contacto { get; set; }
    }
}
