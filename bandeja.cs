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
    public partial class bandeja : Form
    {
        public bandeja()
        {
            InitializeComponent();
        }
        public void refrescar()
        {
            using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
            {
                dataGridView1.AutoGenerateColumns = false;
                var lst = from ordernes in db.DETALLE_ORDEN
                          join cliente1 in db.CLIENTES on ordernes.CLIENTE_ID equals cliente1.ID
                          join usuario1 in db.USUARIOS on ordernes.USUARIO_ID equals usuario1.ID
                       where ordernes.FECHA_ORDEN >= dateTimePicker1.Value && ordernes.FECHA_ORDEN <= dateTimePicker2.Value
                          select new { ID = ordernes.ID, FECHA_ORDEN = ordernes.FECHA_ORDEN, CLIENTE = cliente1.NOMBRE, VENDEDOR = usuario1.NOMBRE, ESTADO = ordernes.ESTADO };


                dataGridView1.DataSource = lst.ToList();
                if (comboBox1.Items.Count > 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = lst.ToList().Where(s => s.CLIENTE  == comboBox1.Text ).ToList();
                }
                if (comboBox2.Items.Count > 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = lst.ToList().Where(s => s.VENDEDOR  == comboBox2.Text).ToList();
                }
            }
        }
        private void bandeja_Load(object sender, EventArgs e)
        {
            refrescar();
            if (Utiles.guse.ROL_ID ==3)
            {
                btnNuevo.Visible = false;
                btnactualizar.Visible = true;
                BtnEliminar.Visible = false;
                BtnEditar.Visible = false;
                button1.Visible = true;
                dataGridView1.Columns["VENDEDOR"].Visible = false;
                dataGridView1.Columns["CLIENTE"].Visible = false;
                groupBox1.Visible = false;
            }
            else
            {
                btnNuevo.Visible = true;
                btnactualizar.Visible = true;
                BtnEliminar.Visible = true;
                button1.Visible = false;
                BtnEditar.Visible = true;
                groupBox1.Visible = true ;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            // Set the Parent Form of the Child window.
   

            // Display the new form.

            newMDIChild.id = 0;
            newMDIChild.ver  = true;
            newMDIChild.ShowDialog();
            newMDIChild.Close();
            refrescar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            // Set the Parent Form of the Child window.


            // Display the new form.
            newMDIChild.ver = true;
            newMDIChild.id = Convert.ToInt32( dataGridView1.CurrentRow.Cells["ID"].Value);
            newMDIChild.ShowDialog();
            newMDIChild.Close();
            refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            // Set the Parent Form of the Child window.


            // Display the new form.
            newMDIChild.ver = false;
            newMDIChild.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            newMDIChild.ShowDialog();
            newMDIChild.Close();
            refrescar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked )
            {
                using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    var lst = from cliente in db.CLIENTES 
                              select cliente;
                    comboBox1 .DataSource = lst.ToList();
                    comboBox1.DisplayMember = "NOMBRE";
                    comboBox2.ValueMember = "NOMBRE";
                }
            }
            else
            {
                comboBox1.DataSource = null;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    var lst = from cliente in db.USUARIOS
                              where cliente.ROL_ID ==2
                              select cliente;
                    comboBox2.DataSource = lst.ToList();
                    comboBox2.DisplayMember = "NOMBRE";
                    comboBox2.ValueMember = "NOMBRE";
                }
            }
            else
            {
                comboBox2.DataSource = null;

            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            refrescar(); 
        }
    }
}
