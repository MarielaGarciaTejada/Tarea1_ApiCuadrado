using Dapper;
using MiApiCuadrado.Api.Models; // Usamos el namespace que tienes en tu controlador
using MiApiCuadrado.DbContext;
using System.Collections.Generic;

namespace MiApiCuadrado.Services;

public class ProductoService
{
    private readonly DapperContext _context;
    public ProductoService(DapperContext context){
        _context = context;
    }

    public IEnumerable<Producto> ListaProductos()
    {
        var consulta = @"
            SELECT 
                Id_Producto AS IdProducto, 
                Nombre, 
                Descripción AS Descripcion, 
                Precio, 
                Stock, 
                FechaRegistro 
            FROM Productos"; 

        using (var connection = _context.CreateConnection())
        {
            // Consulta y devolución de los datos
            return connection.Query<Producto>(consulta);
        }
    }
}