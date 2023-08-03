using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Models.ViewModels;
using Bulky.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;

namespace BulkyWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CompanyController(ICompanyRepository companyRepo, ICategoryRepository categoryRepo)
        {
            _companyRepo = companyRepo;
            _categoryRepo = categoryRepo;
        }
        public IActionResult Index()
        {
            List<Company> objCompanyList = _companyRepo.GetAll().ToList();
            return View(objCompanyList);
        }

        public IActionResult Upsert(int? id)
        {
            if (id == null || id == 0)
            {
                //create
                return View(new Company());
            }
            else
            {
                //update
                Company companyObj = _companyRepo.Get(u => u.Id == id);
                return View(companyObj);
            }

        }
        [HttpPost]
        public IActionResult Upsert(Company CompanyObj)
        {
            if (ModelState.IsValid)
            {
                if (CompanyObj.Id == 0)
                {
                    _companyRepo.Add(CompanyObj);
                }
                else
                {
                    _companyRepo.Update(CompanyObj);
                }

                _companyRepo.Save();
                TempData["success"] = "Company created successfully";
                return RedirectToAction("Index", "Company");
            }
            else
            {
                
                return View(CompanyObj);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Company? companyFromDb = _companyRepo.Get(u => u.Id == id);

            if (companyFromDb == null)
            {
                return NotFound();
            }
            return View(companyFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Company? obj = _companyRepo.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _companyRepo.Remove(obj);
            _companyRepo.Save();
            TempData["success"] = "Company deleted successfully";
            return RedirectToAction("Index");
        }

        #region APICALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> objCompanyList = _companyRepo.GetAll().ToList();
            return Json(new { data = objCompanyList });
        }
        #endregion
    }
}
