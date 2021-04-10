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

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name ="Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Address Line 1")]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Address Line 2")]
        [StringLength(100)]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage ="Please enter your zip code")]
        [Display(Name = "Zip Code")]
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        [Display(Name = "City")]
        [StringLength(20)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state")]
        [Display(Name = "State")]
        [StringLength(15)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        [Display(Name = "Contry")]
        [StringLength(20)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [Display(Name = "Phone Number")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email")]
        [StringLength(25)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
