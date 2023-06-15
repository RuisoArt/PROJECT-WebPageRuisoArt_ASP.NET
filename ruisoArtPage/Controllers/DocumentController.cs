using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ruisoArtPage.Data;
using ruisoArtPage.Data.Static;
using ruisoArtPage.Models;
using X.PagedList;

namespace ruisoArtPage.Controllers{
    public class DocumentController : Controller{
        private readonly ApplicationDbContext _context;
        public DocumentController(ApplicationDbContext context){
            _context = context;
        }
        // ---------------------------------------------------------------- INDEX
        /*public async Task <IActionResult> Index(){
            var all = await _context.Document.ToListAsync();
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
            var data = _context.Document.AsQueryable();
            switch (sortOn) {
                case "Name":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.Name) : data.OrderByDescending(i => i.Name);
                    break;
                case "Link":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.Link) : data.OrderByDescending(i => i.Link);
                    break;
                default:
                    data = data.OrderBy(i => i.Id);
                    break;
            }

            ViewBag.documents = data.ToPagedList(page.Value, recordsPerPage);
            return View(data);
        }
        //-------------------------------------------------------------- DETAILS
        public IActionResult Details(int id)        {
            var data = _context.Document.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        //-------------------------------------------------------------- EDIT
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Edit(int id){
            var data = _context.Document.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public IActionResult Edit(int id, 
        [Bind("Id, Name, Link")] Document data){
            if(!ModelState.IsValid){
                return View(data);
            }
            if(id == data.Id){
                _context.Document.Update(data);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(data);
        }
        //-------------------------------------------------------------- DELETE
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Delete(int id){
            var data = _context.Document.FirstOrDefault(a => a.Id == id);
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id){
            var data = _context.Document.FirstOrDefault(a=> a.Id == id);
            if(data == null) return View("NotFound");
            _context.Document.Remove(data);
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
        public IActionResult Create([Bind("Name, Link")] Document data){
            if(!ModelState.IsValid){
                return View(data);
            }
            _context.Document.Add(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}