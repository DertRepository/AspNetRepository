using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Pls input name...")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Pls input email...")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Pls input phone number...")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Pls input attend or not?")]
        public bool? WillAttend { get; set; }
    }
}