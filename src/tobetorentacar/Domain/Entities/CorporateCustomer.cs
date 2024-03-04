using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class CorporateCustomer : Entity<Guid>
{
    public Guid CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public Customer Customer { get; set; }

    public CorporateCustomer() { }

    public CorporateCustomer(string companyName, string taxNo, Customer? customer, Guid id)
    {
        CompanyName = companyName;
        TaxNo = taxNo;
        Customer = customer;
        CustomerId = id;
    }
}
