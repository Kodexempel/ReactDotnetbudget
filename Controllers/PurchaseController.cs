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
    [Route("api/purchase")]
    [ApiController]
    [Authorize]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService _service;
        private readonly string _userId;
        public PurchaseController(IPurchaseService service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        public PurchaseController(IPurchaseService service) => _service = service;
        // GET: api/<PurchaseController>
        [HttpGet]
        public IEnumerable<PurchaseDTO> Get()
        {
            return _service.Get(_userId);
        }

        // GET api/<PurchaseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PurchaseController>
        [HttpPost]
        public async Task Post([FromBody] Purchase purchase)
        {
            await _service.Post(purchase, _userId);
        }


        // PUT api/<PurchaseController>/5
        [HttpPut]
        public async Task Put([FromBody] EditPurchaseDTO editPurchaseDTO)
        {
           await _service.Edit(editPurchaseDTO);
        }

        // DELETE api/<PurchaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
