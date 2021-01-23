using System;
using System.Linq;
using System.Threading.Tasks;
using Ödev.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ÖdevUI.ViewComponenet
{
  
    public class PetBreedListViewComponent:ViewComponent
    {
        private readonly IPetBreedService _petBreedService;
        private readonly ICategoryService _categoryService;
        private readonly IPetTypeService _petTypeService;
        public PetBreedListViewComponent(IPetBreedService petBreedService, ICategoryService categoryService,IPetTypeService petTypeService)
        {
            _petBreedService = petBreedService;
            _categoryService = categoryService;
            _petTypeService=petTypeService;
        }

        public ViewViewComponentResult Invoke(int petTypeId,int categoryId)
        {
            
            var model = new PetBreedListViewModel
            {
                 Categories = _categoryService.GetByCategory(categoryId),
                PetBreeds = _petBreedService.GetByCategory(petTypeId),
               petTypes=_petTypeService.GetByCategory(petTypeId)
               
            };

            return View(model);
        }
    }
}
