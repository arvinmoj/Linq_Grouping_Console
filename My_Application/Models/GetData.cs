using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("GetData")]
    public class GetData
    {
        public GetData() : base()
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

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Date))]
        public string Date { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.YearSeason))]
        public string YearSeason { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.ContractNumber))]
        public int? ContractNumber { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.ContractCount))]
        public int? ContractCount { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.NoContractCount))]
        public int? NoContractCount { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.InvoiceNumber))]
        public int? InvoiceNumber { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Count))]
        public int? Count { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.PerSale))]
        public double? PerSale { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.NetSales))]
        public double? NetSales { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Discount))]
        public double? Discount { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.SalesTax))]
        public double? SalesTax { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.ReturnedCount))]
        public int? ReturnedCount { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.RefundAmount))]
        public double? RefundAmount { get; set; }
        // *****

        // *****
        //[MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.ReceivedMoney))]
        public double? ReceivedMoney { get; set; }
        // *****
    }
}