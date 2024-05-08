
using Microsoft.AspNetCore.SignalR;

namespace FinalProject.models
{
    public class Recipe
    {
        public required string RecipeId {get; set;}	// Primary Key

        public string Title {get; set;} = string.Empty;
        public string DateAdded {get; set;} = string.Empty;
        public string TimeToCook {get; set;} = string.Empty;
        public string Description {get; set;} = string.Empty;
        public string Author {get; set;} = string.Empty;
    }
public class User
    {
        public required string UserId {get; set;}	// Primary Key

        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
    }
}

