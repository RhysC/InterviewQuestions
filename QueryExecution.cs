using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CandidateExercises.Core;

namespace CandidateExercises.LINQ
{
	class CustomerMailer
	{
		private readonly IEmailer _emailer = null; // Assume assigned

		public void MailCustomers()
		{
			var customers = GetAllCustomers();
			if (customers.Count() > 0)
			{
				SendEmail(customers);
			}
		}

		private void SendEmail(IEnumerable<Customer> customers)
		{
			foreach (var customer in customers)
			{
				_emailer.SendEmail(customer.EmailAddress, "Buy my stuff!");
			}
		}

		private IEnumerable<Customer> GetAllCustomers()
		{
			return from c in GetCustomersFromDatabase()
			       select new Customer();
		}

		private IEnumerable<DbCustomer> GetCustomersFromDatabase()
		{
			// Assume implemented using a data reader approach
			return null;
		}
	}
}