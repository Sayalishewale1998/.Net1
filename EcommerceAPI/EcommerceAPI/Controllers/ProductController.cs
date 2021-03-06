using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ECommerceDBContext db;
        public ProductController(ECommerceDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        
        public IEnumerable<TblProduct> GetProducts()
        {
            return db.TblProducts;
        }
    }
}
