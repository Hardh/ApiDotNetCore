using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestDotNetCore.Data;
using ApiRestDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiRestDotNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly CoreMigrationDbContext context;

        public PessoaController(CoreMigrationDbContext context)
        {
        //Implementar Reposytori
        //https://www.youtube.com/watch?v=qJmEI2LtXIY
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            return this.context.Pessoas;
        }
    }
}
