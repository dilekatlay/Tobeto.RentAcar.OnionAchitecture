﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Commands.Create;
public class CreatedCarResponse
{
    public Guid Id { get; set; }
    public int ColorId { get; set; }
    public int ModelId { get; set; }
    public string CarState { get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }
}
