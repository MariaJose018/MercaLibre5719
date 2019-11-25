using MenuesConsola;
using ConsolaAdministrador.Menus;
using Mercalibre15;


namespace ConsolaAdministrador
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menuActualizarUsuario = new MenuActualizarUsuario() { Nombre = "Actualizar Usuario" };
            var menuListaProductoVenta = new MenuListaProductosVentas() { Nombre = "Lista de productos en ventas " };
            var menuAltaUsuario = new MenuAltaUsuario() { Nombre = "Alta Usuario" };
            var menuListaUsuario = new menuListaUsuario() { Nombre = "Lista de Usuarios" };



            var menuProducto = new MenuCompuesto() { Nombre = "Productos" };
            menuProducto.agregarMenu(menuListaProductoVenta);

            
            var menuAdministrador = new MenuCompuesto() { Nombre = "Usuarios" };
            menuAdministrador.agregarMenu(menuAltaUsuario);
            menuAdministrador.agregarMenu(menuListaUsuario);
            menuAdministrador.agregarMenu(menuActualizarUsuario);

            menuAdministrador.mostrar();
        }
    }
}
