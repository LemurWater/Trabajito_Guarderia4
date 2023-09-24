using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabajitoGuarderia4.src.classes
{
    internal class Shop
    {
        private long id;
        private string name;
        private List<Product> products;
        private double sells;
        private float stars;

        private string slogan;
        private Bitmap image;


        public Shop(long id, string name, double sells, List<Product> products, 
            string slogan, Bitmap image)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Sells = sells;
            Products = products ?? throw new ArgumentNullException(nameof(products));

            this.Slogan = slogan ?? throw new ArgumentNullException(nameof(slogan));
            this.Stars = 0.0f;

            this.Image = image;
        }



        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Sells { get => sells; set => sells = value; }
        public string Slogan { get => slogan; set => slogan = value; }
        public float Stars { get => stars; set => stars = value; }
        public Bitmap Image { get => image; set => image = value; }
        internal List<Product> Products { get => products; set => products = value; }
    }
}
