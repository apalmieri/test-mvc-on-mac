using System;

namespace TestMVConMac
{
	public class HomeModel
	{
		public int Id { get; private set; }
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string Address1 { get; private set; }
		public string Address2 { get; private set; }
		public string City { get; private set; }
		public string PostalCode { get; private set; }
		public string Province { get; private set; }
		public string Country { get; private set; }

		public HomeModel(int id, string firstName, string lastName)
		{
			this.Id = id;
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public HomeModel(int id, string firstName, string lastName, string address1, string address2, string city, string postalCode, string province, string country) : this(id, firstName, lastName)
		{
			this.Address1 = address1;
			this.Address2 = address2;
			this.City = city;
			this.PostalCode = postalCode;
			this.Province = province;
			this.Country = country;
		}
	}
}
