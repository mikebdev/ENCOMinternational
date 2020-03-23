using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EncomDashboardCore.Models
{

    public class Application
    {

        [Required]
        [Key]
        public int AppID { get; set; }

        [Required]
        [Display(Name = "App Type")] //Service, Application, or Website
        //[DataType(DataType.Text)]
        [StringLength(15, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string AppType { get; set; }

        [Required]
        [Display(Name = "App Name")]
        [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string AppName { get; set; }

        [Required]
        [Display(Name = "URL/Location")] //Website URL or App location
        [StringLength(100, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string AppLocation { get; set; }


        [Required]
        [Display(Name = "App Info")]
        [StringLength(255, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 1)]
        public string AppInfo { get; set; }




        [Display(Name = "Status")]
        public int Status { get; set; }
        //Default is active set to 0.
        //Disabled/inactive is set to 1.

        //[Display(Name = "Enabled/Disabled")]
        //public int Disabled { get; set; }


    }

}



//Application
//COLUMN  TYPE CONSTRAINTS DESCRIPTION
//AppID   INT PK, UNIQUE, NOT NULL Identity column for Websites table
//AppType NVARCHAR(15)    NOT NULL    Service, Application, or Website
//AppName NVARCHAR(50)    NOT NULL    Service, Application, or Website Name
//AppLocation NVARCHAR(100)   NOT NULL    Website URL or App location
//AppInfo NVARCHAR(255)   NOT NULL    Information about Application or Website.
//Status int NOT NULL Default is active set to 0.
//Disabled/inactive is set to 1.
