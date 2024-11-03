using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add routing
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure routing
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapGet("/Page", async context =>
    {
        await context.Response.SendFileAsync("Page.cshtml");
    });
});

app.Run();

namespace webProject.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int UserInput { get; set; }

        public string Message { get; set; }

        private readonly Random _random;

        public IndexModel()
        {
            _random = new Random();
        }

        public void OnGet()
        {
            ViewData["RandomNumber"] = _random.Next(1, 11);
        }

        public IActionResult OnPost()
        {
            int randomNumber = (int)ViewData["RandomNumber"]!;

            if (UserInput == randomNumber)
            {
                Message = " Congratulations! You guessed the correct number.";
            }
            else
            {
                Message = $"Sorry, the correct number was {randomNumber}.";
            }

            return Page();
        }
    }
}
