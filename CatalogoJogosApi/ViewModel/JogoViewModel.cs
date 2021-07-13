using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoJogosApi.ViewModel
{
    public class JogoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
    }
}
