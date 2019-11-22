using MenuesConsola;
using ConsolaAdministrador.Menus;

namespace ConsolaAdministrador
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuActualizarUsuario = new MenuActualizarUsuario () {Nombre = "Actualizar Usuario" };
            var menuAltaCompraVenta = new MenuAltaCompraVenta () {Nombre ="Alta Ventas" };
            var menuAltaProducto = new MenuAltaProducto() {Nombre =" Alta Producto"};
            var menuListaProductoVenta = new MenuListaProductosVentas () {Nombre = "Lista de productos en ventas "};
            var menuAltaUsuario = new MenuAltaUsuario() { Nombre = "Alta Usuario" };
            var menuProducto = new MenuCompuesto() { Nombre = "Productos" };
            var menuListaUsuario = new menuListaUsuario () {Nombre = "Lista de Usuarios"};

            var menuActualizarProducto = new MenuActualizarProducto() {Nombre = "Actualizar Productos" };
            menuProducto.agregarMenu(menuListaProductoVenta);
            menuProducto.agregarMenu(menuActualizarProducto);
            menuProducto.agregarMenu(menuAltaProducto);

            var menuUsuario = new MenuCompuesto() { Nombre = "Usuarios" };
            menuUsuario.agregarMenu(menuActualizarUsuario);
            menuUsuario.agregarMenu(menuListaUsuario);

            var menuProductoVenta = new MenuCompuesto() { Nombre = "Productos" };
            menuProductoVenta.agregarMenu(menuAltaCompraVenta);
            menuProductoVenta.agregarMenu(menuListaProductoVenta);

            var menuAdministrador = new MenuCompuesto() { Nombre = "Menu Administrador" };
            menuAdministrador.agregarMenu(menuAltaUsuario);
            menuAdministrador.agregarMenu(menuProducto);
            menuAdministrador.agregarMenu(menuProductoVenta);
            menuAdministrador.agregarMenu(menuAltaUsuario);
            menuAdministrador.agregarMenu(menuUsuario);




            menuAdministrador.mostrar();


        }
    }
}
