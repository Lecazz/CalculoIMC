namespace CalculoIMC
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
            btnpeso = new Label();
            numPeso = new NumericUpDown();
            numAltura = new NumericUpDown();
            btnaltura = new Label();
            btnimc = new Label();
            panel1 = new Panel();
            btnCalcular = new Button();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnpeso
            // 
            btnpeso.AutoSize = true;
            btnpeso.Location = new Point(68, 158);
            btnpeso.Name = "btnpeso";
            btnpeso.Size = new Size(39, 20);
            btnpeso.TabIndex = 0;
            btnpeso.Text = "Peso";
            btnpeso.Click += label1_Click;
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 2;
            numPeso.Location = new Point(68, 200);
            numPeso.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(187, 27);
            numPeso.TabIndex = 1;
            numPeso.TextAlign = HorizontalAlignment.Right;
            numPeso.ValueChanged += numPeso_ValueChanged;
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Location = new Point(68, 292);
            numAltura.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(187, 27);
            numAltura.TabIndex = 2;
            numAltura.TextAlign = HorizontalAlignment.Right;
            numAltura.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // btnaltura
            // 
            btnaltura.AutoSize = true;
            btnaltura.Location = new Point(68, 269);
            btnaltura.Name = "btnaltura";
            btnaltura.Size = new Size(49, 20);
            btnaltura.TabIndex = 3;
            btnaltura.Text = "Altura";
            // 
            // btnimc
            // 
            btnimc.AutoSize = true;
            btnimc.Location = new Point(110, 109);
            btnimc.Name = "btnimc";
            btnimc.Size = new Size(110, 20);
            btnimc.TabIndex = 4;
            btnimc.Text = "Calculo do IMC";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(btnimc);
            panel1.Controls.Add(btnpeso);
            panel1.Controls.Add(btnaltura);
            panel1.Controls.Add(numPeso);
            panel1.Controls.Add(numAltura);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 449);
            panel1.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(178, 353);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(77, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Microsoft YaHei", 60F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(359, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(119, 133);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "0";
            lblResultado.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnpeso;
        private NumericUpDown numPeso;
        private NumericUpDown numAltura;
        private Label btnaltura;
        private Label btnimc;
        private Panel panel1;
        private Button btnCalcular;
        private Label lblResultado;
    }
}