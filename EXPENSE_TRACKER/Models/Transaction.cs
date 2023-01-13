
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EXPENSE_TRACKER.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //categoryid 
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public int Amount { get; set; }
        public string? Note { get; set; }

        public DateTime date { get; set; } = DateTime.Now;
        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get
            {
                return Category == null ? "" : Category.Icon + " " + Category.Title;
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.Type == "Expense") ? "- " : "+ ") + Amount.ToString("C0");
            }
        }

    }
}
