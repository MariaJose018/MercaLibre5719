﻿using Mercalibre15;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;

namespace TestPruebaMercalibre
{
    [TestClass]
    public class TestUsuario
    {
        Usuario usuario { get; set; }
        [TestInitialize]
        public void CrearUsuario()
        {
            usuario.Nombre = "Alberto";
            usuario.Apellido = "Fernandez";
            usuario.Telefono = 1134552177;
            usuario.Nombredeusuario = "AlbertocuAbierto";
            usuario.Email = "Alberto@gmail.com";
            usuario.Contrasenia = "AlbertoyCristina";

        }


    }
}
