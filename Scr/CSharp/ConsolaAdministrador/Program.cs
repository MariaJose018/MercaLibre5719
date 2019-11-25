using MenuesConsola;
using ConsolaAdministrador.Menus;
using Mercalibre15;

namespace ConsolaAdministrador
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menuListaUsuario = new menuListaUsuario() { Nombre = "Lista de Usuarios" };
            var menuActualizarUsuario = new MenuActualizarUsuario() { Nombre = "Actualizar Usuario",MenuListaUsuario = menuListaUsuario  };
            var menuListaProductoVenta = new MenuListaProductosVentas () { Nombre = "Productos venta " };
            var menuAltaUsuario = new MenuAltaUsuario() { Nombre = "Alta Usuario" };
            var actualizarventa = new Actualizarventa() { Nombre = "restablecer producto", MenuListaProductosVentas = menuListaProductoVenta };


            
            var menuProducto = new MenuCompuesto() { Nombre = "Productos" };
            menuProducto.agregarMenu(actualizarventa);
            menuProducto.agregarMenu(menuListaProductoVenta);

            
            var menuAdministrador = new MenuCompuesto() { Nombre = "Usuarios" };
            menuAdministrador.agregarMenu(menuAltaUsuario);
            menuAdministrador.agregarMenu(menuListaUsuario);
            menuAdministrador.agregarMenu(menuActualizarUsuario);

            var menuprincipal = new MenuCompuesto() { Nombre = "menu administrador" };
            menuprincipal.agregarMenu(menuProducto);
            menuprincipal.agregarMenu(menuAdministrador);

            menuprincipal.mostrar();     
            
        }
        
    }
}
