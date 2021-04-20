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
    public partial class Form1 : Form
    {
        public int id= 1 ;
        public bool ver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(ver)
            {
                btnGuardar.Visible = true;
       
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            else
            {
                btnGuardar.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
            using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
            {
                var lst = from d in db.CLIENTES
                          select d;

                cmbcliente.DataSource = lst.ToList();
                cmbcliente.DisplayMember = "NOMBRE";
                cmbcliente.ValueMember = "ID";

                var lst_productos = from p in db.PRODUCTOS
                                    select p;
                cmbproductos.DataSource = lst_productos.ToList();
                cmbproductos.DisplayMember = "NOMBRE_PRODUCTO";
                cmbproductos.ValueMember = "ID";

                var lst_vendedor = from v in db.USUARIOS
                                   where v.ROL_ID ==2
                                    select v;
                cmbvendedor.DataSource = lst_vendedor.ToList();
                cmbvendedor.DisplayMember = "NOMBRE";
                cmbvendedor.ValueMember = "ID";


                cmbestado.SelectedIndex = 0;

                if(id > 0)
                {
                    var lst_detalle = from det in db.DETALLE_ORDEN
                                      where det.ID == id
                                       select det;
                    dateTimePicker1.Value = Convert.ToDateTime( lst_detalle.First().FECHA_ORDEN );
                    cmbcliente.SelectedValue = lst_detalle.First().CLIENTE_ID ;
                     dtfechainicio.Text  = Convert.ToDateTime(lst_detalle.First().FECHA_INICIO).ToString() ;
                     dtfechafin.Text = Convert.ToDateTime(lst_detalle.First().FECHA_FIN).ToString();
                    cmbvendedor.SelectedValue = lst_detalle.First().USUARIO_ID ;
                  cmbproductos.SelectedValue = lst_detalle.First().PRODUCTO_ID;
                    txtcantidad.Text =  lst_detalle.First().CANTIDAD.ToString();
                    txtcomentario.Text = lst_detalle.First().COMENTARIO ;
                    if(lst_detalle.First().MEDIDA =="CM")
                    {
                        rbcm.Checked = true;
                        txtalto.Text = lst_detalle.First().ALTO.ToString();
                        txtancho.Text = lst_detalle.First().ANCHO.ToString();
                        txtancho_bn.Text = lst_detalle.First().ANCHO_BN.ToString();
                        txtancho_bs.Text = lst_detalle.First().ANCHO_BS.ToString();
                        txtlargo_bn.Text = lst_detalle.First().LARGO_BN.ToString();
                        txtlargo_bs.Text = lst_detalle.First().LARGO_BS.ToString();
                    }
                    if (lst_detalle.First().MEDIDA == "PUL")
                    {
                        rbpul .Checked = true;
                        txtalto.Text = (lst_detalle.First().ALTO * 0.393701 ).ToString();
                        txtancho.Text = (lst_detalle.First().ANCHO * 0.393701).ToString();
                        txtancho_bn.Text = (lst_detalle.First().ANCHO_BN * 0.393701).ToString();
                        txtancho_bs.Text = (lst_detalle.First().ANCHO_BS * 0.393701).ToString();
                        txtlargo_bn.Text = (lst_detalle.First().LARGO_BN * 0.393701).ToString();
                        txtlargo_bs.Text = (lst_detalle.First().LARGO_BS * 0.393701).ToString();
                    }


                    cmbestado.Text = lst_detalle.First().ESTADO ;
                    

                }
                else
                {
                    cmbestado.Text = "NUEVO";
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {




                using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                {
                    models.DETALLE_ORDEN dt = new models.DETALLE_ORDEN();
                    dt.FECHA_ORDEN = dateTimePicker1.Value;
                    dt.CLIENTE_ID = Convert.ToInt32(cmbcliente.SelectedValue);
                   
                   
                    dt.USUARIO_ID = Convert.ToInt32(cmbvendedor.SelectedValue);
                    dt.PRODUCTO_ID = Convert.ToInt32(cmbproductos.SelectedValue);
                    dt.CANTIDAD = Convert.ToDouble(txtcantidad.Text);
                    dt.PRECIO = Convert.ToDouble(textBox1 .Text);
                    dt.COMENTARIO = txtcomentario.Text;
                    if (rbcm.Checked )
                    {
                        dt.MEDIDA = "CM";
                    }
                    if (rbpul.Checked)
                    {
                        dt.MEDIDA = "PUL";
                    }
                    if(dt.MEDIDA == "CM")
                    {
                        dt.ALTO = Convert.ToDouble(txtalto.Text);
                        dt.ANCHO = Convert.ToDouble(txtancho.Text);
                        dt.ANCHO_BN = Convert.ToDouble(txtancho_bn.Text);
                        dt.ANCHO_BS = Convert.ToDouble(txtancho_bs.Text);
                        dt.LARGO_BN = Convert.ToDouble(txtlargo_bn.Text);
                        dt.LARGO_BS = Convert.ToDouble(txtlargo_bs.Text);
                    }
                    else
                    {
                        dt.ALTO = Convert.ToDouble(txtalto.Text)  / 0.393701;
                        dt.ANCHO = Convert.ToDouble(txtancho.Text) / 0.393701;
                        dt.ANCHO_BN = Convert.ToDouble(txtancho_bn.Text) / 0.393701;
                        dt.ANCHO_BS = Convert.ToDouble(txtancho_bs.Text) / 0.393701;
                        dt.LARGO_BN = Convert.ToDouble(txtlargo_bn.Text) / 0.393701;
                        dt.LARGO_BS = Convert.ToDouble(txtlargo_bs.Text) / 0.393701;
                    }
        
                    dt.ESTADO = cmbestado.Text;
                    if (id > 0 )
                    {
                        dt.ID = id;
                        db.Entry(dt).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        db.DETALLE_ORDEN.Add(dt);
                    }
              
                    db.SaveChanges();
                    MessageBox.Show("Datos guardados con exito");
                    }


            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
 
        }

        private void rbpul_CheckedChanged(object sender, EventArgs e)
        {
            if(rbpul.Checked )
            {
                txtalto.Text = (Convert.ToDouble(txtalto.Text) * 0.393701).ToString();
                txtancho.Text = (Convert.ToDouble(txtancho.Text) * 0.393701).ToString();
                txtancho_bn.Text = (Convert.ToDouble(txtancho_bn.Text) * 0.393701).ToString();
                txtancho_bs.Text = (Convert.ToDouble(txtancho_bs.Text) * 0.393701).ToString();
                txtlargo_bn.Text = (Convert.ToDouble(txtlargo_bn.Text) * 0.393701).ToString();
                txtlargo_bs.Text = (Convert.ToDouble(txtlargo_bs.Text) * 0.393701).ToString();
            }
   
        }

        private void rbcm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcm.Checked)
            {
                txtalto.Text = (Convert.ToDouble(txtalto.Text) / 0.393701).ToString();
                txtancho.Text = (Convert.ToDouble(txtancho.Text) / 0.393701).ToString();
                txtancho_bn.Text = (Convert.ToDouble(txtancho_bn.Text) / 0.393701).ToString();
                txtancho_bs.Text = (Convert.ToDouble(txtancho_bs.Text) / 0.393701).ToString();
                txtlargo_bn.Text = (Convert.ToDouble(txtlargo_bn.Text) / 0.393701).ToString();
                txtlargo_bs.Text = (Convert.ToDouble(txtlargo_bs.Text) / 0.393701).ToString();
            }
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbestado.Text == "NUEVO")
            {
                MessageBox.Show("comienze a trabajar la orden antes de colocarla en pendiente");
            }
            else
            {
                UpdateStatus("CANCELADO");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbestado.Text == "NUEVO")
            {
                using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                {
                    models.DETALLE_ORDEN dt = new models.DETALLE_ORDEN();
                    var l = from d in db.DETALLE_ORDEN
                            where d.ID == id
                            select d;

                    dt = l.ToList().First();
                    dt.FECHA_INICIO = DateTime.Now;
                    db.Entry(dt).State = System.Data.Entity.EntityState.Modified;


                    db.SaveChanges();
                    MessageBox.Show("Datos guardados con exito");
                }
            }

                UpdateStatus("EN TRABAJO");

            
        }

        public bool UpdateStatus(string p)
        {

            try
            {
                using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                {
                    models.DETALLE_ORDEN dt = new models.DETALLE_ORDEN();
                    var l = from d in db.DETALLE_ORDEN
                            where d.ID == id
                            select d;

                    dt = l.ToList().First();
                    dt.ESTADO = p;
                    db.Entry(dt).State = System.Data.Entity.EntityState.Modified;
           

                    db.SaveChanges();
                    MessageBox.Show("Datos guardados con exito");
                }
                return true;


            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cmbestado.Text =="NUEVO")
            {
                MessageBox.Show("comienze a trabajar la orden antes de colocarla en pendiente");
            }
            else
            {
                UpdateStatus("PENDIENTE");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cmbestado.Text == "NUEVO")
            {
                MessageBox.Show("comienze a trabajar la orden antes de colocarla en pendiente");
            }
            else
            {
              
                    using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                    {
                        models.DETALLE_ORDEN dt = new models.DETALLE_ORDEN();
                        var l = from d in db.DETALLE_ORDEN
                                where d.ID == id
                                select d;

                        dt = l.ToList().First();
                        dt.FECHA_FIN  = DateTime.Now;
                        dt.ESTADO = "COMPLETADO";
                        db.Entry(dt).State = System.Data.Entity.EntityState.Modified;


                        db.SaveChanges();
                        MessageBox.Show("Datos guardados con exito");
                    }
      

              
            }
        }

        private const char SignoDecimal = '.'; // Carácter separador decimal
        private string _prevTextBoxValue; // Variable que almacena el valor anterior del Textbox
        public void decimales(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            // Si el carácter pulsado no es un carácter válido se anula
            e.Handled = !char.IsDigit(e.KeyChar) // No es dígito
                        && !char.IsControl(e.KeyChar) // No es carácter de control (backspace)
                        && (e.KeyChar != SignoDecimal // No es signo decimal o es la 1ª posición o ya hay un signo decimal
                            || textBox.SelectionStart == 0
                            || textBox.Text.Contains(SignoDecimal));
        }

        private void txtalto_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimales(sender, e);
        }

        private void txtancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimales(sender, e);
        }

        private void txtancho_bs_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimales(sender, e);
        }

        private void txtlargo_bs_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimales(sender, e);
        }

        private void txtancho_bn_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimales(sender, e);
        }

        private void txtlargo_bn_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimales(sender, e);
        }
    }
}
