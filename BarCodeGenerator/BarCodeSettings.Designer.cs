namespace BarCodeGenerator
{
    partial class BarCodeSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_Height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Scale = new System.Windows.Forms.TextBox();
            this.text_Rotate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.text_PosX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_PosY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Rarefaction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fld_PrinterName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // text_Height
            // 
            this.text_Height.Location = new System.Drawing.Point(164, 27);
            this.text_Height.Name = "text_Height";
            this.text_Height.Size = new System.Drawing.Size(100, 20);
            this.text_Height.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота штрихкода";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Масштаб";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_Scale
            // 
            this.text_Scale.Location = new System.Drawing.Point(164, 53);
            this.text_Scale.Name = "text_Scale";
            this.text_Scale.Size = new System.Drawing.Size(100, 20);
            this.text_Scale.TabIndex = 2;
            this.text_Scale.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // text_Rotate
            // 
            this.text_Rotate.Location = new System.Drawing.Point(164, 79);
            this.text_Rotate.Name = "text_Rotate";
            this.text_Rotate.Size = new System.Drawing.Size(100, 20);
            this.text_Rotate.TabIndex = 2;
            this.text_Rotate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поворот";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Location = new System.Drawing.Point(295, 25);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(295, 56);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // text_PosX
            // 
            this.text_PosX.Location = new System.Drawing.Point(164, 106);
            this.text_PosX.Name = "text_PosX";
            this.text_PosX.Size = new System.Drawing.Size(100, 20);
            this.text_PosX.TabIndex = 2;
            this.text_PosX.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Позиционирование по X";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_PosY
            // 
            this.text_PosY.Location = new System.Drawing.Point(164, 132);
            this.text_PosY.Name = "text_PosY";
            this.text_PosY.Size = new System.Drawing.Size(100, 20);
            this.text_PosY.TabIndex = 2;
            this.text_PosY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Позиционирование по Y";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_Rarefaction
            // 
            this.text_Rarefaction.Location = new System.Drawing.Point(164, 158);
            this.text_Rarefaction.Name = "text_Rarefaction";
            this.text_Rarefaction.Size = new System.Drawing.Size(100, 20);
            this.text_Rarefaction.TabIndex = 2;
            this.text_Rarefaction.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Межбуквенное расстояние";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Имя принтера";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // fld_PrinterName
            // 
            this.fld_PrinterName.FormattingEnabled = true;
            this.fld_PrinterName.Location = new System.Drawing.Point(164, 185);
            this.fld_PrinterName.Name = "fld_PrinterName";
            this.fld_PrinterName.Size = new System.Drawing.Size(206, 21);
            this.fld_PrinterName.TabIndex = 5;
            // 
            // BarCodeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 220);
            this.Controls.Add(this.fld_PrinterName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_Rarefaction);
            this.Controls.Add(this.text_PosY);
            this.Controls.Add(this.text_PosX);
            this.Controls.Add(this.text_Rotate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Scale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Height);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarCodeSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.BarCodeSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Scale;
        private System.Windows.Forms.TextBox text_Rotate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox text_PosX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_PosY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_Rarefaction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fld_PrinterName;
    }
}