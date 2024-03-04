using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Customer : Entity<Guid>
{
    //public Customer(int userId)
    //{
    //    UserId = userId;
    //}
    public Customer()
    {

    }

    //public int UserId { get; set; }
    public User? User { get; set; } = null;
    public Guid CustomerId { get; set; }//sonradan eklenen//
    public IndividualCustomer? IndividualCustomers { get; set; } = null;
    public CorporateCustomer? CorporateCustomers { get; set; } = null;

}

