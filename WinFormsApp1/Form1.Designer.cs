namespace WinFormsApp1
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
            label1 = new Label();
            txtGenerador = new TextBox();
            btnGeneradorSopa = new Button();
            dtgTableroLetras = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgTableroLetras).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 89);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "Generador de sopas de letras:";
            // 
            // txtGenerador
            // 
            txtGenerador.Location = new Point(239, 81);
            txtGenerador.Name = "txtGenerador";
            txtGenerador.Size = new Size(248, 23);
            txtGenerador.TabIndex = 1;
            // 
            // btnGeneradorSopa
            // 
            btnGeneradorSopa.Location = new Point(507, 71);
            btnGeneradorSopa.Name = "btnGeneradorSopa";
            btnGeneradorSopa.Size = new Size(191, 40);
            btnGeneradorSopa.TabIndex = 2;
            btnGeneradorSopa.Text = "Generador Sopa de Letras";
            btnGeneradorSopa.UseVisualStyleBackColor = true;
            // 
            // dtgTableroLetras
            // 
            dtgTableroLetras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTableroLetras.Location = new Point(114, 143);
            dtgTableroLetras.Name = "dtgTableroLetras";
            dtgTableroLetras.Size = new Size(523, 376);
            dtgTableroLetras.TabIndex = 3;
            dtgTableroLetras.CellContentClick += dtgTableroLetras_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 34);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 4;
            label2.Text = "Sopa de letras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 642);
            Controls.Add(label2);
            Controls.Add(dtgTableroLetras);
            Controls.Add(btnGeneradorSopa);
            Controls.Add(txtGenerador);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgTableroLetras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtGenerador;
        private Button btnGeneradorSopa;
        private DataGridView dtgTableroLetras;
        private Label label2;
    }
}
