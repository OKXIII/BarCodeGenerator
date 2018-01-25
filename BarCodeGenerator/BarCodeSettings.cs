using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace BarCodeGenerator
{

    public partial class BarCodeSettings : Form
    {
        public int height;
        public int scale;
        public int rotate;
        public BCSettings sets = new BCSettings();

        public BarCodeSettings()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BarCodeSettings_Load(object sender, EventArgs e)
        {
            this.text_Height.Text = sets.BarCodeHeight.ToString();
            this.text_Rotate.Text = sets.BarCodeRotate.ToString();
            this.text_Scale.Text = sets.BarCodeScale.ToString();
            this.text_PosX.Text = sets.BarCodePosX.ToString();
            this.text_PosY.Text = sets.BarCodePosY.ToString();
            this.text_Rarefaction.Text = sets.BarCodeRarefaction.ToString();
            PrinterSettings.StringCollection sc = PrinterSettings.InstalledPrinters;
            for (int i=0; i<sc.Count; i++)
            {
                this.fld_PrinterName.Items.Add(sc[i].ToString());
            }
            this.fld_PrinterName.Text = sets.PrinterName;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            sets.PrinterName = this.fld_PrinterName.Text;
            sets.BarCodeHeight = Convert.ToInt32(this.text_Height.Text);
            sets.BarCodePosX = Convert.ToInt32(this.text_PosX.Text);
            sets.BarCodePosY = Convert.ToInt32(this.text_PosY.Text);
            sets.BarCodeRarefaction = Convert.ToInt32(this.text_Rarefaction.Text);
            sets.BarCodeRotate = Convert.ToInt32(this.text_Rotate.Text);
            sets.BarCodeScale = Convert.ToInt32(this.text_Scale.Text);
            //sets.BarCodeType = Convert.ToInt32(this.text_Type);
            //height = Convert.ToInt32( this.text_Height.Text);
            //rotate=Convert.ToInt32( this.text_Rotate.Text);
            //scale =  Convert.ToInt32( this.text_Scale.Text);
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
