using MenuesConsola;
using NETCore.Encrypt;
using Mercalibre15;
using System;
using static System.ReadLine;

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
                usuario = AdoUsuario.ADO.usuarioporcorreoPass(correo, pass);
                if (usuario is null)
                {
                    Console.WriteLine("DNI o contraseña incorrecta");
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
                Console.WriteLine($"No se pudo iniciar sesion debido a un error: {ex.Message}");
                Console.ReadKey();
            }
        }

        private void instanciarMenuesParausu(Usuario usuario)
        {
            var menuAltaProducto = new MenuAltaProducto(usuario);
            var menuAltaCompra = new MenuAltaCompra (usuario);
            var menuListaProductosVentas = new MenuListaProductosVentas(usuario);
            var menuListaUusario = new MenuListaUsuario(usuario);
            var menuActualiarInformacion = new MenuActualizarInformacion (usuario);
            var menuVerificarInformacion = new MenuVerInformacion(usuario);
            var menuActualizarPrecio = new ActualizarPrecioyStock(usuario);

            PrincipalUsuario = new MenuCompuesto(menuAltaProducto) { Nombre = "Menu usuario" };
            PrincipalUsuario = new MenuCompuesto(menuAltaCompra) { Nombre = "Menu Usuario" };
            PrincipalUsuario = new MenuCompuesto(menuListaProductosVentas) { Nombre = "menu Usuario" };
            PrincipalUsuario = new MenuCompuesto(menuListaUusario) { Nombre = "menu usuario" };
            PrincipalUsuario = new MenuCompuesto(menuActualiarInformacion) { Nombre = "menu usuario" };
            PrincipalUsuario = new MenuCompuesto (menuVerificarInformacion) {Nombre = "menu usuario"  };
            PrincipalUsuario = new MenuCompuesto(menuActualizarPrecio) { Nombre = "menu usuario" };




            
        }
    }
}
        


