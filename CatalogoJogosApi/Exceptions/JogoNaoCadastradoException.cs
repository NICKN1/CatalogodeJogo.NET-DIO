﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoJogosApi.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException()
            : base("Este jogo não está cadastrado")
        { }
    }
}
