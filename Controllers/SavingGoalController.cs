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
    [Route("api/savinggoal")]
    [ApiController]
    [Authorize]
    public class SavingGoalController : ControllerBase
    {
        private readonly ISavingGoalService _service;
        private readonly string _userId;
      
        public SavingGoalController(ISavingGoalService service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
        // GET: api/<SavingGoalController>
        [HttpGet]
        public IEnumerable<SavingGoalDTO> Get()
        {
            return _service.Get(_userId);
        }

        // GET api/<SavingGoalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SavingGoalController>
        [HttpPost]
        public async Task Post([FromBody] SavingGoal savingGoal)
        {
            await _service.Post(savingGoal, _userId);
        }

        // PUT api/<SavingGoalController>/5
        [HttpPut]
        public async Task Put([FromBody] EditSavingGoalDTO editSavingGoalDTO)
        {
           await _service.Edit(editSavingGoalDTO);
        }

        // DELETE api/<SavingGoalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
