﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mercalibre15.ADO
{
    public interface IADO
    {
        void Ausuario(Usuario usuario);
        List<Usuario> obtenerUsuarios();

        void Aproductoventa(Compraventa compraVenta);
        List<Compraventa> obtenerventas();

        void aproducto(Producto producto);
        List<Producto> obtenerproductos();

        void altaUsuario(Usuario usuario);
        Usuario usuarioporcorreoPass(string correo , string passEncriptada);
    }
}
