using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EncomDashboardCore.Models
{

    public class User
    {
        [Required]
        [Key]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(25, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(25, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string Firstname { get; set; }


        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(25, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Access Level")]
        [StringLength(3, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public int AccessLevel { get; set; }



        [Display(Name = "Status")]
        public int Status { get; set; }
        //Default is active set to 0.
        //Disabled/inactive is set to 1.

        //[Display(Name = "Enabled/Disabled")]
        //public int Disabled { get; set; }
    }

}





//User
//COLUMN  TYPE CONSTRAINTS DESCRIPTION
//UserID  INT PK, UNIQUE, NOT NULL Identity column for User table
//Lastname NVARCHAR(25)    NOT NULL    User Last Name
//Firstname   NVARCHAR(25)    NOT NULL    User First Name
//Email   NVARCHAR(50)    NOT NULL, UNIQUE    User Email, also Username
//Password    NVARCHAR(25)    NOT NULL    User password
//AccessLevel INT NOT NULL    Default is 1:
//1. User
//2. Admin
//3. SuperUser
//Status  INT NOT NULL Default is active set to 0.
//Disabled/inactive is set to 1.
