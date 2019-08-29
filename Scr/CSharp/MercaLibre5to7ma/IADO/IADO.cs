using System;
using System.Collections.Generic;
using System.Text;

namespace Mercalibre15.ADO
{
    interface IADO
    {
        void Ausuario(Usuario usuario);
        List<Usuario> obtenerUsuarios();

        void Aproductoventa(Compraventa compraVenta);
        List<Compraventa> obtenerventas();

        void aproducto(Producto producto);
        List<Producto> obtenerproductos();
    }
}
