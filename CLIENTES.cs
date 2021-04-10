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
    public partial class CLIENTES : Form
    {
        public int id;
        public CLIENTES()
        {
            InitializeComponent();
        }

        private void CLIENTES_Load(object sender, EventArgs e)
        {
            using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
            {

                if (id > 0)
                {
                    var lst_detalle = from det in db.CLIENTES
                                      where det.ID == id
                                      select det;

                    txtid.Text = lst_detalle.First().ID.ToString();
                    txtnombre.Text = lst_detalle.First().NOMBRE;
                    txtapellido.Text = lst_detalle.First().APELLIDOS;
                    txtdireccion.Text = lst_detalle.First().DIRECCION;
                    txttelefono.Text = lst_detalle.First().TELEFONO;
                    txtregistro.Text = lst_detalle.First().REGISTRO;


                }
            }
        }
   
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
             if (txtnombre.Text.Trim().Length == 0 )
             {
                    MessageBox.Show("Complete la informacion");
             }

                if (txtapellido.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Complete la informacion");
                }

                if (txtdireccion .Text.Trim().Length == 0)
                {
                    MessageBox.Show("Complete la informacion");
                }

                if (txttelefono.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Complete la informacion");
                }

                if (txtregistro.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Complete la informacion");
                }


                using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                {
                    models.CLIENTES  dt = new models.CLIENTES ();
                    dt.NOMBRE = txtnombre.Text;
                    dt.APELLIDOS = txtapellido.Text;
                    dt.DIRECCION = txtdireccion.Text;
                    dt.TELEFONO = txttelefono.Text;
                    dt.REGISTRO = txtregistro.Text;
                    if (id > 0)
                    {
                        dt.ID = id;
                        db.Entry(dt).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        db.CLIENTES .Add(dt);
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
    }
}
