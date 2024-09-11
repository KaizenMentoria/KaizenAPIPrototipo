using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KaizenAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Aluno : ControllerBase
    {
        public string Get()
        {
            return "Aluno";
        }
    }
}