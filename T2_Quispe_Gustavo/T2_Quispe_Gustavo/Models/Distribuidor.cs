using System.ComponentModel.DataAnnotations;

namespace T2_Quispe_Gustavo.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre del Distribuidor es necesario")]
        public string NombreDistribuidor { get; set; }
        [Required(ErrorMessage = "La Razon social es necesario")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El numero de telefono del Distribuidor es necesario")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El Anio de Inicio de operacion del Distribuidor es necesario")]
        [Range(1900,3000,ErrorMessage ="El inicio de operacion debe ser entre 1900 a 3000")]
        public int AnioInicioOperacion { get; set; }

        [Required(ErrorMessage = "El Contacto del Distribuidor es necesario")]
        public string Contacto { get; set; }
    }
}
