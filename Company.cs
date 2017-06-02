using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobBoardMVC.Models
{
    public class Company
    {
        (other Company properties...)

		[Display(Name = "Company Type")]
		public string CompanyType { get; set; }

		[Display(Name = "Industry Served")]
		public string IndustryServed { get; set; }

		[Display(Name = "Languages Used")]
		public string LanguagesUsed { get; set; }

		public virtual ICollection<CompanyFile> Files { get; set; }
	}
}
