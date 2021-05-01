using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OutLineHUMG.Models;
using Microsoft.AspNetCore.Http;

namespace OutLineHUMG.Pages.Admin.Specialized
{
    public class CreateSpecializedModel : PageModel
    {
        private MyDbContext db;
        [BindProperty]
        public Models.Specialized ChuyenNgang { get; set; }
        public List<Models.Specialized> ListChuyenNgang;
        private readonly IWebHostEnvironment _en;
        public string messErr { get; set; } = null; 
        public CreateSpecializedModel(MyDbContext _db, IWebHostEnvironment environment)
        {
            db = _db;
            _en = environment;
        }

        public void OnGet()
        {
            ListChuyenNgang = db.ListSpecialized.ToList();
            ChuyenNgang = new Models.Specialized();
        }
        public const string Messagekey = nameof(Messagekey);
        public IActionResult OnPost()
        {
            TempData[Messagekey] = "Trùng mã môn học , vui lòng nhập lại !"; 
            var check = db.ListSpecialized.Where(item => item.CodeSpecialized == ChuyenNgang.CodeSpecialized).FirstOrDefault();
            
            if(check != null)
            {
                messErr = "already in the databse.Input again";
                return RedirectToPage(new { messErr });
            }
            else
            {
                messErr = null;
                db.ListSpecialized.Add(ChuyenNgang);
                db.SaveChanges();
                return RedirectToPage("ViewSpecialized");
            }
            //foreach(var x in ListChuyenNgang)
            // {
            //     if(x.Idspecialized == ChuyenNgang.Idspecialized)
            //     {
            //         messErr = "already in the databse.Input again";
            //     }
            //     else
            //     {
            //         messErr = null;
            //         db.ListSpecialized.Add(ChuyenNgang);
            //         db.SaveChanges();
            //     }
            // }
            
        }
    }
}
