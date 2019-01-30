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
        public string Message1 { get; set; }
        public string Answer { get; set; }
        public void OnPost()
        {
            string n1 = Request.Form["Number1"];
            if(n1==null)
            { n1 = "0"; }
            int N1 = Int32.Parse(n1);
            string n2 = Request.Form["Number2"];
            if (n2 == null)
            { n2 = "0"; }
            int N2 = Int32.Parse(n2);
            int answer = N1 + N2;

            Message = $"The Sum of {n1} and {n2} is {answer} ";

        }
        public void GetChoiceCalc()
        {
            string n3 = Request.Form["Number3"];
            int N3 = Int32.Parse(n3);
            string n4 = Request.Form["Number4"];
            int N4 = Int32.Parse(n4);
            var choice = Request.Form["Answer"];


            if (choice == "Add")
            {
                int answer = N3 + N4;

                Message1 = $"The Sum of {n3} and {n4} is {answer} ";
            }
        }









        




        
    }
}