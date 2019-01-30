using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.Master.pages
{
    public class taghelpplayModel : PageModel
    {
        public void OnGet()
        {
        }
        public string Message { get; set; }
        [BindProperty]
        public DateTime? Number1 { get; set; }
        [BindProperty]
        public bool IsContactAllowed { get; set; }










        public void OnPost()
        {
            Message =
                   $"{Number1}";

        }
    }
}