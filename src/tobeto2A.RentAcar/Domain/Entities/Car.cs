﻿using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Car : Entity<Guid>
{
    public int Id { get; set; }
    public int ColorId { get; set; }
    public int ModelId { get; set; }
    public string CarState { get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }
    public DateTime UpdatedAt { get; set; }

}
