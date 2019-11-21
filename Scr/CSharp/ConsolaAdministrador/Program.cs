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
            var menuAltaCompraVenta = new MenuAltaCompraVenta () { };
            var menuAltaProducto = new MenuAltaProducto() {Nombre =" Alta Producto"};
            var menuListaProductoVenta = new MenuListaProductosVentas () {Nombre = "Ñista de Ventas "};
            var menuListaUsuario = new menuListaUsuario () {Nombre = "Lista de Usuarios"};

            var menuProducto = new MenuCompuesto(menuAltaProducto) { Nombre = "Productos" };
            menuProducto.agregarMenu(menuListaProductoVenta);
            menuProducto.agregarMenu(menuActualizarProducto);

            var menuAdministrador = new MenuCompuesto() { Nombre = "Menu Administrador" };
            menuAdministrador.agregarMenu(menuProducto);
            menuAdministrador.agregarMenu(menuListaUsuario);
            menuAdministrador.agregarMenu(menuListaProductoVenta);

            var menuUsuario = new MenuCompuesto(menuAltaProducto) { Nombre = "Usuarios" };
            menuProducto.agregarMenu(menuActualizarUsuario);
            menuProducto.agregarMenu(menuListaUsuario);

            var menuProductoVenta = new MenuCompuesto() { Nombre = "productos ventas" };
            menuProductoVenta.agregarMenu(menuAltaCompraVenta);
            menuProductoVenta.agregarMenu(menuListaProductoVenta);

            menuAdministrador.mostrar();


        }
    }
}
