﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (Tabela) Funcionarios
    /// </summary>
    public class PeopleDomain
    {
        
        public int IdFuncionario { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }

    }
}