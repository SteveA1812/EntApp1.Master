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

        [BindProperty]
        public string Season{ get; set; }








        public void OnPost()
        {
           if(Season=="Winter")
            { Message = "You have chosen Winter"; }

           else if (Season == "Spring")
            { Message = "You have chosen Spring"; }
            else if (Season == "Summer")
            { Message = "You have chosen Summer"; }
            else  
            { Message = "You have chosen Autumn"; }
        }
    }
}