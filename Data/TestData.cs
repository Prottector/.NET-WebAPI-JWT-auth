using CoffeMugApplicationProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoffeMugApplicationProject.Data
{
    public class TestData
    {
        

        public static void Init(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ProductContext>();
                context.Database.EnsureCreated();

                
                            
                if (context.Products != null && context.Products.Any())
                {
                    
                    return;

                }
                else
                {
                    var products = TestData.GetProducts(context).ToArray();
                    context.Products.AddRange(products);
                    context.SaveChanges();
                }

                
              

                



            }
        }

        
        public static List<Product> GetProducts(ProductContext db)
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    
                    Name = "Black Coffee",
                    Price = 5m,
                    
                },
                new Product
                {
                    
                    Name = "White Coffee",
                    Price =6m,
                    
                },
                new Product
                {
                    
                    Name = "Cappuccino",
                    Price = 6.5m,
                    
                },
                new Product
                {
                    
                    Name = "Espresso",
                    Price = 4m,
                    
                },
                new Product
                {
                   
                    Name = "Latte Macchiato",
                    Price = 7.5m,
                    
                }
            };
            return products;
        }

    }
}
