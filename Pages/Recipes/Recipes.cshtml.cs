using FinalProject.models;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProject.Pages;

public class RecipeModel : PageModel
{
    private readonly RecipeContext _context; 
    private readonly ILogger<IndexModel> _logger;
    public List<Recipe> Recipes {get; set;} = default!;
    public Recipe FindRecipe {get; set;} = default!;
    public string RecipeId {get; set;} = string.Empty;
    public SelectList RecipeDropDown {get; set;} = default!;
    [BindProperty]
    public Recipe Recipe {get; set;} = default!;



    public RecipeModel(RecipeContext context,ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Recipes = _context.Recipes.ToList();
        FindRecipe = _context.Recipes.Find(RecipeId)!;
        RecipeDropDown = new SelectList(Recipes, "RecipeId", "Title");
    }
    public IActionResult OnPost()
{
    if (!ModelState.IsValid)
    {
        return Page();
    }
    _context.Recipes.Add(Recipe);
    _context.SaveChanges();
    return RedirectToPage("./Index");
}

}
