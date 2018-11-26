using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace rsoi_app.Pages
{
    public class IndexModel : PageModel
    {
        public string Message => "Введите число для вычисления факториала";

        public string Result { get; set; }

        public void OnGet()
        {
        }
        public void OnPost(int? number)
        {
            try
            {
                Result = BusinesLogic.Factorial(number).ToString();
            }catch(Exception e)
            {
                Result = e.Message + ". Повторите ввод";
            }
        }
    }
}
