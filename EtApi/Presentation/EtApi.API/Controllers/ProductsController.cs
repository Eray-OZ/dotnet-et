using EtApi.Application;
using EtApi.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
 
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }


        [HttpGet]
        public async Task Get()
        {
            Product p = await _productReadRepository.GetByIdAsync("bd90d00e-7725-4dd0-9359-26924d8c0a44", false);
            p.Name = "Product 001";
            await _productWriteRepository.SaveAsync();
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product p = await _productReadRepository.GetByIdAsync(id);
            return Ok(p);
        }




    }
}
