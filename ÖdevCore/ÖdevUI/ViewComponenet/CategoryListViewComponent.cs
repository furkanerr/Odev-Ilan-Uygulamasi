
using System;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using ÖdevUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ÖdevUI.ViewComponenet
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IPetTypeService _petTypeService;

        public CategoryListViewComponent(ICategoryService categoryService, IPetTypeService petTypeService)
        {
            _categoryService = categoryService;
            _petTypeService = petTypeService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel()
            {
                PetTypes=_petTypeService.GetAll(),
                Categories=_categoryService.GetAll(),
                CurrentCategory = Convert.ToInt32( HttpContext.Request.Query["kategoriler"])
            };

            return View(model);
        }


    }
}