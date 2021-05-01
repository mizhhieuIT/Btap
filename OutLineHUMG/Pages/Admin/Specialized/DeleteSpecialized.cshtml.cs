using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OutLineHUMG.Models;

namespace OutLineHUMG.Pages.Admin.Specialized
{
    public class DeleteSpecializedModel : PageModel
    {
        private MyDbContext db;
        public DeleteSpecializedModel(MyDbContext _db)
        {
            db = _db;
        }
        [BindProperty(SupportsGet = true)]
        public Models.Specialized specDelete { get; set; }
        public IActionResult OnGetDelete(int id)
        {
            specDelete = db.ListSpecialized.Find(id);
            db.ListSpecialized.Remove(specDelete);
            db.SaveChanges();
            return RedirectToPage("ViewSpecialized");
        }
    }
}
