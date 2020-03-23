using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EncomDashboardCore.Data;
using EncomDashboardCore.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EncomDashboardCore.ViewModels
{

    public class ApplicationStatusVM
    {
        public int AppID { get; set; }
        public string AppType { get; set; }
        public string AppName { get; set; }
        public string AppLocation { get; set; }
        public string AppInfo { get; set; }
        public int Status { get; set; }
        //Default is active set to 0.
        //Disabled/inactive is set to 1.

        public string ApplicationStatusResult { get; set; } //Can put Online or Offline even put HTML for Green or Red circle....
    }

}
