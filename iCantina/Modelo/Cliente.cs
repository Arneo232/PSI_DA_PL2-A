﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Modelo
{
    internal class Cliente : Utilizador
    {
        public float Saldo { get; set; }   
        public List <Fatura> Faturas { get; set; }
    }
}
