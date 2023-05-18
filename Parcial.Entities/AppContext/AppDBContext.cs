using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities.AppContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("conn")
        {

        }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<Sucursal> Sucursales { get; set; }
    }
}
