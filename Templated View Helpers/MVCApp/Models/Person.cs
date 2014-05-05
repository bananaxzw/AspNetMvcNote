using System;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;

namespace MVCApp.Models
{

    [DisplayColumn("1412421")]
    public partial class Person
    {

        [HiddenInput(DisplayValue = false)]
        public int PersonId { get; set; }
        [DisplayName("姓")]
        
        public string FirstName { get; set; }
        [ReadOnly(true)]
        [ScaffoldColumn(false)]
        public string LastName { get; set; }

 
        [DisplayFormat(ConvertEmptyStringToNull=true,ApplyFormatInEditMode = true,DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayFormat(NullDisplayText="邮件为空")]
        public string Email { get; set; }
        public Address HomeAddress { get; set; }

        [AdditionalMetadata("RenderList", "true")]
        public bool IsApproved { get; set; }

        [UIHint("Enum")]
        public Role Role { get; set; }
        public string ss { get; set; }
    }

    public class Address
    {

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
    }

    public enum Role
    {
        Admin,
        User,
        Guest
    }
}