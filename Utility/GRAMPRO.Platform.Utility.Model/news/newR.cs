using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRAMPRO.Platform.Utility.Model.news
{
    public class newR
    {
         public int Job_Id { get; set; }
         public int Category_Id { get; set; }
         public string JobName{get;set;}
          public int Openings { get; set; }
          public string Description { get; set; }
          public int Experience { get; set; }
          public string Skills { get; set; }
          public DateTime LastDateForApplying { get; set; }
          public string ContactNumber { get; set; }
          public string SalaryPackage { get; set; }
          public string JobType { get; set; }

    } //Job_Id,,,Openings,Description,Experience,Skills,LastDateForApplying,ContactNumber,SalaryPackage,

}




