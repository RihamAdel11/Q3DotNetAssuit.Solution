using Microsoft.AspNetCore.Mvc;

namespace Q3DotNetAssuit.Controllers
{
    public class BindController : Controller
    {
        public IActionResult TestPerimitive(string name,int age)
        {

            return Content($"{name}/t {age}");
        }
        //Bind Collections
        // /Bind/TestDic?dic[Ahmed]=123
        public IActionResult TestDic(Dictionary <string, string> dic) 
        {

            return Content("Ok");
        }
    }
}
