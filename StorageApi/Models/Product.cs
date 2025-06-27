namespace StorageApi.Models
{



    /*Del 2 – Skapa din modell
1. Skapa en mapp Models
2. Skapa en klass Product.cs med följande egenskaper:
o int Id,
o string Name,
o int Price,
o string Category,
o string Shelf,
o int Count,
o string Description,
    */




    public class Product
    {
        public Product(int Id,
                       string Name,
                       int Price,
                       string Category,
                       string Shelf,
                       int Count,
                       string Description

            )
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Category = Category;
            this.Shelf = Shelf;
            this.Count = Count;
            this.Description = Description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
