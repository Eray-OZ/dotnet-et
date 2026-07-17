using EtApi.Application;
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
        public async Task Write()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), Name = "Product 4", Price = 400, CreatedDate=DateTime.Now, Stock=40},
                new() {Id = Guid.NewGuid(), Name = "Product 5", Price = 500, CreatedDate=DateTime.Now, Stock=50},
                new() {Id = Guid.NewGuid(), Name = "Product 6", Price = 600, CreatedDate=DateTime.Now, Stock=60},

            });


            await _productWriteRepository.SaveAsync();



        }

    }
}
