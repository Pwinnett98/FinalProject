using FinalProject.models;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject.Pages;

public class RecipeModel : PageModel
{
    private readonly RecipeContext _context; 
    private readonly ILogger<IndexModel> _logger;
    public List<Recipe> Recipes {get; set;} = default!;


    public RecipeModel(RecipeContext context,ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Recipes = _context.Recipes.ToList();
    }
}
