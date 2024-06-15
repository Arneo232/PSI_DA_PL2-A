using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapido.Modelo
{
    internal class GandaContext : DbContext
    {
        public DbSet <Prato> pratos { get; set; }
    }
}
