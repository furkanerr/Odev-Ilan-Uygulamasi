using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;
using ÖdevUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ÖdevUI.Controllers
{
    public class AnasayfaController : Controller
    {
        private readonly IAdsService _adsService;

        public AnasayfaController(IAdsService adsService)
        {
            _adsService = adsService;
        }


        public IActionResult Anasayfa()
        {
            var IlanlarVeKategoriler = _adsService.İlanlarinKategorisiVePetCinsleri();

            

           

            AdsListViewModel model = new AdsListViewModel
            {
                IlanlarVeKategoriler=IlanlarVeKategoriler.Take(10).ToList(),
               
            };

            return View(model);

        }
    }

   
}
