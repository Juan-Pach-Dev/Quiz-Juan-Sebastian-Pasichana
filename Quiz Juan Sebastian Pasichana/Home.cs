using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Juan_Sebastian_Pasichana
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int Index = chkPuntuación.SelectedIndex;
            if (Index != -1)
            {
                rchAlmacenamiento.Text = txtNombre.Text + "\n" + dtpFecha.Text + "\n" + lblGenero + "\n" + cmbGenero.Text + "\n" + txtNombrepelicula + "\n" + chkPuntuación.Items[Index].ToString(); 
            }
            


          


            {
            
                
        }
    }

        
        

        private void btnReport_Click(object sender, EventArgs e)
        {
            String reporte = rchAlmacenamiento.Text;
            Form Formulario = new Report(reporte);
            Formulario.Show();
        }
    }
    }
