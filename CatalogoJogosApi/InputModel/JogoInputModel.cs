using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoJogosApi.InputModel
{  
        public class JogoInputModel
        {
            [Required]
            [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo deve conter entre 3 e 100 caracteres")]
            public string Nome { get; set; }
            [Required]
            [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome da produtora deve conter entre 3 e 100 caracteres")]
            public string Produtora { get; set; }
            [Required]
            [Range(1, 1000, ErrorMessage = "O preço deve ser de no mínimo 1 real e no máximo 1000 reais")]
            public double Preco { get; set; }
            
            //Preferi adicionar mais detalhes em cada jogo
            [Required]
            [Range(1971, 10000, ErrorMessage = "O ano do lançamento deve ser depois da data de 1971")]
            public int Ano { get; set; }
            
            [Required]
            [StringLength(100, MinimumLength = 2, ErrorMessage = "O gênero do jogo deve conter entre 2 e 100 caracteres")]
            public string Genero { get; set; }

    } 
}
