using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OutLineHUMG.Models;

namespace OutLineHUMG.Pages.Admin.Specialized
{
    public class UpdateSpecializedModel : PageModel
    {
        [BindProperty]
        public Models.Specialized specUpdate { get; set; }
        private MyDbContext db; 
        public UpdateSpecializedModel(MyDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int id)
        {
            specUpdate = db.ListSpecialized.Find(id);
        }
        public IActionResult OnPostUpdate()
        {
            db.Entry(specUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToPage("ViewSpecialized");
        }
    }
}
