using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Examp_DAS.ViewModels
{
    public class PersonModel
    {
		[Required]
		public string Username { get; set; }
		[Required]
		public DateTime EnrollmentDate { get; set; }
		[Required]
		public string Gender { get; set; }
		public string About { get; set; }
	}
}
