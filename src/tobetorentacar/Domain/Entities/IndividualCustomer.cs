using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class IndividualCustomer : Entity<Guid>
{
    public Guid CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
    public Customer? Customer { get; set; }

    public IndividualCustomer() { }
    public IndividualCustomer(string firstName, string lastName, string nationalIdentity, Customer? customer, Guid customerid)
    {
        CustomerId = customerid;
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
        Customer = customer;
    }
}
