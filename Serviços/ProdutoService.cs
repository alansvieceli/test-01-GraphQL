using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteGraphQL.Entidades;

namespace TesteGraphQL.Serviços
{
    public class ProdutoService
    {
        private static readonly string[] Nomes = new[] { "Alan", "Jaque", "Rosa", "Graziela", "Irceu", "Tia Paula" };
        private static readonly double[] Precos = new[] { 10.50, 5.44, 3.78, 1.99, 6.55 };
        private static readonly string[] CodBarras = new[] { "100000010000011000002", "100000010000011000004", "100000010000011000007", "100000010000011000009", "100000010000012000002", "100000010000011000003" };

        public static IEnumerable<Produto> Produtos()
        {
            var rng = new Random();
            return Enumerable.Range(1, 6).Select(index => new Produto
            {
                CodigoBarras = CodBarras[rng.Next(CodBarras.Length)],
                Nome = Nomes[rng.Next(Nomes.Length)],
                Preco = Precos[rng.Next(Precos.Length)]
            })
            .ToArray();

        }

    }
}
