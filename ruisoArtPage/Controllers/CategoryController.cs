using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ruisoArtPage.Data;
using ruisoArtPage.Data.Static;
using ruisoArtPage.Models;

namespace ruisoArtPage.Controllers{
    public class CategoryController : Controller{
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context){
            _context = context;
        }
        public async Task <IActionResult> Index(){
            var allCategories = await _context.Category.ToListAsync();
            return View(allCategories);
        }
        //-------------------------------------------------------------- DETAILS
        public IActionResult Details(int id)        {
            var data = _context.Category.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        //-------------------------------------------------------------- EDIT
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Edit(int id){
            var data = _context.Category.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public IActionResult Edit(int id, 
        [Bind("Id, Name")] Category data){
            if(!ModelState.IsValid){
                return View(data);
            }
            if(id == data.Id){
                _context.Category.Update(data);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(data);
        }
        //-------------------------------------------------------------- DELETE
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Delete(int id){
            var data = _context.Category.FirstOrDefault(a => a.Id == id);
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id){
            var data = _context.Category.FirstOrDefault(a=> a.Id == id);
            if(data == null) return View("NotFound");
            _context.Category.Remove(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //-------------------------------------------------------------- CREATE
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Create(){
            return View();
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public IActionResult Create(
            [Bind("Name")] Category data){
            if(!ModelState.IsValid){
                return View(data);
            }

            _context.Category.Add(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}