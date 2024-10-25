using Microsoft.AspNetCore.Mvc;
using WebProyect.Models;
namespace BackendApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProduct()
    {
        List<Stock> products = new List<Stock>()
       {
        new Stock { IDproduct = 1, ProductName = "Noche de pasion", ProductDescription = "Una noche de pasion con tu flaco preferido", Price = 10.60m, ImageProductUrl = "image1.jpg" },
        new Stock { IDproduct = 2, ProductName = "Los tenis de gabriela", ProductDescription = "Unos adidas ahí", Price = 15.99m, ImageProductUrl = "image2.jpg" },
        new Stock { IDproduct = 3, ProductName = "Pizza hawaiana", ProductDescription = "piña y jamon en una pizza", Price = 12.34m, ImageProductUrl = "image3.jpg" },
        new Stock { IDproduct = 4, ProductName = "Ticket para frases", ProductDescription = "Usa este ticket para decir una frase", Price = 1.30m, ImageProductUrl = "image4.jpg" },
        new Stock { IDproduct = 5, ProductName = "El Choco", ProductDescription = "Yo? queeee se yooo de eso", Price = 123.60m, ImageProductUrl = "image5.jpg" },
        new Stock { IDproduct = 6, ProductName = "El chupamatracas 3000", ProductDescription = "te succiona la vida", Price = 7.56m, ImageProductUrl = "image6.jpg" },
        
       };

    return Ok(products);
    }
}