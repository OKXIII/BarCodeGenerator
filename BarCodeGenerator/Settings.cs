using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BarCodeGenerator
{
    public class BCSettings
    {
        public int BarCodeHeight;
        public int BarCodeScale;
        public int BarCodeType;
        public int BarCodePosX;
        public int BarCodePosY;
        public int BarCodeRarefaction;
        public string PrinterName;
        public int BarCodeRotate;

        public void Load ()
        {
            BarCodeHeight = Properties.Settings.Default.BarCodeHeight;
            BarCodeScale = Properties.Settings.Default.BarCodeScale;
            BarCodePosX = Properties.Settings.Default.BarCodePosX;
            BarCodePosY = Properties.Settings.Default.BarCodePosY;
            BarCodeRarefaction = Properties.Settings.Default.BarCodeRarefaction;
            BarCodeType = Properties.Settings.Default.BarCodeType;
            PrinterName = Properties.Settings.Default.PrinterName;
          
        }

        public void Save ()
        {
            Properties.Settings.Default.BarCodeHeight=BarCodeHeight;
            Properties.Settings.Default.BarCodeScale=BarCodeScale;
            Properties.Settings.Default.BarCodePosX=BarCodePosX;
            Properties.Settings.Default.BarCodePosY=BarCodePosY;
            Properties.Settings.Default.BarCodeRarefaction=BarCodeRarefaction;
            Properties.Settings.Default.BarCodeType=BarCodeType;
            Properties.Settings.Default.PrinterName=PrinterName;
            Properties.Settings.Default.Save();
        }
        
    }

    //public struct BCSettings
    //{
    //        public int scale;
    //        public int height;
    //        public int rotate;
    //}

}
