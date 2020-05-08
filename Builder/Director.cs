using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        private Builder builder;

        public Director(Builder concreateBuilder)
        {
            this.builder = concreateBuilder;
        }

        public Product Contstruct()
        {
            builder.BuildProduct();
            return builder.GetProduct();
        }

    }
}
