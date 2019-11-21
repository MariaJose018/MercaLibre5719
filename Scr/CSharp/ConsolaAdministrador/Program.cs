using MenuesConsola;
using ConsolaAdministrador.Menus;

namespace ConsolaAdministrador
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuActualizarProducto = new MenuActualizarProducto() {Nombre = "Actualizar Productos" };
            var menuActualizarUsuario = new MenuActualizarUsuario () {Nombre = "Actualizar Usuario" };
            var menuAltaCompraVenta = new MenuAltaCompraVenta () {Nombre ="Alta Ventas" };
            var menuAltaProducto = new MenuAltaProducto() {Nombre =" Alta Producto"};
            var menuListaProductoVenta = new MenuListaProductosVentas () {Nombre = "Lista de Ventas "};
            var menuListaUsuario = new menuListaUsuario () {Nombre = "Lista de Usuarios"};

            var menuProducto = new MenuCompuesto(menuAltaProducto) { Nombre = "Productos" };
            menuProducto.agregarMenu(menuListaProductoVenta);
            menuProducto.agregarMenu(menuActualizarProducto);
            menuProducto.agregarMenu(menuAltaProducto);

            var menuUsuario = new MenuCompuesto(menuAltaProducto) { Nombre = "Usuarios" };
            menuUsuario.agregarMenu(menuActualizarUsuario);
            menuUsuario.agregarMenu(menuListaUsuario);

            var menuProductoVenta = new MenuCompuesto() { Nombre = "productos ventas" };
            menuProductoVenta.agregarMenu(menuAltaCompraVenta);
            menuProductoVenta.agregarMenu(menuListaProductoVenta);

            var menuAdministrador = new MenuCompuesto() { Nombre = "Menu Administrador" };
            menuAdministrador.agregarMenu(menuProducto);
            menuAdministrador.agregarMenu(menuProductoVenta);
            menuAdministrador.agregarMenu();

            menuAdministrador.mostrar();


        }
    }
}
