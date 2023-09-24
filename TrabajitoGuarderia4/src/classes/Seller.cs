using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajitoGuarderia4.src.classes
{
    internal class Seller : Account
    {
        private List<Shop> shops;
        private float stars;


        public Seller(long id, string user, string password, string name, double money, string information) : base(id, user, password, name, money, information)
        {
            this.Shops = shops;
            this.Stars = 0.0f;
        }

        public float Stars { get => stars; set => stars = value; }
        internal List<Shop> Shops { get => shops; set => shops = value; }
    }
}
