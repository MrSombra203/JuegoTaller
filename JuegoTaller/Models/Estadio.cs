using System.ComponentModel.DataAnnotations;

namespace JuegoTaller.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required(ErrorMessage = "La dirección es obligatoria")]

        public string Direccion { get; set; }
        [MaxLength(200)]
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
    }
}
