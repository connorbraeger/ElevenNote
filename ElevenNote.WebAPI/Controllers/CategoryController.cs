using ElevenNote.Models;
using ElevenNote.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote.WebAPI.Controllers
{
    [Authorize]
    public class CategoryController : ApiController
    {
        public IHttpActionResult Get()
        {
            var service = new CategoryService();
            var categories = service.GetCategories();
            return Ok(categories);
        }
        public IHttpActionResult Get(int id)
        {
            var service = new CategoryService();
            var category = service.GetCategoryById(id);
            return Ok(category);
        }
        public IHttpActionResult Post(CategoryCreate category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = new CategoryService();
            if (!service.CreateCategory(category))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Put(CategoryEdit category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = new CategoryService();
            if (!service.UpdateCategory(category))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = new CategoryService();
            if (!service.DeleteCategory(id))
                return InternalServerError();
            return Ok();
        }
        
    }
}
