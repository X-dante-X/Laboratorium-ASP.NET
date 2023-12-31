﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entities;

namespace Laboratorium_3.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly AppDbContext _context;

        public OrganizationController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Organization
        public async Task<IActionResult> Index()
        {
              return _context.Organizations != null ? 
                          View(await _context.Organizations.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Organizations'  is null.");
        }

        // GET: Organization/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Organizations == null)
            {
                return NotFound();
            }

            var organizationEntity = await _context.Organizations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organizationEntity == null)
            {
                return NotFound();
            }

            return View(organizationEntity);
        }

        // GET: Organization/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Organization/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] OrganizationEntity organizationEntity)
        {
            _context.Add(organizationEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create", "Contact");
        }

        // GET: Organization/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Organizations == null)
            {
                return NotFound();
            }

            var organizationEntity = await _context.Organizations.FindAsync(id);
            if (organizationEntity == null)
            {
                return NotFound();
            }
            return View(organizationEntity);
        }

        // POST: Organization/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] OrganizationEntity organizationEntity)
        {
            if (id != organizationEntity.Id)
            {
                return NotFound();
            }


                try
                {
                    _context.Update(organizationEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrganizationEntityExists(organizationEntity.Id))
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

        // GET: Organization/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Organizations == null)
            {
                return NotFound();
            }

            var organizationEntity = await _context.Organizations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organizationEntity == null)
            {
                return NotFound();
            }

            return View(organizationEntity);
        }

        // POST: Organization/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Organizations == null)
            {
                return Problem("Entity set 'AppDbContext.Organizations'  is null.");
            }
            var organizationEntity = await _context.Organizations.FindAsync(id);
            if (organizationEntity != null)
            {
                _context.Organizations.Remove(organizationEntity);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrganizationEntityExists(int id)
        {
          return (_context.Organizations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
