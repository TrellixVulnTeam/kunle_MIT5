using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCats.Models
{
    public class Product
    {
       [Key]
       public int ProductId {get; set;}
       public string Name {get; set;}
       public string Description {get; set;}
       public Decimal Price {get; set;}
       public DateTime CreatedAt {get; set;}
       public DateTime UpdatedAt {get; set;}
       public List<Association> ProductCategories {get; set;}
    }

    public class Category
    {
        [Key]
        public int CategoryId {get; set;}
        public string Name {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
        public List<Association> CategoryProducts {get; set;}
    }

    public class Association
    {
        public int AssociationId {get; set;}
        public int ProductId {get; set;}
        public int CategoryId {get; set;}
        public Product Product {get; set;}
        public Category Category {get; set;}
    }
}