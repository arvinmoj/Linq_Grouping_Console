using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("GetName")]
    public class GetName
    {
        public GetName() : base()
        {
            Id = Guid.NewGuid();
        }

        // *****
        [Key]
        public Guid Id { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Code))]
        public string Code { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Name))]
        public string Name { get; set; }
        // *****
    }
}
