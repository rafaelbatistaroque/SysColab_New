﻿using SysColab.Dominio.Enums;
using System;

namespace SysColab.Dominio.Entities
{
    public class Salario
    {
        public double Remuneracao { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public AlteracaoSalarial Motivo { get; private set; }
    }
}
