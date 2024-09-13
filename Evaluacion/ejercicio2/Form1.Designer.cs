namespace ejercicio2
{
    partial class Form1
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
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.gbNombres = new System.Windows.Forms.GroupBox();
            this.gbApellidos = new System.Windows.Forms.GroupBox();
            this.gbEdad = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.ListBox();
            this.lbApellidos = new System.Windows.Forms.ListBox();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbNombres.SuspendLayout();
            this.gbApellidos.SuspendLayout();
            this.gbEdad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(35, 99);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(135, 16);
            this.lblBirthday.TabIndex = 1;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(35, 67);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(67, 16);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(176, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(280, 22);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(176, 64);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(280, 22);
            this.tbLastname.TabIndex = 4;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(176, 99);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(280, 22);
            this.dtpBirthday.TabIndex = 5;
            // 
            // gbNombres
            // 
            this.gbNombres.Controls.Add(this.lbNombres);
            this.gbNombres.Controls.Add(this.lblNombres);
            this.gbNombres.Location = new System.Drawing.Point(38, 171);
            this.gbNombres.Name = "gbNombres";
            this.gbNombres.Size = new System.Drawing.Size(236, 230);
            this.gbNombres.TabIndex = 6;
            this.gbNombres.TabStop = false;
            // 
            // gbApellidos
            // 
            this.gbApellidos.Controls.Add(this.lbApellidos);
            this.gbApellidos.Controls.Add(this.label1);
            this.gbApellidos.Location = new System.Drawing.Point(297, 171);
            this.gbApellidos.Name = "gbApellidos";
            this.gbApellidos.Size = new System.Drawing.Size(233, 230);
            this.gbApellidos.TabIndex = 7;
            this.gbApellidos.TabStop = false;
            // 
            // gbEdad
            // 
            this.gbEdad.Controls.Add(this.lbEdad);
            this.gbEdad.Controls.Add(this.label2);
            this.gbEdad.Location = new System.Drawing.Point(551, 171);
            this.gbEdad.Name = "gbEdad";
            this.gbEdad.Size = new System.Drawing.Size(233, 230);
            this.gbEdad.TabIndex = 8;
            this.gbEdad.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edad:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(7, 33);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(66, 16);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres:";
            // 
            // lbEdad
            // 
            this.lbEdad.FormattingEnabled = true;
            this.lbEdad.ItemHeight = 16;
            this.lbEdad.Location = new System.Drawing.Point(9, 62);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(218, 148);
            this.lbEdad.TabIndex = 1;
            // 
            // lbApellidos
            // 
            this.lbApellidos.FormattingEnabled = true;
            this.lbApellidos.ItemHeight = 16;
            this.lbApellidos.Location = new System.Drawing.Point(9, 62);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(218, 148);
            this.lbApellidos.TabIndex = 1;
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.ItemHeight = 16;
            this.lbNombres.Location = new System.Drawing.Point(10, 62);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(220, 148);
            this.lbNombres.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(522, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 35);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbEdad);
            this.Controls.Add(this.gbApellidos);
            this.Controls.Add(this.gbNombres);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbNombres.ResumeLayout(false);
            this.gbNombres.PerformLayout();
            this.gbApellidos.ResumeLayout(false);
            this.gbApellidos.PerformLayout();
            this.gbEdad.ResumeLayout(false);
            this.gbEdad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.GroupBox gbNombres;
        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.GroupBox gbApellidos;
        private System.Windows.Forms.ListBox lbApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEdad;
        private System.Windows.Forms.ListBox lbEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
    }
}

