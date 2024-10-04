using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalApi.Dominio.ModelViews
{
    public struct ErrosDeValidacao
    {
        public List<string> Mensagem { get; set; }
    }
}