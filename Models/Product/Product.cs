namespace Shop.Models
{
    public class Product
    {
        public Product(string name, double price, string description, string pathImg)
        {
            Name = name;
            Price = price;
            Description = description;
            PathImg = pathImg;
        }
        public Product() { }

        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Себестоимость 
        /// </summary>
        public double Price { get; set; }
        public string Description { get; set; }
        public string PathImg { get; set; }

        public override string ToString()
        {
            return $"ID:{Id} Name:{Name} Price:{Price} Description:{Description} PatthIng:{PathImg} \n";
        }
    }
}
