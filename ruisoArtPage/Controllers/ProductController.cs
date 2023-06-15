using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ruisoArtPage.Data;
using ruisoArtPage.Data.Static;
using ruisoArtPage.Models;
using X.PagedList;

namespace ruisoArtPage.Controllers{
    public class ProductController : Controller{
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context){
            _context = context;
        }
        //-------------------------------------------------------------- INDEX
        /*public async Task <IActionResult> Index(){
            var all = await _context.Product.ToListAsync();
            return View(all);
        }*/
        public IActionResult Index(string sortOn, string orderBy, string pSortOn, int? page){
            int recordsPerPage = 2;
            if (!page.HasValue) {
                page = 1;
                orderBy = string.IsNullOrWhiteSpace(orderBy) || orderBy.Equals("asc") ? "desc" : "asc";
            } if (!string.IsNullOrWhiteSpace(sortOn) && !sortOn.Equals(pSortOn, StringComparison.CurrentCultureIgnoreCase)){
                orderBy = "asc";
            }

            ViewBag.OrderBy = orderBy;
            ViewBag.SortOn = sortOn;
            var data = _context.Product.AsQueryable();
            switch (sortOn) {
                // name, description, image, price, tax, quantity, shoppingWay
                case "name":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.name) : data.OrderByDescending(i => i.name);
                    break;
                case "description":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.description) : data.OrderByDescending(i => i.description);
                    break;
                case "price":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.price) : data.OrderByDescending(i => i.price);
                    break;
                case "tax":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.tax) : data.OrderByDescending(i => i.tax);
                    break;
                case "quantity":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.quantity) : data.OrderByDescending(i => i.quantity);
                    break;
                case "shoppingWay":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.shoppingWay) : data.OrderByDescending(i => i.shoppingWay);
                    break;
                // creationDate, externalLink, nftLink, color, sizeCup, modelClothes, sizeClothes, sizeNotepad, season, 
                // status, sizePrint, sizePaper, formatImage, sizeBookMarker, rolDice, sizeDice, TypeId
                case "creationDate":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.creationDate) : data.OrderByDescending(i => i.creationDate);
                    break;
                case "externalLink":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.externalLink) : data.OrderByDescending(i => i.externalLink);
                    break;
                case "nftLink":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.nftLink) : data.OrderByDescending(i => i.nftLink);
                    break;
                case "color":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.color) : data.OrderByDescending(i => i.color);
                    break;
                case "sizeCup":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.sizeCup) : data.OrderByDescending(i => i.sizeCup);
                    break;
                case "modelClothes":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.modelClothes) : data.OrderByDescending(i => i.modelClothes);
                    break;
                case "sizeClothes":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.sizeClothes) : data.OrderByDescending(i => i.sizeClothes);
                    break;
                case "sizeNotepad":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.sizeNotepad) : data.OrderByDescending(i => i.sizeNotepad);
                    break;
                case "season":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.season) : data.OrderByDescending(i => i.season);
                    break;
                case "status":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.status) : data.OrderByDescending(i => i.status);
                    break;
                case "sizePrint":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.sizePrint) : data.OrderByDescending(i => i.sizePrint);
                    break;
                case "sizePaper":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.sizePaper) : data.OrderByDescending(i => i.sizePaper);
                    break;
                case "formatImage":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.formatImage) : data.OrderByDescending(i => i.formatImage);
                    break;
                case "sizeBookMarker":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.sizeBookMarker) : data.OrderByDescending(i => i.sizeBookMarker);
                    break;
                case "rolDice":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.rolDice) : data.OrderByDescending(i => i.rolDice);
                    break;
                case "sizeDice":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.sizeDice) : data.OrderByDescending(i => i.sizeDice);
                    break;
                /*case "TypeId":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.TypeId) : data.OrderByDescending(i => i.TypeId);
                    break;*/
                case "ProviderId":
                    data = orderBy.Equals("asc") ? data.OrderBy(i => i.ProviderId) : data.OrderByDescending(i => i.ProviderId);
                    break;
                default:
                    data = data.OrderBy(i => i.Id);
                    break;
            }

            ViewBag.products = data.ToPagedList(page.Value, recordsPerPage);
            return View(data);
        }
        //-------------------------------------------------------------- DETAILS 
        public IActionResult Details(int id)        {
            var data = _context.Product.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        //-------------------------------------------------------------- EDIT
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Edit(int id){
            var data = _context.Product.FirstOrDefault(a => a.Id == id);
            if (data == null){
                return View("NotFound");
            }
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public IActionResult Edit(int id, 
        [Bind("Id, name, description, image, price, tax, quantity, shoppingWay, creationDate, externalLink, nftLink, color, sizeCup, modelClothes, sizeClothes, sizeNotepad, season, status, sizePrint, sizePaper, formatImage, sizeBookMarker, rolDice, sizeDice, ProviderId")] Product data){
            if(!ModelState.IsValid){
                return View(data);
            }
            if(id == data.Id){
                _context.Product.Update(data);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(data);
        }
        //-------------------------------------------------------------- DELETE
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Delete(int id){
            var data = _context.Product.FirstOrDefault(a => a.Id == id);
            return View(data);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id){
            var data = _context.Product.FirstOrDefault(a=> a.Id == id);
            if(data == null) return View("NotFound");
            _context.Product.Remove(data);
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
        public IActionResult Create([Bind("name, description, image, price, tax, quantity, shoppingWay, creationDate, externalLink, nftLink, color, sizeCup, modelClothes, sizeClothes, sizeNotepad, season, status, sizePrint, sizePaper, formatImage, sizeBookMarker, rolDice, sizeDice, ProviderId")] Product data){
            if(!ModelState.IsValid){
                return View(data);
            }
            _context.Product.Add(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    
    
        //--------------------------------------------------------------
        public Product GetProductById(int id){
            
            return _context.Product
                .Include(dc => dc.DocProducts)
                .ThenInclude(d => d.Document)
                .Include(cp => cp.CategoryProducts)
                .ThenInclude(c => c.Category)
                .Include(po => po.Provider)
                .FirstOrDefault(a => a.Id == id);
        }
    }
}