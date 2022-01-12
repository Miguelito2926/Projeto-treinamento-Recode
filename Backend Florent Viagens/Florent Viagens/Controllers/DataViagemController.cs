using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Florent_Viagens.Models;

namespace Florent_Viagens.Controllers
{
    public class DataViagemController : Controller
    {
        private readonly BancoDados _context;

        public DataViagemController(BancoDados context)
        {
            _context = context;
        }

        // GET: DataViagems
        public async Task<IActionResult> Index()
        {
            var bancoDados = _context.DataViagens.Include(d => d.Destino).Include(d => d.Usuario);
            return View(await bancoDados.ToListAsync());
        }

        // GET: DataViagems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataViagem = await _context.DataViagens
                .Include(d => d.Destino)
                .Include(d => d.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataViagem == null)
            {
                return NotFound();
            }

            return View(dataViagem);
        }

        // GET: DataViagems/Create
        public IActionResult Create()
        {
            ViewData["DestinoId"] = new SelectList(_context.Destinos, "Id", "Descricao");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome");
            return View();
        }

        // POST: DataViagems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,UsuarioId,DestinoId")] DataViagem dataViagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataViagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DestinoId"] = new SelectList(_context.Destinos, "Id", "Descricao", dataViagem.DestinoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", dataViagem.UsuarioId);
            return View(dataViagem);
        }

        // GET: DataViagems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataViagem = await _context.DataViagens.FindAsync(id);
            if (dataViagem == null)
            {
                return NotFound();
            }
            ViewData["DestinoId"] = new SelectList(_context.Destinos, "Id", "Descricao", dataViagem.DestinoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", dataViagem.UsuarioId);
            return View(dataViagem);
        }

        // POST: DataViagems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,UsuarioId,DestinoId")] DataViagem dataViagem)
        {
            if (id != dataViagem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataViagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataViagemExists(dataViagem.Id))
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
            ViewData["DestinoId"] = new SelectList(_context.Destinos, "Id", "Descricao", dataViagem.DestinoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", dataViagem.UsuarioId);
            return View(dataViagem);
        }

        // GET: DataViagems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataViagem = await _context.DataViagens
                .Include(d => d.Destino)
                .Include(d => d.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataViagem == null)
            {
                return NotFound();
            }

            return View(dataViagem);
        }

        // POST: DataViagems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataViagem = await _context.DataViagens.FindAsync(id);
            _context.DataViagens.Remove(dataViagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataViagemExists(int id)
        {
            return _context.DataViagens.Any(e => e.Id == id);
        }
    }
}
