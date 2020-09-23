﻿using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "Au! Au!";
        }

        public string QuantoDevoComer(int peso)
        {
            return "Como tenho " + peso + "Kg, devo comer " + ((peso*1000)*0.05) +  "g por dia";
        }
    }
}
