using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface Builder
    {
        public void BuildProduct();
        public Product GetProduct();
    }


    public class FirstProductBuilder : Builder
    {
        private FirstProduct product;
    
        public void BuildProduct()
        {
       

            product = new FirstProduct();
        }

        public Product GetProduct()
        {
            return product;
        }
    }
    public class SecondProductBuilder : Builder
    {
        private SecondProduct product;
      
        public void BuildProduct()
        {
            product = new SecondProduct();
        }

        public Product GetProduct()
        {
            return product;
        }
    }

}
