using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteGraphQL.Entidades;
using TesteGraphQL.Serviços;

namespace TesteGraphQL.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return ProdutoService.Produtos();
        }

    }
}
