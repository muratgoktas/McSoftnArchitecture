using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete;

public class Product:Entity
{

    public string Name { get; set; }
    public byte Quantity { get; set; }
    public int Price { get; set; }

    public Product()
    {
    }

    public Product(int id,string name, byte quantity, int price)
    {   
        Id = id;     
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}
