using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OAuthWebApi.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }
    }

    #region Helpers
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ShippingCity { get; set; }
        public bool IsShipped { get; set; }

        public static List<Order> CreateOrders()
        {
            return new List<Order>{
                new Order{ OrderId = 10248, CustomerName = "Taiseer Joudeh", ShippingCity = "Amman", IsShipped = true},
                new Order{ OrderId = 10249, CustomerName = "Ahmad Hasan", ShippingCity = "Dubai", IsShipped = false},
                new Order{ OrderId = 10250, CustomerName = "Tamer Yaser", ShippingCity = "Jeddah", IsShipped = false},
                new Order{ OrderId = 10251, CustomerName = "Lina Majed", ShippingCity = "Abu Dhabi", IsShipped = false},
                new Order{ OrderId = 10252, CustomerName = "Yasmeen Rami", ShippingCity = "Kuwait", IsShipped = true}
            };
        }
    }
    #endregion
}
