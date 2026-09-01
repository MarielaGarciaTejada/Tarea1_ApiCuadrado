namespace MiWebApi.Api.Models
{
   public class Producto
    {
        public int Id_Producto {get; set;}
        public string Nombre {get; set;}
        public string? Descripcion {get; set;}
        public decimal Precio {get; set;}
        public int Stock {get; set;}
        public DateTime FechaRegistro{get; set;}
    }
}