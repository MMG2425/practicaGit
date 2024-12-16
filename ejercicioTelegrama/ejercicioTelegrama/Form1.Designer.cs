namespace ejercicioTelegrama
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
            txtTelegrama = new TextBox();
            chkUrgente = new CheckBox();
            button1 = new Button();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            txtTelegrama.Location = new Point(47, 86);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "textBox1";
            txtTelegrama.Size = new Size(665, 100);
            txtTelegrama.TabIndex = 0;
            // 
            // checkBox2
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(47, 252);
            chkUrgente.Name = "checkBox2";
            chkUrgente.Size = new Size(73, 19);
            chkUrgente.TabIndex = 2;
            chkUrgente.Text = "Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(555, 291);
            button1.Name = "button1";
            button1.Size = new Size(157, 49);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // textBox2
            // 
            txtPrecio.Location = new Point(92, 319);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "textBox2";
            txtPrecio.Size = new Size(122, 23);
            txtPrecio.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 322);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Coste:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(46, 54);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Texto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(button1);
            Controls.Add(chkUrgente);
            Controls.Add(txtTelegrama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelegrama;
        private CheckBox chkUrgente;
        private Button button1;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
    }
}
