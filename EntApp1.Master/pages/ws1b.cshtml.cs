using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.Master.pages
{
    public class ws1bModel : PageModel
    {
        public void OnGet()
        {
        }
        public string Message { get; set; }
        public void OnPost()
        {
            string n1 = Request.Form["Number1"];
            int N1 = Int32.Parse(n1);
            string n2 = Request.Form["Number2"];
            int N2 = Int32.Parse(n2);
            int answer = N1 + N2;

            Message = $"The Sum of {n1} and {n2} is {answer} ";

        }
    }
}