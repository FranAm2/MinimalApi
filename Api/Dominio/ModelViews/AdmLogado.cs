using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalApi.Dominio.ModelViews
{
    public record AdmLogado
    {
        public string Token { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
    }
}