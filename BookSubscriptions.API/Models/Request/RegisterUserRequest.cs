﻿

using System.ComponentModel.DataAnnotations;

namespace BookSubscriptions.Api.Models.Request
{
    public class RegisterUserRequest
    {
        [Required(ErrorMessage = "The {0} field is mandatory")]
        [StringLength(100, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The {0} field is mandatory")]
        [StringLength(100, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The {0} field is mandatory")]
        [EmailAddress(ErrorMessage = "The field {0} is in an invalid format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The {0} field is mandatory")]
        [StringLength(100, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
