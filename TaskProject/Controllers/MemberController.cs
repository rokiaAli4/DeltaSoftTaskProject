using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskCore.Models;
using TaskCore;
using Microsoft.Extensions.Logging;


namespace TaskProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MemberController> _logger;

        public MemberController(IUnitOfWork unitOfWork, ILogger<MemberController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        [HttpGet("GetAll")]
        public IEnumerable<Member> GetAllMembers()
        {
            return _unitOfWork.Members.GetAll();
        }
    }
}
