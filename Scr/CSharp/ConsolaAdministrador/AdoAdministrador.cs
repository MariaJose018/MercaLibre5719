using Mercalibre15.ADO;

namespace ConsolaAdministrador
{
    /// <summary>
    /// Clase estatica que proporcionado el ADO seteado para un gerente
    /// </summary>
    public static class AdoGerete
    {
        /// <summary>
        /// Propiedad para acceso al ADO
        /// </summary>
        public static IADO ADO { get; set; } =
            Factory.GetAdoDesdeJson("appsettings.json", "gerente");
    }
}
