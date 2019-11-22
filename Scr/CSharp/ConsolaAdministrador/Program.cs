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
            var menuListaProductoVenta = new MenuListaProductosVentas () {Nombre = "Lista de productos en ventas "};
            var menuListaUsuario = new menuListaUsuario () {Nombre = "Lista de Usuarios"};
            var menuAltaUsuario = new MenuAltaUsuario() { Nombre = "Alta Usuario" };

            var menuProducto = new MenuCompuesto() { Nombre = "Productos" };
            menuProducto.agregarMenu(menuListaProductoVenta);
            menuProducto.agregarMenu(menuActualizarProducto);
            menuProducto.agregarMenu(menuAltaProducto);

            var menuUsuario = new MenuCompuesto() { Nombre = "Usuarios" };
            menuUsuario.agregarMenu(menuActualizarUsuario);
            menuUsuario.agregarMenu(menuListaUsuario);

            var menuProductoVenta = new MenuCompuesto() { Nombre = "productos en venta" };
            menuProductoVenta.agregarMenu(menuAltaCompraVenta);
            menuProductoVenta.agregarMenu(menuListaProductoVenta);


            var menuAdministrador = new MenuCompuesto() { Nombre = "Menu Administrador" };
            menuAdministrador.agregarMenu(menuProducto);
            menuAdministrador.agregarMenu(menuProductoVenta);
            menuAdministrador.agregarMenu(menuUsuario);
            menuAdministrador.agregarMenu(menuAdministrador);

            menuAdministrador.mostrar();


        }
    }
}
