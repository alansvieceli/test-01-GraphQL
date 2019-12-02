using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteGraphQL.Entidades;
using TesteGraphQL.Modelos;
using TesteGraphQL.Serviços;

namespace TesteGraphQL.Queries
{
    public class EatMoreQuery : ObjectGraphType
    {
        //public EatMoreQuery(ApplicationDbContext db)
        public EatMoreQuery()
        {

            Field<ListGraphType<ProdutoType>, IEnumerable<Produto>>()
                .Name("produtos")
                .Resolve(context => ProdutoService.Produtos());
            

        }
    }
}
