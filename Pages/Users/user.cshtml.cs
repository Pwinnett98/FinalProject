using FinalProject.models;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Pages;

public class UserModel : PageModel
{
  private readonly ILogger<UserModel> _logger;
  public List<User> Users {get; set;} = default!;

    [BindProperty]
    [Display(Name = "First Name")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string FirstName {get; set;} = string.Empty;

    [BindProperty]
    public string LastName {get; set;} = string.Empty;

    public UserModel(ILogger<UserModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost()
    {
        _logger.LogWarning($"OnPost Called {FirstName} {LastName}");
    }
}
