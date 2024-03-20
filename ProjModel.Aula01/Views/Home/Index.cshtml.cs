using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjModel.Aula01.Data;
using ProjModel.Aula01.Models;

namespace ProjModel.Aula01.Controllers
{
    public class IndexModel : PageModel
    {
        private readonly ProjModel.Aula01.Data.ApplicationDbContext _context;

        public IndexModel(ProjModel.Aula01.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Categoria> Categoria { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Categoria = await _context.Categorias.ToListAsync();
        }
    }
}
