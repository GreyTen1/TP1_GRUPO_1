namespace TP1_GRUPO_1
{
    partial class FormEj1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNombres1 = new System.Windows.Forms.ListBox();
            this.lbNombres2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(121, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese un nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(340, 78);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(389, 22);
            this.tbxNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(736, 75);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNombres1
            // 
            this.lbNombres1.FormattingEnabled = true;
            this.lbNombres1.ItemHeight = 16;
            this.lbNombres1.Location = new System.Drawing.Point(127, 156);
            this.lbNombres1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNombres1.Name = "lbNombres1";
            this.lbNombres1.Size = new System.Drawing.Size(280, 324);
            this.lbNombres1.TabIndex = 3;
            // 
            // lbNombres2
            // 
            this.lbNombres2.FormattingEnabled = true;
            this.lbNombres2.ItemHeight = 16;
            this.lbNombres2.Location = new System.Drawing.Point(624, 156);
            this.lbNombres2.Name = "lbNombres2";
            this.lbNombres2.Size = new System.Drawing.Size(280, 324);
            this.lbNombres2.TabIndex = 4;
            this.lbNombres2.SelectedIndexChanged += new System.EventHandler(this.lbNombres2_SelectedIndexChanged);
            // 
            // FormEj1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbNombres2);
            this.Controls.Add(this.lbNombres1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEj1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEj1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEj1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNombres1;
        private System.Windows.Forms.ListBox lbNombres2;
    }
}