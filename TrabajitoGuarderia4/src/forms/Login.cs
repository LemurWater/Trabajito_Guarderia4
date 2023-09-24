using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using TrabajitoGuarderia4.src;
using TrabajitoGuarderia4.src.classes;

namespace TrabajitoGuarderia4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lProgramName.Text = Memory.ProgramName;
            this.Text = "Loging - " + lProgramName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool user = false;
            bool password = false;

            foreach(Account a in Memory.Accounts)
            {
                if (rtbUser.Text == a.User)
                {
                    user = true;
                    break;
                }
            }
            if (!user)
            {
                Memory.Error("El usuario no es valido");
                return;
            }

            foreach(Account a in Memory.Accounts)
            {
                if(rtbPassword.Text == a.Password)
                {
                    user=true;
                    //form2
                    return;
                }
            }
            Memory.Error("La contraseña no es valida");
        }
    }
}
