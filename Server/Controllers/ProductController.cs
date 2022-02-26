using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new()
        {
            new Product
            {
                Id = 1,
                Title = "The Hitchhiker's Guide to the Galaxy, v1.1",
                Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                Price = 12.99m,
                ImageUrl = "https://th.bing.com/th/id/OIP.sZidizqnhAyTX0Tnx1i4ywHaKj?w=208&h=297&c=7&r=0&o=5&dpr=1.25&pid=1.7"
            },
            new Product
            {
                Id = 1,
                Title = "Ready Player One, v1.1",
                Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline.",
                Price = 29.99m,
                ImageUrl = "https://th.bing.com/th/id/R.7a2446a678be4698c510c698d3386ea4?rik=rPXgM6tmXc6p8Q&pid=ImgRaw&r=0"
            },
            new Product
            {
                Id = 1,
                Title = "1984, v1.1",
                Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                Price = 9.99m,
                ImageUrl = "https://th.bing.com/th/id/OIP.QZQQcihFq4QJ28fXUzQskgDJE1?w=201&h=309&c=7&r=0&o=5&dpr=1.25&pid=1.7"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(Products);
        }
    }
}
