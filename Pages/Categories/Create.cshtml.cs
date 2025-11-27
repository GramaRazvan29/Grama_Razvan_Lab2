using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Grama_Razvan_Lab2.Data;
using Grama_Razvan_Lab2.Models;

namespace Grama_Razvan_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Grama_Razvan_Lab2.Data.Grama_Razvan_Lab2Context _context;

        public CreateModel(Grama_Razvan_Lab2.Data.Grama_Razvan_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
