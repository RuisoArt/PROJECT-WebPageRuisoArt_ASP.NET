using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ruisoArtPage.Data;
using ruisoArtPage.Data;
using ruisoArtPage.Data.Static;
using ruisoArtPage.Models;
using X.PagedList;

namespace ruisoArtPage.Controllers{
    public class BannerController : Controller{
        private readonly ApplicationDbContext _context;
        public BannerController(ApplicationDbContext context){
            _context = context;
        }
        //-------------------------------------------------------------- INDEX
        /*public async Task <IActionResult> Index(){
            var allBanners = await _context.Banner.ToListAsync();
            return View(allBanners);
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
            var data = _context.Banner.AsQueryable();
            switch (sortOn) {
                case "Name":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.Name) : data.OrderByDescending(i => i.Name);
                    break;
                case "Description":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.Description) : data.OrderByDescending(i => i.Description);
                    break;
                case "size":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.size) : data.OrderByDescending(i => i.size);
                    break;
                case "link":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.link) : data.OrderByDescending(i => i.link);
                    break;
                case "ProviderId":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.ProviderId) : data.OrderByDescending(i => i.ProviderId);
                    break;
                default:
                    data = data.OrderBy(i => i.Id);
                    break;
            }

            ViewBag.banners = data.ToPagedList(page.Value, recordsPerPage);
            return View(data);
        }
        //-------------------------------------------------------------- DETAILS
        public IActionResult Details(int id)        {
            var data = _context.Banner.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        //-------------------------------------------------------------- EDIT
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Edit(int id){
            var data = _context.Banner.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public IActionResult Edit(int id, 
        [Bind("Id, Name, Description, size, image, link, ProviderId")] Banner data){
            if(!ModelState.IsValid){
                return View(data);
            }
            if(id == data.Id){
                _context.Banner.Update(data);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(data);
        }
        //-------------------------------------------------------------- DELETE
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Delete(int id){
            var data = _context.Banner.FirstOrDefault(a => a.Id == id);
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id){
            var data = _context.Banner.FirstOrDefault(a=> a.Id == id);
            if(data == null) return View("NotFound");
            _context.Banner.Remove(data);
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
            [Bind("Name, Description, size, image, link, ProviderId")] Banner data){
            if(!ModelState.IsValid){
                return View(data);
            }

            _context.Banner.Add(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
