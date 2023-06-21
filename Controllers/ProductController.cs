using CRUDOprationAPI.Data;
using CRUDOprationAPI.Interface.Manager;
using CRUDOprationAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOprationAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ApplicationDBContext _dbcontext;
        private readonly ILogger<ProductController> _logger;
        IProductManager _productmanager;
        //public ProductController(ApplicationDBContext dbContext)
        //{
        //    _dbcontext = dbContext;
        //    _manager=new ProductManager(dbContext);
        //}
        public ProductController(ILogger<ProductController> logger, IProductManager productmanager, ApplicationDBContext dbContext)
        {

            _logger = logger;
            _productmanager = productmanager;
            _dbcontext = dbContext;
        }
        [HttpGet]
        public ActionResult<ProductMaster> GetAll()
        {
            _logger.LogInformation("GetAll method started");
            //var product = _dbcontext.ProductMaster.ToList();
            try
            {
                var product = _productmanager.GetAll().ToList();
                if (product.Count == 0)
                {
                    return NotFound("Product Not ..........");
                }
                return Ok(product);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [Route("{id}")]
        [HttpGet]
        public ActionResult<ProductMaster> GetById(int id)
        {
            try
            {
                //var product = _dbcontext.ProductMaster.ToList();
                var product = _productmanager.GetById(id);
                if (product == null)
                {
                    _logger.LogWarning(" Not Found Id ");
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(" Not Found Id");
                return BadRequest(ex.Message);
            }
        }

        [Route("{id}")]
        [HttpPut]
        public ActionResult<ProductMaster> Edit(ProductMaster productMaster)
        {
            try
            {

                if (productMaster.P_Id == 0)
                {
                    return BadRequest("Product Update Failed.");
                }
                bool isUpdate = _productmanager.Update(productMaster);

                if (isUpdate)
                {
                    return Ok(productMaster);
                }

                return BadRequest("Product Update Failed.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<ProductMaster> Add(ProductMaster productMaster)
        {
            bool isSave = _productmanager.Add(productMaster);
            //_dbcontext.ProductMaster.Add(productMaster);
            //bool isSave = _dbcontext.SaveChanges() > 0;
            if (isSave)
            {
                return productMaster;
            }

            return null;
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                var pro = _productmanager.GetById(id);
                if (pro == null)
                {
                    return NotFound();
                }
                bool isDelete = _productmanager.Delete(pro);

                if (isDelete)
                {
                    return Ok("commit.");
                }

                return BadRequest("Product Deleted .");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }

}
