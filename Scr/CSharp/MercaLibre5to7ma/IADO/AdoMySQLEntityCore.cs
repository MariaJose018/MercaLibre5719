using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Mercalibre15.ADO
{
    public class AdoMySQLEntityCore : DbContext, IADO
    {
        public AdoMySQLEntityCore(DbContextOptions dbo) : base(dbo) { }

        public AdoMySQLEntityCore()
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Compraventa> Compraventa { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=localhost;database=MercaLibre;user=root;password=root");
        }

        public void Ausuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
            SaveChanges();
        }

        public void Aproductoventa(Compraventa compraVenta)
        {
            Compraventa.Add(compraVenta);
            SaveChanges();
        }

        public void aproducto(Producto producto)
        {
            Productos.Add(producto);
            SaveChanges();
        }



        public List<Usuario> obtenerUsuarios()
        {
            throw new System.NotImplementedException();
        }

        public List<Compraventa> obtenerventas()
        {
            throw new System.NotImplementedException();
        }

        public List<Producto> obtenerproductos()
        {
            return Productos
                  .ToList();
        }


        public Usuario verificarUsuario(string email, string contrasenia)
            => Usuarios.FirstOrDefault(u => u.Email == email && u.Contrasenia == contrasenia);

        public List<Producto> obtenerProductosDe(Usuario usuario)
        {
            return Productos
                  .Where(x => x.usuario == usuario).ToList();
                   
        }
    }
}