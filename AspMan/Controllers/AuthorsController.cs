using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspMan.Core;
using AspMan.Infrastructure;
using AspMan.Core.Iterfaces;

namespace AspMan.Web.Controllers
{
    public class AuthorsController : Controller
    {
        //private readonly Infrastructure.AppContext _context;
        private IAuthorRepository authorRepository;
        public AuthorsController()
        {
            this.authorRepository = new AuthorRepository(new AppContext());
        }
        //public AuthorsController(IAuthorRepository authorRepository)
        //{
        //    this.authorRepository = authorRepository;
        //}
        // GET: Authors
        public async Task<IActionResult> Index()
        { 
            //return View(await _context.Authors.ToListAsync());
            return View(await authorRepository.GetAsync());
        }

        // GET: Authors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var author = await _context.Authors
            //    .FirstOrDefaultAsync(m => m.AuthorId == id);
            var author = await authorRepository.FindByIdAsync(id.ToString());
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // GET: Authors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Authors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuthorId,Name,Rating")] Author author)
        {
            if (ModelState.IsValid)
            {
                authorRepository.AddAsync(author);
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        // GET: Authors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var author = authorRepository.FindByIdAsync(id.ToString());
            //var author = await _context.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        // POST: Authors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuthorId,Name,Rating")] Author author)
        {
            if (id != author.AuthorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    authorRepository.Edit(author);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorExists(author.AuthorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        // GET: Authors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var author = await _context.Authors
            //    .FirstOrDefaultAsync(m => m.AuthorId == id);

            var author = await authorRepository.FindByIdAsync(id.ToString());
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // POST: Authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            authorRepository.Remove(id.ToString());
            return RedirectToAction(nameof(Index));
        }

        private bool AuthorExists(int id)
        {
            authorRepository.FindById(id.ToString());
            return false;
            //return _context.Authors.Any(e => e.AuthorId == id);
        }
    }
}
