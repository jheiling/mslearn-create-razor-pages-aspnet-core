using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoPizza.Pages;

public class IndexModel(ILogger<IndexModel> logger) : PageModel
{
    readonly ILogger<IndexModel> _logger = logger;

    public void OnGet()
    {

    }
}