using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;
using ÖdevUI.Models;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace ÖdevUI.Controllers
{
    public class IlanController : Controller
    {
        private readonly IAdsService _adsService;
        private readonly IPetTypeService _petTypeService;
        private readonly ICategoryService _categoryService;
        private readonly IPetBreedService _petBreedService;
        private readonly IGenderService _petGenderSerivce;
        private readonly ICityService _cityService;
        private readonly IUserService _userService;
        private readonly IWebHostEnvironment _env;
        private readonly ICommentService _commentService;
       
       
        public IlanController(IAdsService adsService, IPetTypeService petTypeService, ICategoryService categoryService,
            IPetBreedService petBreedService, IGenderService petGenderSerivce, ICityService cityService, IUserService userService,
            IWebHostEnvironment env, ICommentService commentService,   IAdsDal adsDal)
        {
            _adsService = adsService;
            _petTypeService = petTypeService;
            _categoryService = categoryService;
            _petBreedService = petBreedService;
            _petGenderSerivce = petGenderSerivce;
            _cityService = cityService;
            _userService = userService;
            _env = env;
            _commentService = commentService;
           
          
        }


        public IActionResult Ilanlar(int category, int petBreed, int petTypes, int page = 1)

        {

            int pageSize = 10;

            var adsByCategory = _adsService.İlanlarinKategorisiVePetTipi(category, petBreed, petTypes);

            AdsListViewModel model = new AdsListViewModel
            {
                PetTypes = _petTypeService.GetByCategory(petTypes),
                IlanlarKategorilerVePetTipleri = adsByCategory.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int) Math.Ceiling(adsByCategory.Count / (double) pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page


            };
            return View(model);

        }

 
        [HttpGet]
       
        public ActionResult IlanEkle()
        {
            var Id = HttpContext.Session.GetInt32("ıd");
            if (Id == null)
            {
                return Redirect("~/Account/Login");
            }
            var model = new AdsAddViewModel
            {
                Ads = new Ads(),
                AdsCategory = _categoryService.GetAll(),
                PetBreed = _petBreedService.GetAll(),
                PetType = _petTypeService.GetAll(),
                City = _cityService.GetAll(),
                Gender = _petGenderSerivce.GetAll(),
                User = _userService.GetById(Convert.ToInt32(Id))

            };
         
            return View(model);
        }

        [HttpPost]
        
        public ActionResult IlanEkle(Ads ads)
        {
            int adsId = ads.Id;
            var Id = HttpContext.Session.GetInt32("ıd");
            if (Id == null)
            {
                return Redirect("~/Account/Login");
            }

            if (ads.CoverPhoto != null)
            {
                string folder = "Images/";

               ads.PetPhoto= UploadImage(folder, ads.CoverPhoto);

                //var tempPath=Guid.NewGuid().ToString() + "_" + ads.CoverPhoto.FileName;
                //folder += tempPath;

                // string serverFolder = Path.Combine(_env.WebRootPath,folder);
                // ads.PetPhoto ="/"+ folder;
                // ads.CoverPhoto.CopyTo(new FileStream(serverFolder, FileMode.Create));


            }

            //if (ads.GalleryFiles != null)
            //{
            //    string folder = "Images/Gallery/";

            //    var fotolar = new AdsGallery();


            //    ads.Gallery = new List<GalleryModel>();
            //    foreach (var file in ads.GalleryFiles)
            //    {


            //        var gallery = new GalleryModel()
            //        {

            //            Name = file.FileName,
            //            URL = UploadImage(folder, file)
            //        };
            //        ads.Gallery.Add(gallery);
            //    }
            //}


            ads.UsersId = Convert.ToInt32(Id);



            _adsService.Add(ads);
            return RedirectToAction("IlanEkle");
        }


        private string UploadImage(string folderPath, IFormFile file)
        {
          
               
            folderPath+=Guid.NewGuid().ToString() + "_" + file.FileName;
           
                
            string serverFolder = Path.Combine(_env.WebRootPath,folderPath);
          
            file.CopyTo(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderPath;
        }




        [HttpGet]
        public ActionResult Update(int adsId)
        {
            
            var Id=   HttpContext.Session.GetInt32("ıd");
            if (Id == null)
            {
                return Redirect("~/Account/Login");
            }
            var model = new AdsUpdateViewModel
            {
                User=_userService.GetById(Convert.ToInt32(Id)),
                Ads = _adsService.GetById(adsId),
                AdsCategory = _categoryService.GetAll(),
                PetBreed = _petBreedService.GetAll(),
                PetType = _petTypeService.GetAll(),
                City = _cityService.GetAll(),
                Gender = _petGenderSerivce.GetAll()
            };
            return View(model);
        }

        [HttpPost]

        public ActionResult Update(Ads ads)
        {
            
            var Id=   HttpContext.Session.GetInt32("ıd");
            if (Id == null)
            {
                return Redirect("~/Account/Login");
            }

        
            
            
            _adsService.Update(ads);
           
            return RedirectToAction("IlanEkle");
        }

    
        public ActionResult Delete(int AdsId)
        {
            
            var Id=   HttpContext.Session.GetInt32("ıd");
            if (Id == null)
            {
                return Redirect("~/Account/Login");
            }
            
            _adsService.Delete(AdsId);

            return Redirect("UserIlanlariniGetir");
        }
        [HttpGet]
        public ActionResult IlanDetay(int Id)
        {
            var model = new AdsListViewModel
            {
                AdsDetails = _adsService.AdsDetails(Id)
            };

            return View(model);

        }
        [HttpPost]
        public ActionResult IlanDetay(Comment comment,int Id)
        {
          _commentService.Add(comment);

          return View(new AdsListViewModel { AdsDetails = _adsService.AdsDetails(Id) });

        }


        //[HttpGet]
        //public PartialViewResult YorumYap(int Id)
        //{
        //    var model = new AdsListViewModel
        //    {
        //        AdsDetails = _adsService.AdsDetails(Id)

        //    };
        //    return PartialView(model);
        //}

        //[HttpPost]
      
        //public PartialViewResult YorumYap(Comment comment,int Id)
        //{


        //        _commentService.Add(comment);
        
            
            

        //    return PartialView(new AdsListViewModel { AdsDetails = _adsService.AdsDetails(Id) });
        //}


        public ActionResult UserIlanlariniGetir(int UserId)
        {
            var model = new AdsListViewModel
            {
               AdsByUser = _adsService.AdsByUserId(UserId)
            };

            return View(model);
        }

        
  

    }
}

    

