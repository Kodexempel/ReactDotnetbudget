using JohannasReactProject.Models;
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
    [Route("api/variablecostcategory")]
    [ApiController]
    [Authorize]
    public class VariableCostCategoryController : ControllerBase
    {
        private readonly IVariableCostCategoryService _service;
        private readonly string _userId;

        public VariableCostCategoryController(IVariableCostCategoryService service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
        // GET: api/<VariableCostCategoryController>
        [HttpGet]
        public IEnumerable<VariableCostCategoryDTO> Get()
        {
            return _service.Get(_userId);
        }

        // GET api/<VariableCostCategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VariableCostCategoryController>
        [HttpPost]
        public async Task Post([FromBody] VariableCostsCategories variableCostsCategories)
        {
            await _service.Post(variableCostsCategories, _userId);
        }

        // PUT api/<VariableCostCategoryController>/5
        [HttpPut]
        public async Task Put( [FromBody] EditVariableCostCategoryDTO editVariableCostCategoryDTO)
        {
            await _service.Edit(editVariableCostCategoryDTO);
        }

        // DELETE api/<VariableCostCategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
