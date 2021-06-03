using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.V3.ViewModels
{
    public class BebidaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public bool Alcolica { get; set; }
    }
}
