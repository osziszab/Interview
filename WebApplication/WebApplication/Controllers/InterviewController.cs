using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Entities;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly InterviewService interviewService;

        public InterviewController(InterviewService interviewService)
        {
            this.interviewService = interviewService;
        }

        [Route("tests/ten")]
        [HttpGet]
        public IActionResult GetTestfromFixedDate()
        {
            try
            {
                List<Test> result = interviewService.GetTenTestsFromFixDate();
                return Ok(result);
            }
            catch (NullReferenceException ex)
            {
                return BadRequest("The database is empty");
            }
        }

        [Route("modify")]
        [HttpPost]
        public IActionResult PostString([FromBody]Input input)
        {
            try
            {
                string result = interviewService.CharacterDivider(input.Userinput);
                return Ok(result);
            }
            catch (NullReferenceException ex)
            {
                return BadRequest("the given string is empty");
            }
        }
    }
}