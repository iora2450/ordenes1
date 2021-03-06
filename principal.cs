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
    public partial class principal : Form
    {
        private int childFormNumber = 0;

        public principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        public void WindowsOpen(Form o)
        {
            try
            {
                // entradas_form = New ENTRADAS()
                TabPage tg = new TabPage();
                o.TopLevel = false;
                tabControl1.TabPages.Add(tg);
                // o.TopLevel = False
                o.Parent = this.tabControl1.TabPages[tabControl1.TabPages.Count - 1];
                // tg.Controls.Add(entradas_form)
                tg.Text = o.Text ;
                o.WindowState = FormWindowState.Maximized;
                o.FormBorderStyle = FormBorderStyle.None;
                o.ControlBox = false;

                o.Show();
                o.Select();
                if (o.IsHandleCreated == true)
                {
                    tabControl1.Focus();
                    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                }
            }
            catch(Exception ex)
            {

            }
       
        }

        private void principal_Load(object sender, EventArgs e)
        {

            if(Utiles.guse.ROL_ID ==3)
            {
                vENDEDORESToolStripMenuItem.Visible = false;
                cLIENTESToolStripMenuItem .Visible = false;
                pRODUCTOSToolStripMenuItem.Visible = false;
                oRDENESToolStripMenuItem.Visible = true;
                uSUARIOSToolStripMenuItem.Visible = false;

            }
            else if (Utiles.guse.ROL_ID == 1)
            {

                vENDEDORESToolStripMenuItem.Visible = true;
                cLIENTESToolStripMenuItem.Visible = true;
                pRODUCTOSToolStripMenuItem.Visible = true;
                oRDENESToolStripMenuItem.Visible = true;
                uSUARIOSToolStripMenuItem.Visible = true;
            }
            else
            {
                vENDEDORESToolStripMenuItem.Visible = false;
                cLIENTESToolStripMenuItem.Visible = true;
                pRODUCTOSToolStripMenuItem.Visible = true;
                oRDENESToolStripMenuItem.Visible = true;
                uSUARIOSToolStripMenuItem.Visible = false;
            }
        
       

                        bandeja newMDIChild = new bandeja();
            // Set the Parent Form of the Child window.
            WindowsOpen(newMDIChild);
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BCLIENTES  newMDIChild = new BCLIENTES();
            int u = 0;
            foreach (TabPage i in tabControl1.TabPages)
            {
                if (i.Text.Trim() == newMDIChild.Name.Trim())
                {
                    u += 1;
                }
            }
            if (u == 0)
            {
                WindowsOpen(newMDIChild);

            }

        }

        private void vENDEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BVENDEDOR  newMDIChild = new BVENDEDOR();

            int u = 0;
            foreach(TabPage i in tabControl1.TabPages )
            {
                if (i.Text.Trim() == newMDIChild.Name.Trim())
                {
                    u += 1;
                }
            }
            if(u==0)
            {
                WindowsOpen(newMDIChild);

            }


        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BPRODUCTOS newMDIChild = new BPRODUCTOS ();
            int u = 0;
            foreach (TabPage i in tabControl1.TabPages)
            {
                if (i.Text.Trim() == newMDIChild.Name.Trim())
                {
                    u += 1;
                }
            }
            if (u == 0)
            {
                WindowsOpen(newMDIChild);

            }

        }

        private void oRDENESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bandeja newMDIChild = new bandeja();
            int u = 0;
            foreach (TabPage  i in tabControl1.TabPages)
            {
                if (i.Text .Trim() == newMDIChild.Name.Trim())
                {
                    u += 1;

                }
            }
            if (u == 0)
            {
                WindowsOpen(newMDIChild);

            }

        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUSUARIOS newMDIChild = new BUSUARIOS();
            int u = 0;
            foreach (TabPage i in tabControl1.TabPages)
            {
                if (i.Text.Trim() == newMDIChild.Name.Trim())
                {
                    u += 1;
                }
            }
            if (u == 0)
            {
                WindowsOpen(newMDIChild);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*      Try
                  Dim i As Integer = Me.TabControl1.SelectedTab.TabIndex
                  TabControl1.TabPages.Remove(TabControl1.SelectedTab)
                  If Not i = 0 Then
                      TabControl1.SelectedIndex = i - 1
                  End If

              Catch ex As Exception

              End Try*/
            int i = this.tabControl1.SelectedIndex;
            tabControl1.TabPages.Remove(tabControl1.TabPages[i]);



        
        }
    }
}
