using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Vehiculo
    {
        [Key]
        public int idVehiculo { get; set; }
        [MaxLength(30)]
        [Required]

        public String Marca { get; set; }
        [Required]

        public String Modelo { get; set; }

        public String Anio { get; set; }

        public int IdSucursal { get; set; }


        public virtual Sucursal Sucursales { get; set; }
    }
}
