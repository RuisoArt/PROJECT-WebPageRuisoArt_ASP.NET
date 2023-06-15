using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ruisoArtPage.Data;
using ruisoArtPage.Data.Static;
using ruisoArtPage.Models;
using X.PagedList;

namespace ruisoArtPage.Controllers{
    public class CommissionController : Controller{
        private readonly ApplicationDbContext _context;
        public CommissionController(ApplicationDbContext context){
            _context = context;
        }
        //---------------------------------------------------------------- INDEX
        /*public async Task <IActionResult> Index(){
            var all = await _context.Commission.ToListAsync();
            return View(all);
        }*/
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult Index(string sortOn, string orderBy, string pSortOn, int? page) {
            int recordsPerPage = 2;
            if (!page.HasValue) {
                page = 1;
                orderBy = string.IsNullOrWhiteSpace(orderBy) || orderBy.Equals("asc") ? "desc" : "asc";
            } if (!string.IsNullOrWhiteSpace(sortOn) && !sortOn.Equals(pSortOn, StringComparison.CurrentCultureIgnoreCase)){
                orderBy = "asc";
            }

            ViewBag.OrderBy = orderBy;
            ViewBag.SortOn = sortOn;
            var data = _context.Commission.AsQueryable();
            switch (sortOn) {
                case "Tittle":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.Tittle) : data.OrderByDescending(i => i.Tittle);
                    break;
                case "description":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.description) : data.OrderByDescending(i => i.description);
                    break;
                case "AproxPrice":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.AproxPrice) : data.OrderByDescending(i => i.AproxPrice);
                    break;
                case "Email":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.Email) : data.OrderByDescending(i => i.Email);
                    break;
                case "PersonName":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.PersonName) : data.OrderByDescending(i => i.PersonName);
                    break;
                case "PersonLastName":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.PersonLastName) : data.OrderByDescending(i => i.PersonLastName);
                    break;
                /*case "TypeId":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.TypeId) : data.OrderByDescending(i => i.TypeId);
                    break;*/
                default:
                    data = data.OrderBy(i => i.Id);
                    break;
            }

            ViewBag.commis = data.ToPagedList(page.Value, recordsPerPage);
            return View(data);
        }
        //-------------------------------------------------------------- DETAILS
        public IActionResult Details(int id)        {
            var data = _context.Commission.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        //-------------------------------------------------------------- EDIT
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Edit(int id){
            var data = _context.Commission.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public IActionResult Edit(int id, 
        [Bind("Id, Tittle, description, AproxPrice, Email, PersonName, PersonLastName, ImageReference, TypeId")] Commission data){
            if(!ModelState.IsValid){
                return View(data);
            }
            if(id == data.Id){
                _context.Commission.Update(data);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(data);
        }
        //-------------------------------------------------------------- DELETE
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Delete(int id){
            var data = _context.Commission.FirstOrDefault(a => a.Id == id);
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id){
            var data = _context.Commission.FirstOrDefault(a=> a.Id == id);
            if(data == null) return View("NotFound");
            _context.Commission.Remove(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //-------------------------------------------------------------- CREATE
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult Create(){
            return View();
        }
        //[Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public IActionResult Create(
            [Bind("Tittle, description, AproxPrice, Email, PersonName, PersonLastName, ImageReference, TypeId")] Commission data){
            if(!ModelState.IsValid){
                return View(data);
            }

            _context.Commission.Add(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}