using MenuesConsola;
using NETCore.Encrypt;
using Mercalibre15;
using System;
using static System.ReadLine;
using ConsolaUsuario;

namespace ConsolaUsuario
{
    public class Login : MenuComponente
    {
       
        private Usuario usuario { get; set; }
        private MenuCompuesto PrincipalUsuario { get; set; }


        public override void mostrar()
        {
            base.mostrar();

            var correo = Read("Ingrese su correo: ");
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            try
            {
                usuario = AdoUsuario.ADO.verificarUsuario(correo, pass);
                if (usuario is null)
                {
                    Console.WriteLine("Correo o contraseña incorrecta");
                    Console.ReadKey();
                }
                else
                {

                    instanciarMenuesParausu(usuario);
                    PrincipalUsuario.mostrar();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo iniciar sesion debido a un error: {ex.InnerException.Message}");
                Console.ReadKey();
            }
        }

        private void instanciarMenuesParausu(Usuario usuario)
        {
           
            var menuAltaCompra = new MenuAltaCompra(usuario) { Nombre = "Alta Ventas" };
            var menuAltaProducto = new MenuAltaProducto(usuario) { Nombre = " Alta Producto" };
            var menuListaProductoVenta = new MenuListaProductosVentas(usuario) { Nombre = "Lista de productos en ventas " };
            var menuActualizarPrecioyStock = new ActualizarPrecioyStock(usuario) { Nombre = "Actualizar precio y stock" };

            var menuProducto = new MenuCompuesto() { Nombre = "Productos" };
            menuProducto.agregarMenu(menuListaProductoVenta);
            menuProducto.agregarMenu(menuAltaProducto);
            menuProducto.agregarMenu(menuActualizarPrecioyStock);

            var menuVenta = new MenuCompuesto() { Nombre = "Usuarios" };
            menuVenta.agregarMenu(menuAltaCompra);
            menuVenta.agregarMenu(menuListaProductoVenta);
            
            PrincipalUsuario = new MenuCompuesto() { Nombre = "Menu Administrador" };
            PrincipalUsuario.agregarMenu(menuProducto);
            PrincipalUsuario.agregarMenu(PrincipalUsuario);
        }
    }
}
        


