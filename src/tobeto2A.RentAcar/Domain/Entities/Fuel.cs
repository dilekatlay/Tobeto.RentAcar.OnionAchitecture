﻿using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Fuel : Entity<Guid>
{
    public int Id { get; set; }
    public string Name { get; set; }
}
