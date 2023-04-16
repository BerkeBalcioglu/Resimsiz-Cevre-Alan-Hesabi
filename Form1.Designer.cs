namespace Kullanıcıdan_alınan_değerlerle_uzunlukl_hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kkenar=new Label();
            ukenar=new Label();
            cevre1=new Label();
            textBoxu=new TextBox();
            textBoxk=new TextBox();
            button1=new Button();
            alan1=new Label();
            SuspendLayout();
            // 
            // kkenar
            // 
            kkenar.AutoSize=true;
            kkenar.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kkenar.Location=new Point(21, 32);
            kkenar.Name="kkenar";
            kkenar.Size=new Size(82, 21);
            kkenar.TabIndex=0;
            kkenar.Text="Kısa Kenar";
            kkenar.Click+=label1_Click;
            // 
            // ukenar
            // 
            ukenar.AutoSize=true;
            ukenar.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ukenar.Location=new Point(232, 32);
            ukenar.Name="ukenar";
            ukenar.Size=new Size(90, 21);
            ukenar.TabIndex=1;
            ukenar.Text="Uzun Kenar";
            ukenar.Click+=ukenar_Click;
            // 
            // cevre1
            // 
            cevre1.AutoSize=true;
            cevre1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cevre1.Location=new Point(42, 160);
            cevre1.Name="cevre1";
            cevre1.Size=new Size(57, 21);
            cevre1.TabIndex=2;
            cevre1.Text="Cevre :";
            cevre1.Click+=cevre_Click;
            // 
            // textBoxu
            // 
            textBoxu.Location=new Point(328, 34);
            textBoxu.Name="textBoxu";
            textBoxu.Size=new Size(100, 23);
            textBoxu.TabIndex=3;
            textBoxu.TextChanged+=textBoxu_TextChanged;
            textBoxu.Leave+=textBoxk_Leave;
            // 
            // textBoxk
            // 
            textBoxk.Location=new Point(109, 34);
            textBoxk.Name="textBoxk";
            textBoxk.Size=new Size(100, 23);
            textBoxk.TabIndex=4;
            textBoxk.TextChanged+=textBoxk_TextChanged;
            textBoxk.Leave+=ukenar_Click;
            // 
            // button1
            // 
            button1.Location=new Point(549, 34);
            button1.Name="button1";
            button1.Size=new Size(101, 32);
            button1.TabIndex=5;
            button1.Text="HESAPLA";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // alan1
            // 
            alan1.AutoSize=true;
            alan1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            alan1.Location=new Point(48, 200);
            alan1.Name="alan1";
            alan1.Size=new Size(48, 21);
            alan1.TabIndex=6;
            alan1.Text="Alan :";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(alan1);
            Controls.Add(button1);
            Controls.Add(textBoxk);
            Controls.Add(textBoxu);
            Controls.Add(cevre1);
            Controls.Add(ukenar);
            Controls.Add(kkenar);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kkenar;
        private Label ukenar;
        private Label cevre1;
        private TextBox textBoxu;
        private TextBox textBoxk;
        private Button button1;
        private Label alan1;
    }
}