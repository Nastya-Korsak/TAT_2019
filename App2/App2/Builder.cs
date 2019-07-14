using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    abstract class Builder
    {
        protected Builder builder;
        public Builder(Builder builder)
        {
            this.builder = builder;
        }

        public abstract Triangle Create(Point point1, Point point2, Point point3);
    }
}
