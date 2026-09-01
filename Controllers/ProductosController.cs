using Dapper;
using MiWebApi.Api.Models;
using MiWebApi.DbContext;
using MiWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MiWebApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ProductosController : ControllerBase
{
    private readonly ProductoService _productoService;
    public ProductosController(ProductoService productoService)
    {
        _productoService = productoService;
    }
    
    [HttpGet]
    public IActionResult GetListaProductos()
    {
        //llamamos al servicio de ProductoService
        var productos = _productoService.ListaProductos();
        
        return Ok(productos);
    } 
}