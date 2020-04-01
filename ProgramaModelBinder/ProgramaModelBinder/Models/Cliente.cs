using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaModelBinder.Models
{
    public class Cliente
    {
        public int cliId { get; set; }
        public string cliNome { get; set; }
        public string cliEnd { get; set; }
        public string cliNasc { get; set; }
    }
}