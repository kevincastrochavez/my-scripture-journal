using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Pages.Scriptures
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Scripture != null)
            {
                Scripture = await _context.Scripture.ToListAsync();
            }
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
