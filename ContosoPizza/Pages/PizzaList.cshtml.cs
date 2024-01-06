using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoPizza.Pages;

public class PizzaListModel(PizzaService service) : PageModel
{
    readonly PizzaService _service = service;

    public IList<Pizza> PizzaList { get; set; } = default!;

    public void OnGet()
    {
        PizzaList = _service.GetPizzas();
    }
}
