using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Windows;

namespace MyWebApp.Pages;

public class IndexModel : PageModel
{
    public int le = 9;
    private readonly ILogger<IndexModel> _logger;



    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
