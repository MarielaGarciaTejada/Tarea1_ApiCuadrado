using System.Data;
using Microsoft.Data.SqlClient;

namespace MiWebApi.DbContext
{
    public class DapperContext{

        private readonly IConfiguration _configuracion;
        private readonly String _connectionString;

        //Inyectar IConfiguration para leer el archivo de appsettings.json
        public DapperContext(IConfiguration configuracion)
        {
            _configuracion = configuracion;
            // buscamos la cadena de conexion de somee 
            _connectionString = _configuracion.GetConnectionString("SomeeConnection");
        }

       /* metodo de crear y devolver la conexion a Sql Server
       este metodo es una interfaz de conexion que se puede conectar a cualquier base de datos */
        public IDbConnection CreateConnection()
        { return new SqlConnection(_connectionString); }
    }

}