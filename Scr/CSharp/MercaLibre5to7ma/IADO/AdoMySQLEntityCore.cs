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
        public DbSet<Compraventa> compraVentas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;database=MercaLibre;user=root;password=root");
            }
        }

        public void Ausuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
            SaveChanges();
        }

        public void Aproductoventa(Compraventa compraVenta)
        {
            compraVentas.Add(compraVenta);
            SaveChanges();
        }
        public void mProducto(Producto producto)
        {
            this.Attach<Producto>(producto);
            SaveChanges();
        }
        public void aproducto(Producto producto)
        {
            Productos.Add(producto);
            SaveChanges();
        }

        public void actualizarestadodelproducto ( Compraventa compraventa )
        {
            compraVentas.Remove(compraventa);
            SaveChanges();
        }


        public List<Usuario> obtenerUsuarios()
        {
            return Usuarios.ToList();
        }

        public List<Compraventa> obtenerventas()
        {
            return compraVentas.ToList();
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
                  .Where(x => x.usuario == usuario).ToList()
                  ;
                   
        }

        public void mUsuario(Usuario usuario)
        {
            this.Attach<Usuario>(usuario);
            SaveChanges();
        }

        public List<Producto> buscarProductos(string nombre, Usuario usuario)
            =>  Productos.
                Where(p => p.Nombre.Contains(nombre) && p.usuario != usuario).
                Include(p=>p.usuario).
                Include(p=>p.productosEnVentas).
                ToList();
    }
}