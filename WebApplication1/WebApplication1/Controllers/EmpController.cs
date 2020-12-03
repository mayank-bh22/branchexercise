using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            List<Emp> list = new List<Emp>()
            {
                new Emp{EId=1,EName="Zoya",EDesig="HR",EDOJ=new DateTime(day:11,month:11,year:2016) },
                 new Emp{EId=1,EName="Rahul",EDesig="Consultant",EDOJ=new DateTime(day:21,month:11,year:2006) },
                  new Emp{EId=1,EName="Fazil",EDesig="Client",EDOJ=new DateTime(day:01,month:01,year:2018) },
                   new Emp{EId=1,EName="Meera",EDesig="Designer",EDOJ=new DateTime(day:25,month:06,year:2019) }

            };
            return View(list);
        }
    }
}
