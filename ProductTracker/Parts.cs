using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductTracker
{
    public class Parts
    {
        private List<Part> parts;
        string name; //name of the parts company or class

        
        /// <summary>
        /// Constructor for the parts class
        /// </summary>
        /// <param name="name"></param>
        public Parts(string name)
        {
            this.name = name;
            parts = new List<Part>();
        }

        /// <summary>
        /// Get's all the parts
        /// </summary>
        /// <returns>list of the parts</returns>
        public List<Part> GetAll()
        {
            return parts;
        }

        /// <summary>
        /// Sorts the List by name
        /// </summary>
        public void SortByName()
        {
            parts = parts.OrderBy(p => p.Name).ToList();
        }

        /// <summary>
        /// Sorts the List by Sku
        /// </summary>
        public void SortBySku()
        {
            parts = parts.OrderBy(p => p.Sku).ToList();
        }

        /// <summary>
        /// Sorts the List by Price
        /// </summary>
        public void SortByPrice()
        {
            parts = parts.OrderBy(p => p.Price).ToList();
        }

        /// <summary>
        /// Sorts the List by In Stock
        /// </summary>
        public void SortByInStock()
        {
            parts = parts.OrderBy(p => p.InStock).ToList();
        }

        /// <summary>
        /// Get's the part by the name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>the part</returns>
        /// <exception cref="Exception">Thrown if part is not found</exception>
        public Part GetByName(string name)
        {
            string temp = name.ToLower();
            foreach(Part part in parts)
            {
                if(part.Name.ToLower() == temp)
                    return part;
            }

            throw new Exception("No such part");
        }


        /// <summary>
        /// Get's the item by the SKU number
        /// </summary>
        /// <param name="sku">sku number</param>
        /// <returns>the part</returns>
        /// <exception cref="Exception">Thrown if part is not found</exception>
        public Part GetBySku(string sku)
        {
            foreach (Part part in parts)
            {
                if (part.Sku == sku)
                    return part;
            }

            throw new Exception("No such part");
        }

        /// <summary>
        /// Get's the part by the price, this will return the first item of that price.
        /// </summary>
        /// <param name="price"></param>
        /// <returns>the part</returns>
        /// <exception cref="Exception">Thrown if part is not found</exception>
        public Part GetByPrice(string price)
        {
            foreach (Part part in parts)
            {
                if(part.Price == price)
                    return part;
            }

            throw new Exception("No such part");
        }


        public void AddPart(string name, string sku, string price, string inStock)
        {
            parts.Add(new Part(name, sku, price, inStock));
        }
    }

    /// <summary>
    /// Custom structure for a part
    /// </summary>
    public class Part
    {
        public Part(string name, string sku, string price, string inStock)
        {
            Name = Name;
            Price = price;
            Sku = sku;
            InStock = inStock;
        }

        public string Name { get; set; }

        public string Sku { get; set; }

        public string Price { get; set; }

        public string InStock { get; set; }
    }
}