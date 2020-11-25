using Microsoft.AspNetCore.Mvc;
using ProductService.Persistence;

namespace ProductService.Controllers
{
  [Route("api/[controller]")]
  public class ProductController : Controller
  {
    private readonly IProductRepository _ProductRepository;
    public ProductController(IProductRepository ProductRepository)
    {
      _ProductRepository = ProductRepository;
    }
  }
}