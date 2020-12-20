using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("User")]
    public class User
    {
        public User() : base()
        {
            Id = Guid.NewGuid();
            DateTime = DateTime.Now;
        }

        // *****
        [Key]
        public Guid Id { get; set; }
        // *****

        // *****
        [MaxLength(50)]
        [DataType(DataType.Text)]
        [Display(ResourceType = typeof(Resources.User),
            Name = nameof(Resources.User.FullName))]
        [Required(ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]
        public string FullName { get; set; }
        // *****

        // *****
        [EmailAddress]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        [Display(ResourceType = typeof(Resources.User),
            Name = nameof(Resources.User.Email))]
        [Required(ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}",
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.CorrectEmail))]
        public string Email { get; set; }
        // *****

        // *****
        [MaxLength(50)]
        [DataType(DataType.Text)]
        [Display(ResourceType = typeof(Resources.User),
            Name = nameof(Resources.User.Username))]
        [Required(ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]
        public string Username { get; set; }
        // *****

        // *****
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(Resources.User),
            Name = nameof(Resources.User.Password))]
        [Required(ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]
        public string Password { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.User),
            Name = nameof(Resources.User.IsAdmin))]
        public bool IsAdmin { get; set; }
        // *****

        // *****
        [DataType(DataType.DateTime)]
        [Display(ResourceType = typeof(Resources.User),
            Name = nameof(Resources.User.DateTime))]
        [Required(ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]
        public DateTime DateTime { get; set; }
        // *****
    }
}
