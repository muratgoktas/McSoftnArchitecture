using Application.Features.Products.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Commands.CreateProduct;

public partial class CreateProductCommand:IRequest<CreatedProductDto>
{
    public string Name { get; set; }
}
