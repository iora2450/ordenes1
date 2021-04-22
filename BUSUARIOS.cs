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
    public partial class BUSUARIOS : Form
    {
        public BUSUARIOS()
        {
            InitializeComponent();
        }
        public void refrescar()
        {
            using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
            {
                dataGridView1.AutoGenerateColumns = false;
                var lst = from c in db.USUARIOS
                          join crol in db.ROL on c.ROL_ID  equals crol.ID 
                          select new { ID= c.ID, NOMBRE=c.NOMBRE , APELLIDO= c.APELLIDO , ROL = crol.NOMBRE   };
                dataGridView1.DataSource = lst.ToList();

            }
        }
        private void BUSUARIOS_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            USUARIOS newMDIChild = new USUARIOS();
            // Set the Parent Form of the Child window.


            // Display the new form.
            newMDIChild.WindowState = FormWindowState.Normal;
            newMDIChild.id = 0;
            newMDIChild.ShowDialog();
            newMDIChild.Close();
            refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            USUARIOS newMDIChild = new USUARIOS();
            // Set the Parent Form of the Child window.


            // Display the new form.
            newMDIChild.WindowState = FormWindowState.Normal;
            newMDIChild.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            newMDIChild.ShowDialog();
            newMDIChild.Close();
            refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Se eliminara el registro, continuar?";
                string caption = "Confirmar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                    {
                        db.Database.ExecuteSqlCommand("delete from usuarios where id = " + dataGridView1.CurrentRow.Cells["ID"].Value.ToString() + "");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
