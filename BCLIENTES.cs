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
    public partial class BCLIENTES : Form
    {
        public BCLIENTES()
        {
            InitializeComponent();
        }
        public void refrescar()
        {
            using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
            {
                dataGridView1.AutoGenerateColumns = false;
                var lst = from c in db.CLIENTES 
                        
                          select c ;
                dataGridView1.DataSource = lst.ToList();

            }
        }
        private void BCLIENTES_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CLIENTES  newMDIChild = new CLIENTES();
            // Set the Parent Form of the Child window.


            // Display the new form.
            newMDIChild.WindowState = FormWindowState.Normal ;
           
            newMDIChild.id = 0;
            newMDIChild.ShowDialog();
            newMDIChild.Close();
            refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CLIENTES newMDIChild = new CLIENTES();
            // Set the Parent Form of the Child window.


            // Display the new form.
            newMDIChild.WindowState = FormWindowState.Normal;
            newMDIChild.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            newMDIChild.ShowDialog();
            newMDIChild.Close();
            refrescar();
        }
    }
}
