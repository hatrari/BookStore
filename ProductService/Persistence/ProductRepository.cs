using System;
using System.Collections.Generic;
using ProductService.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductService.Persistence
{
  public class ProductRepository : IProductRepository
  {
    public void Add(Product Product)
    {
      throw new NotImplementedException();
    }
    public IEnumerable<Product> GetAll()
    {
      throw new NotImplementedException();
    }
    public Product GetBy(Guid id)
    {
      throw new NotImplementedException();
    }
    public void Remove(Guid id)
    {
      throw new NotImplementedException();
    }
    public void Update(Product Product)
    {
      throw new NotImplementedException();
    }
  }
}