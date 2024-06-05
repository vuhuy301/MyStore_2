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
                // ??ng nh?p thành công, th?c hi?n hành ??ng mong mu?n (ví d?: chuy?n h??ng ??n trang chính)
                return RedirectToPage("/Index");
            }
            else
            {
                // ??ng nh?p th?t b?i, hi?n th? thông báo l?i ho?c chuy?n h??ng ng??i dùng ??n trang ??ng nh?p l?i
                return Page();
            }
        }
    }
}
