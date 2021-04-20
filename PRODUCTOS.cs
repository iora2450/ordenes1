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
    public partial class PRODUCTOS : Form
    {
        public int id;
        public PRODUCTOS()
        {
            InitializeComponent();
        }

        private void PRODUCTOS_Load(object sender, EventArgs e)
        {
            using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
            {

                if (id > 0)
                {
                    var lst_detalle = from det in db.PRODUCTOS
                           where det.ID == id
                                      select det;

                    txtid.Text = lst_detalle.First().ID.ToString();
                    txtnombre.Text = lst_detalle.First().NOMBRE_PRODUCTO ;
         



                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                {
                    models.PRODUCTOS  dt = new models.PRODUCTOS();
                    dt.NOMBRE_PRODUCTO = txtnombre.Text;

           
                    if (id > 0)
                    {
                        dt.ID = id;
                        db.Entry(dt).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        db.PRODUCTOS .Add(dt);
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
