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
    public partial class USUARIOS : Form
    {
        public int id;
        public USUARIOS()
        {
            InitializeComponent();
        }

        private void USUARIOS_Load(object sender, EventArgs e)
        {
            using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
            {

                var lst_vendedor = from v in db.ROL 
                                  
                                   select v;
                cmbvendedor.DataSource = lst_vendedor.ToList();
                cmbvendedor.DisplayMember = "NOMBRE";
                cmbvendedor.ValueMember = "ID";


                if (id > 0)
                {
                    var lst_detalle = from det in db.USUARIOS
                                      where det.ID == id
                                      select det;

                    txtid.Text = lst_detalle.First().ID.ToString();
                    txtnombre.Text = lst_detalle.First().NOMBRE;
                    txtapellido.Text = lst_detalle.First().APELLIDO;
                    cmbvendedor.SelectedValue = lst_detalle.First().ROL_ID ;
                    txtusu.Text = lst_detalle.First().USERNAME;
                    txtpass.Text = lst_detalle.First().PASSWORD1;

                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                {
                    models.USUARIOS dt = new models.USUARIOS();
                    dt.NOMBRE = txtnombre.Text;
                    dt.APELLIDO = txtapellido.Text;
                    dt.ROL_ID = Convert.ToInt32(cmbvendedor.SelectedValue);
                    dt.USERNAME = txtusu.Text;
                    dt.PASSWORD1 = txtpass.Text;
                    if (id > 0)
                    {
                        dt.ID = id;
                        db.Entry(dt).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        db.USUARIOS.Add(dt);
                    }

                    db.SaveChanges();
                    MessageBox.Show("Datos guardados con exito");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text =="MOSTRAR")
            {
                string a = txtpass .Text;
                txtpass.PasswordChar = '\0';
                txtpass.Text = a;
                button1.Text = "OCULTAR";

            }
            else
            {
                txtpass.PasswordChar = '*';
                button1.Text = "MOSTRAR";
            }
            
        }
    }
}
