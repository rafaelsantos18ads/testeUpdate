using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TesteUpdate.Models;



namespace TesteUpdate.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { ID = 1, Name = "Eletronicos" });
            list.Add(new Department { ID = 2, Name = "Moda" });

            return View(list);
        }
    }
}
