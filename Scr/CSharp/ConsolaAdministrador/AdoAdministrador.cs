using Mercalibre15.ADO;

namespace ConsolaAdministrador
{
    
    public static class AdoAdministrador
    {
        public static IADO ADO { get; set; } =
            FactoryADOMysql.GetAdoDesdeJson("appsettings.json", "Administrador");
    }
}
