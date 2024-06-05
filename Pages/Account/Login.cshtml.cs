using DemoRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoRazorPage.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly DemoRazorPage.Models.MyStoreContext _context;

        public LoginModel(MyStoreContext dbContext)
        {
            _context = dbContext;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string username, string password)
        {
            var user = await _context.Staffs.FirstOrDefaultAsync(u => u.Name == username && u.Password == password);
            if (user != null)
            {
                // ??ng nh?p th�nh c�ng, th?c hi?n h�nh ??ng mong mu?n (v� d?: chuy?n h??ng ??n trang ch�nh)
                return RedirectToPage("/Index");
            }
            else
            {
                // ??ng nh?p th?t b?i, hi?n th? th�ng b�o l?i ho?c chuy?n h??ng ng??i d�ng ??n trang ??ng nh?p l?i
                return Page();
            }
        }
    }
}
