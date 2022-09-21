namespace PartDataBase
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
            parts = parts.OrderBy(p => p.sku).ToList();
        }

        /// <summary>
        /// Sorts the List by Price
        /// </summary>
        public void SortByPrice()
        {
            parts = parts.OrderBy(p => p.price).ToList();
        }

        /// <summary>
        /// Sorts the List by In Stock
        /// </summary>
        public void SortByInStock()
        {
            parts = parts.OrderBy(p => p.inStock).ToList();
        }

        /// <summary>
        /// Get's the part by the name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>the part</returns>
        /// <exception cref="Exception">Thrown if part is not found</exception>
        public Part Get(string name)
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
        public Part Get(int sku)
        {
            foreach (Part part in parts)
            {
                if (part.sku == sku)
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
        public Part Get(double price)
        {
            foreach (Part part in parts)
            {
                if (part.price == price)
                    return part;
            }

            throw new Exception("No such part");
        }

    }

    /// <summary>
    /// Custom structure for a part
    /// </summary>
    public struct Part
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int sku { get; set; }

        public double price { get; set; }

        public int inStock { get; set; }
    }
}