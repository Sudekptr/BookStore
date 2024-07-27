using Microsoft.AspNetCore.Authorization;
using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

public class BooksController : Controller
{
    private readonly ApplicationDbContext _context;


public BooksController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Books
    public async Task<IActionResult> Index()
    {
        var books = await _context.Books.Include(b => b.Seller).ToListAsync();
        return View(books);
    }

    // GET: Books/Create
    public IActionResult Create()
    {
        var sellers = _context.Sellers.ToList();
        if (sellers != null || !sellers.Any())
        {
            // Sellers tablosunda veri yoksa kullanıcıya bilgi verin
            ModelState.AddModelError(string.Empty, "No sellers available.");
            return View();
        }

        ViewBag.SellerId = new SelectList(_context.Sellers, "Id", "Name");
        return View();
    }

    // POST: Books/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Title,Author,Price,Description,Stock,SellerId")] Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Sellers listesi yeniden alınmalı ve ViewBag ayarlanmalı
        var sellers = _context.Sellers.ToList();
        if (sellers != null || !sellers.Any())
        {
            ModelState.AddModelError(string.Empty, "No sellers available.");
        }
        else
        {
            ViewBag.SellerId = new SelectList(sellers, "Id", "Name", book.SellerId);
        }

        return View(book);
    }

    // GET: Books/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var book = await _context.Books.FindAsync(id);
        if (book == null)
        {
            return NotFound();
        }

        var sellers = await _context.Sellers.ToListAsync();
        if (sellers == null || !sellers.Any())
        {
            ModelState.AddModelError(string.Empty, "No sellers available.");
            // Seller seçim listesi oluşturulmazsa, boş bir SelectList oluşturulabilir
            ViewBag.SellerId = new SelectList(Enumerable.Empty<SelectListItem>(), "Value", "Text");
        }

        else
        {
            ViewBag.SellerId = new SelectList(sellers, "Id", "Name", book.SellerId);
        }

        return View(book);
    }

    // POST: Books/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Author,Price,Description,Stock,SellerId")] Book book)
    {
        if (id != book.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(book);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(book.Id))
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

        var sellers = _context.Sellers.ToList();
        if (sellers == null || !sellers.Any())
        {
            ModelState.AddModelError(string.Empty, "No sellers available.");
        }
        else
        {
            ViewBag.SellerId = new SelectList(sellers, "Id", "Name", book.SellerId);
        }

        return View(book);
    }

    // GET: Books/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var book = await _context.Books
            .FirstOrDefaultAsync(m => m.Id == id);
        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }

    // POST: Books/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
        {
            return NotFound();
        }

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool BookExists(int id)
    {
        return _context.Books.Any(e => e.Id == id);
    }

    // GET: Books/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var book = await _context.Books
            .Include(b => b.Seller)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }


}