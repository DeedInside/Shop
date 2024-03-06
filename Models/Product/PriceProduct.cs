namespace Shop.Models
{
    public class PriceProduct
    {
        public PriceProduct(Product product, double price, DateOnly departure, DateOnly validThrough, int count)
        {
            Product = product;
            Price = price;
            Departure = departure;
            ValidThrough = validThrough;
            Count = count;
        }
        public PriceProduct() { }

        public int Id { get; set; }
        public Product Product { get; set; }
        /// <summary>
        /// Цена продукта с наценкой магазина
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Дата поступление продукта
        /// </summary>
        public DateOnly Departure { get; set; }
        /// <summary>
        /// Срок годности
        /// </summary>
        public DateOnly ValidThrough { get; set; }
        /// <summary>
        /// Кол-во товара
        /// </summary>
        public int Count { get; set; }
    }
}
