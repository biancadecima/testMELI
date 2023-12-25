namespace ConsoleApp1
{
    class Product : IEquatable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }

        public Product(string name, int price, int weight) 
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }

        public bool Equals(Product other)
        {
            return this.Name == other.Name &&
                   this.Price == other.Price &&
                   this.Weight == other.Weight;
        }

        /*Al implementar IEquatable<T> y GetHashCode() en la clase Product, se puede definir una lógica personalizada para determinar la igualdad de objetos.*/
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Weight);
        }
    }
    internal class Program
    {
        class Result
        {
            /*
             * Complete the 'numDuplicates' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. STRING_ARRAY name
             *  2. INTEGER_ARRAY price
             *  3. INTEGER_ARRAY weight
             */

            public static int numDuplicates(List<string> name, List<int> price, List<int> weight)
            {
                HashSet<Product> uniqueProducts = new HashSet<Product>(); /* La búsqueda en un HashSet<T> tiene una complejidad promedio de tiempo de O(1) para operaciones de búsqueda, 
                                                                           * lo que significa que, en promedio, la búsqueda de un elemento en un HashSet<T> 
                                                                           * no aumenta significativamente a medida que aumenta el número de elementos almacenados*/
                List<Product> products = new List<Product>();
                for (int i = 0; i < name.Count; i++)
                {
                    products.Add(new Product(name[i], price[i], weight[i]));
                }

                foreach (var product in products)
                {
                    uniqueProducts.Add(product);
                }
                return products.Count - uniqueProducts.Count;
            }
        }
    }
}