using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dev_reveste01_backend_2026.Models;

namespace dev_reveste01_backend_2026.Controllers
{
    public class SolicitacaoTrocasController : Controller
    {
        private readonly AppDbContext _context;

        public SolicitacaoTrocasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: SolicitacaoTrocas
        public async Task<IActionResult> Index()
        {
            return View(await _context.SolicitacoesTroca.ToListAsync());
        }

        // GET: SolicitacaoTrocas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitacaoTroca = await _context.SolicitacoesTroca
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitacaoTroca == null)
            {
                return NotFound();
            }

            return View(solicitacaoTroca);
        }

        // GET: SolicitacaoTrocas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SolicitacaoTrocas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsuarioId,PecaId,Titulo,Tamanho,Estado,Rua,Numero,Cidade,EstadoEndereco,Cep,ValorPeca,Frete,Comissao,Total,Status")] SolicitacaoTroca solicitacaoTroca)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitacaoTroca);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitacaoTroca);
        }

        // GET: SolicitacaoTrocas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitacaoTroca = await _context.SolicitacoesTroca.FindAsync(id);
            if (solicitacaoTroca == null)
            {
                return NotFound();
            }
            return View(solicitacaoTroca);
        }

        // POST: SolicitacaoTrocas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UsuarioId,PecaId,Titulo,Tamanho,Estado,Rua,Numero,Cidade,EstadoEndereco,Cep,ValorPeca,Frete,Comissao,Total,Status")] SolicitacaoTroca solicitacaoTroca)
        {
            if (id != solicitacaoTroca.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitacaoTroca);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitacaoTrocaExists(solicitacaoTroca.Id))
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
            return View(solicitacaoTroca);
        }

        // GET: SolicitacaoTrocas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitacaoTroca = await _context.SolicitacoesTroca
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitacaoTroca == null)
            {
                return NotFound();
            }

            return View(solicitacaoTroca);
        }

        // POST: SolicitacaoTrocas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitacaoTroca = await _context.SolicitacoesTroca.FindAsync(id);
            if (solicitacaoTroca != null)
            {
                _context.SolicitacoesTroca.Remove(solicitacaoTroca);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitacaoTrocaExists(int id)
        {
            return _context.SolicitacoesTroca.Any(e => e.Id == id);
        }
    }
}
