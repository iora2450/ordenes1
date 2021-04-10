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
    public partial class BPRODUCTOS : Form
    {
        public BPRODUCTOS()
        {
            InitializeComponent();
        }
        public void refrescar()
        {
            using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
            {
                dataGridView1.AutoGenerateColumns = false;
                var lst = from c in db.PRODUCTOS 
        
                          select c;
                dataGridView1.DataSource = lst.ToList();

            }
        }
        private void BPRODUCTOS_Load(object sender, EventArgs e)
        {
            refrescar();
        }
  
        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            PRODUCTOS newMDIChild = new PRODUCTOS();
            // Set the Parent Form of the Child window.


            // Display the new form.
            newMDIChild.WindowState = FormWindowState.Normal;
            newMDIChild.id = 0;
            newMDIChild.ShowDialog();
            newMDIChild.Close();
            refrescar();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            PRODUCTOS newMDIChild = new PRODUCTOS();
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
