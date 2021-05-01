using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OutLineHUMG.Models;

namespace OutLineHUMG.Pages.Admin.Specialized
{
    public class ViewSpecializedModel : PageModel
    {
        private MyDbContext db;
        public List<Models.Specialized> spec;
        public ViewSpecializedModel(MyDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            spec = db.ListSpecialized.ToList();
        }
    }
}
