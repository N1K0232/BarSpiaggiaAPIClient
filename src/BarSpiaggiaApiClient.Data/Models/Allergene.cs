﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpiaggiaApiClient.Data.Models
{
    public class Allergene
    {
        public Guid IDAllergene { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
    }
}