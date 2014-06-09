using EmployeeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Text;
using System.Drawing;
using System.Linq;

namespace EmployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(Employe emp)
        {

            //Creo el objeto del modelo de datos
            Payrolldm nomina = new Payrolldm(
                @"C:\Users\D630\Documents\Visual Studio 2012\Projects\Recover\EmployeeQuiz\Models\EmployeeDb.csv");

            //busco el empleado dado su id
            var empleado = nomina.GetEmployeById(emp.Id);



            try
            {
                double validacion = double.Parse(emp.Id);

                if (validacion <= 5 && validacion >= 1)
                {

                    return View("WorkerView", empleado);
                }
                else
                {

                    return View("Error");

                }
            }
            catch
            {
                return View("Error");
            }
               
            }




    }
}
