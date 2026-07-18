using EtApi.Application;
using EtApi.Domain.Entities;
using EtApi.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        readonly private ICustomerWriteRepository _customerWriteRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
        }


        [HttpGet]
        public async Task Get()
        {
            var customerId = Guid.NewGuid();
            await _customerWriteRepository.AddAsync(new() {Id=customerId, Name="Name 1"});
            await _orderWriteRepository.AddAsync(new() {Description="This is a desc", Address="Balıkesir, Bandırma", CustomerId=customerId});
            await _orderWriteRepository.AddAsync(new() {Description="Desc is a this", Address="Balıkesir, Erdek", CustomerId=customerId});
            await _orderWriteRepository.SaveAsync();

        }

        [HttpGet("Id")]
        public async Task Get(string id)
        {
            var product = await _productReadRepository.GetByIdAsync(id);
            product.Name = "Test Product";
            await _productWriteRepository.SaveAsync();
        }





    }
}
