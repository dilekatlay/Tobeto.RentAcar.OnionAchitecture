using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Customer : Entity<Guid>
{
    public int UserId { get; set; }


    //public User? Users { get; set; }
    //public IndividualCustomer? IndividualCustomers { get; set; } = null;
    //public CorporateCustomer? CorporateCustomers { get; set; } = null;

}
