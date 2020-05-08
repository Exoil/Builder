
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class Product
    {
        public int id { get; set; }
        public string name { get; set; }

        public Product()
        {
            Random rng = new Random(Guid.NewGuid().GetHashCode());

            id = rng.Next(1000);
            name = GenerateName(rng);
        }
      
        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        protected string GenerateName(Random rng)
        {
            string name = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                name += ((char)rng.Next(65, 90)).ToString();
            }

            return name;
        }

        public override string ToString()
        {
            return $"{id}: {name}";
        }

        public override bool Equals(object obj)
        {
            if(obj is Product)
            {
                var that = obj as Product;
                return this.id.Equals(that.id);
            }
            return false;
        }

        abstract public void CallProduct();
  

    }


    public class FirstProduct : Product
    {
        public FirstProduct() : base()
        {

        }
        public FirstProduct(int id, string name) :base(id,name)
        {

        }

        public override void CallProduct()
        {
            Console.WriteLine($"Hey! I am first product! {this}");
        }
    }

    public class SecondProduct : Product
    {
        public SecondProduct(): base()
        {

        }


        public SecondProduct(int id, string name) : base(id, name)
        {

        }

        public override void CallProduct()
        {
            Console.WriteLine($"Hey! I am second product! {this}");
        }
    }
}
