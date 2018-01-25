using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;
using System.Drawing.Printing;

namespace BarCodeGenerator
{



    public partial class FormGenerator : Form
    {
        //public struct bcSettings
        //{
        //    public int scale;
        //    public int height;
        //    public int rotate;
        //}

        //public static bcSettings bcs;
        BCSettings SettingsValues = new BCSettings();

        public FormGenerator()
        {
            InitializeComponent();
            SettingsValues.Load();

            //bcs.height = 60;
            //bcs.rotate = 0;
            //bcs.scale = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var drawObject = BarcodeDrawFactory.Code39WithoutChecksum;
            pictureBox1.Image = drawObject.Draw(textBox1.Text, SettingsValues.BarCodeHeight, SettingsValues.BarCodeScale);
            btn_Print.Enabled = true;
            btn_Print.Focus();
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.RotateTransform(SettingsValues.BarCodeRotate);
            e.Graphics.DrawImage(pictureBox1.Image, SettingsValues.BarCodePosX, SettingsValues.BarCodePosY);
            e.Graphics.DrawString(InsertSpaces(textBox1.Text), new Font(new FontFamily("Helvetica"), 14, FontStyle.Regular, GraphicsUnit.Point),
                    new SolidBrush(Color.Black), SettingsValues.BarCodePosX, SettingsValues.BarCodeHeight + SettingsValues.BarCodeHeight/5);
            e.Graphics.RotateTransform(SettingsValues.BarCodeRotate); 
            e.HasMorePages = false;
            // e.Graphics.TranslateTransform(0,0);

            //e.Graphics.DrawImage(pictureBox1.Image,10,-800);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_Print.Enabled = false;
            bool AllowGenerate =true;
            if (textBox1.Text == String.Empty) AllowGenerate=false;
            if (TextCheck(textBox1.Text)) { textBox1.ForeColor = Color.Black; } else { textBox1.ForeColor = Color.Red; AllowGenerate=false; } 
            if (textBox1.TextLength!= 14) AllowGenerate =false;
            if (AllowGenerate)  btn_Generate.Enabled = true;  else btn_Generate.Enabled = false;
                            
 
        }

        private bool TextCheck(string str)
        {
            bool ret = true;
            int strLen = str.Length;
            for (int i = 0; i < strLen; i++)
            {
                char ch=str[i];
                if (!Char.IsLetterOrDigit(ch)) ret = false;
            }
                return ret;
        }

        //private void принтерToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    printDialog1.ShowDialog();

        //}

        private void штрихкодToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                e.Graphics.DrawString(InsertSpaces(textBox1.Text), new Font(new FontFamily("Helvetica"), 14, FontStyle.Regular, GraphicsUnit.Point),
                                    new SolidBrush(Color.Black), 1, SettingsValues.BarCodeHeight + SettingsValues.BarCodeHeight/7);
                e.Graphics.Flush();

//                pictureBox1.Image = ;
                //pictureBox1.Invalidate();
                //gr.Dispose();
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.PrinterSettings.PrinterName = SettingsValues.PrinterName;
                printDocument1.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
                printDocument1.Print();
                textBox1.Text = String.Empty;
                pictureBox1.Image = null;
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Печать невозможна. Принтер не найден.");
            }
        }
        private String InsertSpaces(String str)
        {
            if (str == String.Empty) return String.Empty;
            if (Properties.Settings.Default.BarCodeRarefaction < 1) return str;
            int strLen=str.Length;
            String strResult=String.Empty;
            for (int i=0; i<strLen; i++)
            {
                strResult = strResult + str[i] + new String(' ', Properties.Settings.Default.BarCodeRarefaction);
            }
            return strResult;
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarCodeSettings dlg = new BarCodeSettings();
            dlg.sets = SettingsValues;

            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK)
            {
                SettingsValues = dlg.sets;

                SettingsValues.Save();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я' || c == 'ё' || c == 'Ё';
        }
    }
}
