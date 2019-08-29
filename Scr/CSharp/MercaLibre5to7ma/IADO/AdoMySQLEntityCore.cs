using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Mercalibre15.ADO
{
    public class AdoMySQLEntityCore : DbContext, IADO
    {
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Compraventa> Compraventa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=localhost;database=supermercado;user=supermercado;password=supermercado");
        }

        public void Ausuario(Usuario usuario)
        {
            Usuario.Add(usuario);
            SaveChanges();
        }

        public void Aproductoventa(CompraVenta compraVenta)
        {
            Compraventa.Add(compraVenta);
            SaveChanges();
        }

        public void aproducto(Producto producto)
        {
            Producto.Add(producto);
            SaveChanges();
        }



        public List<Usuario> obtenerUsuarios()
        {
            throw new System.NotImplementedException();
        }

        public List<CompraVenta> obtenerventas()
        {
            throw new System.NotImplementedException();
        }

        public List<Producto> obtenerproductos()
        {
            throw new System.NotImplementedException();
        }

        public List<Usuario> veriusus(Usuario usuario)
        {
            return usuario
                   .Where(usu => usuario.Email = Usuario && usu => usuario.Contrasenia = Usuario)
                   .ToList();
        }

    }
}