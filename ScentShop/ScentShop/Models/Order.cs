using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ScentShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "Please enter a valid first name. The field must consist of letters only.")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "Please enter a valid last name. The field must consist of letters only.")]
        [Display(Name ="Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [Required]
        [Display(Name = "Address Line 2")]
        [StringLength(100)]
        public string AddressLine2 { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]+", ErrorMessage = "Please enter a valid zip-code. The field must consist of 4-10 digits.")]
        [Display(Name = "Zip Code")]
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "Please enter a valid city. The field must consist of letters only.")]
        [Display(Name = "City")]
        [StringLength(20)]
        public string City { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "Please enter a valid state. The field must consist of letters only.")]
        [Display(Name = "State")]
        [StringLength(15)]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "Please enter a valid country. The field must consist of letters only.")]
        [Display(Name = "Contry")]
        [StringLength(20)]
        public string Country { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]+", ErrorMessage = "Please enter a valid phone number. The field must consist of numbers only.")]
        [Display(Name = "Phone Number")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(25)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
