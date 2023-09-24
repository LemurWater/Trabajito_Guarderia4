using System;
using System.Collections.Generic;
using System.Text;
using TrabajitoGuarderia4.src.enums;

namespace TrabajitoGuarderia4.src.classes
{
    internal class Product
    {
        private long id;
        private string name;
        private ProductType type;

        public Product(long id, string name, ProductType type)
        {
            this.Id = id;
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Type = type;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal ProductType Type { get => type; set => type = value; }
    }
}
