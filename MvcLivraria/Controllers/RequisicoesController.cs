using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcLivraria.Data;
using MvcLivraria.Models;

namespace MvcLivraria.Controllers
{
    public class RequisicoesController : Controller
    {
        private readonly MvcLivrariaContext _context;

        public RequisicoesController(MvcLivrariaContext context)
        {
            _context = context;
        }

        // GET: Requisicaos
        public async Task<IActionResult> Index()
        {
            var mvcLivrariaContext = _context.Requisicao.Include(r => r.Livro).Include(r => r.Localidade);
            return View(await mvcLivrariaContext.ToListAsync());
        }

        // GET: Requisicaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisicao = await _context.Requisicao
                .Include(r => r.Livro)
                .Include(r => r.Localidade)
                .FirstOrDefaultAsync(m => m.RequisicaoId == id);
            if (requisicao == null)
            {
                return NotFound();
            }

            return View(requisicao);
        }

        // GET: Requisicaos/Create
        public IActionResult Create()
        {
            ViewData["LivroId"] = new SelectList(_context.Livro, "LivroId", "LivroId");
            ViewData["LocalidadeId"] = new SelectList(_context.Localidade, "LocalidadeId", "LocalidadeId");
            return View();
        }

        // POST: Requisicaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequisicaoId,DataRequisicao,DataDevolucao,LivroId,LocalidadeId")] Requisicao requisicao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requisicao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LivroId"] = new SelectList(_context.Livro, "LivroId", "LivroId", requisicao.LivroId);
            ViewData["LocalidadeId"] = new SelectList(_context.Localidade, "LocalidadeId", "LocalidadeId", requisicao.LocalidadeId);
            return View(requisicao);
        }

        // GET: Requisicaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisicao = await _context.Requisicao.FindAsync(id);
            if (requisicao == null)
            {
                return NotFound();
            }
            ViewData["LivroId"] = new SelectList(_context.Livro, "LivroId", "LivroId", requisicao.LivroId);
            ViewData["LocalidadeId"] = new SelectList(_context.Localidade, "LocalidadeId", "LocalidadeId", requisicao.LocalidadeId);
            return View(requisicao);
        }

        // POST: Requisicaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequisicaoId,DataRequisicao,DataDevolucao,LivroId,LocalidadeId")] Requisicao requisicao)
        {
            if (id != requisicao.RequisicaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requisicao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequisicaoExists(requisicao.RequisicaoId))
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
            ViewData["LivroId"] = new SelectList(_context.Livro, "LivroId", "LivroId", requisicao.LivroId);
            ViewData["LocalidadeId"] = new SelectList(_context.Localidade, "LocalidadeId", "LocalidadeId", requisicao.LocalidadeId);
            return View(requisicao);
        }

        // GET: Requisicaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisicao = await _context.Requisicao
                .Include(r => r.Livro)
                .Include(r => r.Localidade)
                .FirstOrDefaultAsync(m => m.RequisicaoId == id);
            if (requisicao == null)
            {
                return NotFound();
            }

            return View(requisicao);
        }

        // POST: Requisicaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requisicao = await _context.Requisicao.FindAsync(id);
            _context.Requisicao.Remove(requisicao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequisicaoExists(int id)
        {
            return _context.Requisicao.Any(e => e.RequisicaoId == id);
        }
    }
}
