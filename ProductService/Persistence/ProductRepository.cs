using System;
using System.Linq;
using System.Collections.Generic;
using ProductService.Models;
using Microsoft.EntityFrameworkCore;
using ProductService.Contexts;

namespace ProductService.Persistence
{
  public class ProductRepository : IProductRepository
  {
    private readonly ProductContext _context;
    public ProductRepository(ProductContext context) => _context = context;
    public void Add(Product Product)
    {
      _context.Add(Product);
      _context.SaveChanges();
    }
    public IEnumerable<Product> GetAll() =>
      _context.Products.Include(c => c.Category).ToList();
    public Product GetBy(Guid id) =>
      _context.Products.Include(c => c.Category).FirstOrDefault(p => p.Id == id);
    public void Remove(Guid id)
    {
      Product product = GetBy(id);
      _context.Remove(product);
      _context.SaveChanges();
    }
    public void Update(Product product)
    {
      _context.Update(product);
      _context.SaveChanges();
    }
  }
}