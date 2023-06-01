using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        // GET: api/<OrderController>
        [HttpGet("{id}")]
        public ActionResult<Order> Get(string id)
        {
            return orderService.GetOrders(id);
        }

        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] ProductOrder productOrder)
        {
            orderService.AddProduct(id, productOrder);
            return NoContent();
        }

    }
}
