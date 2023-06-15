using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ruisoArtPage.Data;
using ruisoArtPage.Data.Static;
using ruisoArtPage.Models;
using X.PagedList;

namespace ruisoArtPage.Controllers{
    public class ProviderController : Controller{
        private readonly ApplicationDbContext _context;
        public ProviderController(ApplicationDbContext context){
            _context = context;
        }
        //-------------------------------------------------------------- INDEX
        /*public async Task <IActionResult> Index(){
            var all = await _context.Provider.ToListAsync();
            return View(all);
        }*/
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
            var data = _context.Provider.AsQueryable();
            switch (sortOn) {
                case "name":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.name) : data.OrderByDescending(i => i.name);
                    break;
                case "description":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.description) : data.OrderByDescending(i => i.description);
                    break;
                case "phone":
                data = orderBy.Equals("asc") ? data.OrderBy(i => i.phone) : data.OrderByDescending(i => i.phone);
                break;
                case "link":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.link) : data.OrderByDescending(i => i.link);
                    break;
                case "email":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.email) : data.OrderByDescending(i => i.email);
                    break;
                
                default:
                    data = data.OrderBy(i => i.Id);
                    break;
            }

            ViewBag.providers = data.ToPagedList(page.Value, recordsPerPage);
            return View(data);
        }
        //-------------------------------------------------------------- DETAILS
        public IActionResult Details(int id)        {
            var data = _context.Provider.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        //-------------------------------------------------------------- EDIT
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Edit(int id){
            var data = _context.Provider.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public IActionResult Edit(int id, 
        [Bind("Id, name, description, image, phone, link, email, socialRed0, socialRed1, socialRed2, socialRed3, socialRed4, socialRed5, socialRed6, socialRed7, socialRed8, socialRed9, socialRed10, socialRed11, socialRed12, socialRed13, socialRed14, socialRed15, socialRed16, socialRed17, socialRed18, socialRed19")] Provider data){
            if(!ModelState.IsValid){
                return View(data);
            }
            if(id == data.Id){
                _context.Provider.Update(data);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(data);
        }
        //-------------------------------------------------------------- DELETE
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Delete(int id){
            var data = _context.Provider.FirstOrDefault(a => a.Id == id);
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id){
            var data = _context.Provider.FirstOrDefault(a=> a.Id == id);
            if(data == null) return View("NotFound");
            _context.Provider.Remove(data);
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
        public IActionResult Create([Bind("name, description, image, phone, link, email, socialRed0, socialRed1, socialRed2, socialRed3, socialRed4, socialRed5, socialRed6, socialRed7, socialRed8, socialRed9, socialRed10, socialRed11, socialRed12, socialRed13, socialRed14, socialRed15, socialRed16, socialRed17, socialRed18, socialRed19")] Provider data){
            if(!ModelState.IsValid){return View(data);}
            _context.Provider.Add(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}