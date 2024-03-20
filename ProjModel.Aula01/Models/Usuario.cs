using Microsoft.AspNetCore.Identity;

namespace ProjModel.Aula01.Models
{
    public class Usuario : IdentityUser
    {
        public string NomeCompleto { get; set; }
        public string RA { get; set; } //pq int

    }
}
