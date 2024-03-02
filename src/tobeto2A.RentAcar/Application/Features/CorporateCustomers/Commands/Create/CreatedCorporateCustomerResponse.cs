using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CorporateCustomers.Commands.Create;
public class CreatedCorporateCustomerResponse
{
    public Guid Id { get; set; }
    public Guid CustomersId { get; set; }
    public string CompanyName { get; set; }
    public int TaxNo { get; set; }
}
