﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Dtos;

public class CreatedProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public byte Quantity { get; set; }
    public int Price { get; set; }
}
