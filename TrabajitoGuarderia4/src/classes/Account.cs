using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabajitoGuarderia4.src.classes
{
    internal class Account
    {
        private long id;
        private string user;
        private string password;
        private string name;
        private double money;

        private string information;

        private Bitmap image;




        public Account(long id, string user, string password, 
                        string name, double money, string information, Bitmap image)
        {
            this.Id = id;
            this.User = user ?? throw new ArgumentNullException(nameof(user));
            this.Password = password ?? throw new ArgumentNullException(nameof(password));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Money = money;
            
            this.Information = information ?? throw new ArgumentNullException(nameof(information));

            this.Image = image;
        }



        public long Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public double Money { get => money; set => money = value; }
        public string Information { get => information; set => information = value; }
        public Bitmap Image { get => image; set => image = value; }
    }
}
