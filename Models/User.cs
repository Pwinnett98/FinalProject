
using Microsoft.AspNetCore.SignalR;

namespace FinalProject.models
{
    public class User
    {
        public required string UserId {get; set;}	// Primary Key

        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
    }
}