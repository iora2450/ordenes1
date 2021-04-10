using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenes
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
            {
         
                var lst = from c in db.USUARIOS
                          where c.USERNAME == textBox1.Text.Trim() && c.PASSWORD1  == textBox2.Text.Trim()
                          select c;
                if (lst.Count() > 0 )
                {

                    Utiles.userid = lst.First().ID;
                    util u = new util(lst.First().ID);
                    Utiles.guse = u.getu();
                    this.Hide();
                    principal p = new principal();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("CREDECIALES INCORRECTAS");
                }

            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
    }
}
