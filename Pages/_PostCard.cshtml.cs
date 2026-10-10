using Configuration_Options.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroBlog.Pages
{   // This page model is used to display a list of posts/articles in a card format on the index page.
    public class _PostCardModel : PageModel
    {
        public List<Configuration_Options.Models.Post> Posts { get; set; } = new List<Configuration_Options.Models.Post>();

        public void OnGet()
        {
            
        }
    }
}
