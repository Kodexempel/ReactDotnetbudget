using JohannasReactProject.Models.Entities;
using JohannasReactProject.Models.Web;
using JohannasReactProject.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JohannasReactProject.Controllers
{
    [Route("api/fixedcostcategory")]
    [ApiController]
    [Authorize]
    public class FixedCostCategoryController : ControllerBase
    {
        private readonly IFixedCostCategoryService _service;
        private readonly string _userId;
        public FixedCostCategoryController(IFixedCostCategoryService service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
        // GET: api/<FixedCostCategoryController>
        [HttpGet]
        public IEnumerable<FixedCostCategoryDTO> Get()
        {
            return _service.Get(_userId);
        }

        // GET api/<FixedCostCategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FixedCostCategoryController>
        [HttpPost]
        public async Task Post([FromBody] FixedCostsCategories fixedCostCategories)
        {
            await _service.Post(fixedCostCategories, _userId);
        }

        // PUT api/<FixedCostCategoryController>/5
        [HttpPut]
        public async Task Put([FromBody] EditFixedCostCategoryDTO editFixedCostCategoryDTO)
        {
            await _service.Edit(editFixedCostCategoryDTO);
        }

        // DELETE api/<FixedCostCategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
