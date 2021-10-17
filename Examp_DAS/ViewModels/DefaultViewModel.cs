using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;

namespace Examp_DAS.ViewModels
{
	public class DefaultViewModel : MasterPageViewModel
	{
		public string Title { get; set; }
		public PersonModel Person { get; set; } = new PersonModel { EnrollmentDate = DateTime.UtcNow.Date };

		public DefaultViewModel()
		{
			Title = "Personas";
		}

		public void Process()
        {
			String script = "alert('" + "Bienvenido/a" + " " + Person.Username + " a tu web :) ')";
			Context.ResourceManager.AddStartupScript(script);
		}
    }
}
