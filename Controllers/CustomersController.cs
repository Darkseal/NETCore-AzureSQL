using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCore_AzureSQL.Data;
using NETCore_AzureSQL.Models;

namespace NETCore_AzureSQL.Controllers
{
    public class CustomersController : Controller
    {
        private readonly MyDbContext _context;

        public CustomersController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerID == id);
        }


        // GET: Customers/Create
        public IActionResult Create()
        {
            throw new NotImplementedException();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID,FirstName,LastName")] Customer customer)
        {
            throw new NotImplementedException();
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            throw new NotImplementedException();
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerID,FirstName,LastName")] Customer customer)
        {
            throw new NotImplementedException();
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            throw new NotImplementedException();
        }
    }
}