using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApplication.Models;
using static TestApplication.Models.TestDbModel;


namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
        public class TestDbController : Controller
    {

        private readonly TestDbContext db;

        public TestDbController(TestDbContext testDbContext)
        {
            db = testDbContext;
        }
                     
        // GET api/<TestDb>/5
        [HttpGet("AllStyles")]
        public IEnumerable<XXIBM_PRODUCT_STYLE> GetAllStyles()
        {
            
                List<XXIBM_PRODUCT_STYLE> prodStyles = new List<XXIBM_PRODUCT_STYLE>();
                var data = (from d in db.XXIBM_PRODUCT_STYLE select d).ToList<XXIBM_PRODUCT_STYLE>();
                
                    prodStyles = data;
                    return prodStyles;
                      


            
        }
        // GET api/<TestDb>/5
        [HttpGet("AllProducts")]
        public IEnumerable<XXIBM_PRODUCT_SKU> GetAllProducts()
        {
            
                List<XXIBM_PRODUCT_SKU> products = new List<XXIBM_PRODUCT_SKU>();
                var data = (from d in db.XXIBM_PRODUCT_SKU select d).ToList<XXIBM_PRODUCT_SKU>();
                
                    products = data;
                    return products;

            
        }
        // GET api/<TestDb>/5
        [HttpGet("AllProductPricing")]
        public IEnumerable<XXIBM_PRODUCT_PRICING> GetAllProductPricing()
        {

            List<XXIBM_PRODUCT_PRICING> productPricing = new List<XXIBM_PRODUCT_PRICING>();
            var data = (from d in db.XXIBM_PRODUCT_PRICING select d).ToList<XXIBM_PRODUCT_PRICING>();

            productPricing = data;
            return productPricing;


        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

   