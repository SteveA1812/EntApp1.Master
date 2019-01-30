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
        public int Number1 { get; set; }

        [BindProperty]
        public int? Number2 { get; set; }

        [BindProperty]
        public double Number3 { get; set; }
        [BindProperty]
        public double? Number4 { get; set; }
        [BindProperty]
        public decimal Number5 { get; set; }
        [BindProperty]
        public decimal? Number6 { get; set; }
        [BindProperty]
        public float Number7 { get; set; }
        [BindProperty]
        public float? Number8 { get; set; }
      






        public void OnPost()
        {
            Message =
                   $"{Number1}";

        }
    }
}