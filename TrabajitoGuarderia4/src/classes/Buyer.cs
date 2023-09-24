using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TrabajitoGuarderia4.src.classes
{
    internal class Buyer : Account
    {
        private List<Product> history;


        public Buyer(List<Product> history , long id, string user, string password, string name, 
            double money) : base(id, user, password, name, money)
        {
            this.History = history;
        }

        internal List<Product> History { get => history; set => history = value; }
    }
}
