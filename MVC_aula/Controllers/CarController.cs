using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_aula.Controllers
{
    public class CarController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Cars = new Car().Lista();
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public void Criar()
        {
            var car = new Car();
            car.nome = Request["nome"];
            car.carro = Request["carro"];
            car.placa = Request["placa"];
            car.cor = Request["cor"];
            car.Save();
            Response.Redirect("/car");
        }
        public void Remover(int id)
        {
            Car.Remover(id);
            Response.Redirect("/car");
        }
    }
}