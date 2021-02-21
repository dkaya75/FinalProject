using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {//loosely coupled
        //this yerine alt çizgi
        //aşağıdakini yapmam sebebimiz diğer sınıflarla bağlantıyı kesmek
        //naming convention bunlar fielddir defoultu private olarak da yazılabilir alt çizgi olarak da yazazbiliyoruz
        //IoC Contaioner:Inversion of control:Liste gibi listeye referanslar koyalım ProductManager,EfProductDal.. gibi ihtiyacı olan gelen alsın 
        IProductService _productService;//IProductService injection oluşturdum
        //startup da singelton kullandık araştır Ioc için
        public ProductsController(IProductService productService)
        {
            _productService = productService;//constructor da bir manager istedik
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)//==true mi demek
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyId")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult PostAdd(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
