using System.ComponentModel.DataAnnotations;

namespace ProductApp.Web.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal? Price { get; set; }
        //3-Currently you can enter a negative number for stock. Update the code to restrict it to only 0 or positive numbers. A validation error should be displayed if a negative number is entered.
        [Required]
        //Added code here
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value greater than or equal to zero")]
        public int? Stock { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
