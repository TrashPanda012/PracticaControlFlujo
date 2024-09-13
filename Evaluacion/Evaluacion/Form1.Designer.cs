namespace Evaluacion
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbNombresEst = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombresEst = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbEvaluar = new System.Windows.Forms.GroupBox();
            this.lbEvaluacion = new System.Windows.Forms.ListBox();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.gbNombresEst.SuspendLayout();
            this.gbEvaluar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(146, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del estudiante:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(187, 64);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(514, 22);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // gbNombresEst
            // 
            this.gbNombresEst.Controls.Add(this.label1);
            this.gbNombresEst.Controls.Add(this.lbNombresEst);
            this.gbNombresEst.Location = new System.Drawing.Point(38, 132);
            this.gbNombresEst.Name = "gbNombresEst";
            this.gbNombresEst.Size = new System.Drawing.Size(309, 274);
            this.gbNombresEst.TabIndex = 2;
            this.gbNombresEst.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres Agregados:";
            // 
            // lbNombresEst
            // 
            this.lbNombresEst.FormattingEnabled = true;
            this.lbNombresEst.ItemHeight = 16;
            this.lbNombresEst.Location = new System.Drawing.Point(6, 50);
            this.lbNombresEst.Name = "lbNombresEst";
            this.lbNombresEst.Size = new System.Drawing.Size(297, 212);
            this.lbNombresEst.TabIndex = 0;
            this.lbNombresEst.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(707, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 38);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbEvaluar
            // 
            this.gbEvaluar.Controls.Add(this.lbEvaluacion);
            this.gbEvaluar.Controls.Add(this.lblEvaluacion);
            this.gbEvaluar.Location = new System.Drawing.Point(400, 132);
            this.gbEvaluar.Name = "gbEvaluar";
            this.gbEvaluar.Size = new System.Drawing.Size(353, 274);
            this.gbEvaluar.TabIndex = 4;
            this.gbEvaluar.TabStop = false;
            // 
            // lbEvaluacion
            // 
            this.lbEvaluacion.FormattingEnabled = true;
            this.lbEvaluacion.ItemHeight = 16;
            this.lbEvaluacion.Location = new System.Drawing.Point(32, 50);
            this.lbEvaluacion.Name = "lbEvaluacion";
            this.lbEvaluacion.Size = new System.Drawing.Size(285, 212);
            this.lbEvaluacion.TabIndex = 3;
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluacion.Location = new System.Drawing.Point(28, 22);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(223, 16);
            this.lblEvaluacion.TabIndex = 2;
            this.lblEvaluacion.Text = "Nombres con más de 25 caracteres:";
            this.lblEvaluacion.Click += new System.EventHandler(this.lblEvaluacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEvaluar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbNombresEst);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbNombresEst.ResumeLayout(false);
            this.gbNombresEst.PerformLayout();
            this.gbEvaluar.ResumeLayout(false);
            this.gbEvaluar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbNombresEst;
        private System.Windows.Forms.ListBox lbNombresEst;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEvaluar;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.ListBox lbEvaluacion;
    }
}

