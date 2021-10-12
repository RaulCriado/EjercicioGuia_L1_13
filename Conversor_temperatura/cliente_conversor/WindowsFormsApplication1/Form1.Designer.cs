namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.temperaturaBox = new System.Windows.Forms.TextBox();
            this.btn_calculo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FtoC = new System.Windows.Forms.RadioButton();
            this.CtoF = new System.Windows.Forms.RadioButton();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conversor de Temperatura";
            // 
            // temperaturaBox
            // 
            this.temperaturaBox.Location = new System.Drawing.Point(157, 31);
            this.temperaturaBox.Name = "temperaturaBox";
            this.temperaturaBox.Size = new System.Drawing.Size(136, 20);
            this.temperaturaBox.TabIndex = 3;
            // 
            // btn_calculo
            // 
            this.btn_calculo.Location = new System.Drawing.Point(157, 114);
            this.btn_calculo.Name = "btn_calculo";
            this.btn_calculo.Size = new System.Drawing.Size(75, 23);
            this.btn_calculo.TabIndex = 5;
            this.btn_calculo.Text = "Enviar";
            this.btn_calculo.UseVisualStyleBackColor = true;
            this.btn_calculo.Click += new System.EventHandler(this.btn_calculo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FtoC);
            this.groupBox1.Controls.Add(this.CtoF);
            this.groupBox1.Controls.Add(this.btn_calculo);
            this.groupBox1.Controls.Add(this.temperaturaBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 282);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Temperatura:";
            // 
            // FtoC
            // 
            this.FtoC.AutoSize = true;
            this.FtoC.Location = new System.Drawing.Point(157, 91);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(129, 17);
            this.FtoC.TabIndex = 7;
            this.FtoC.TabStop = true;
            this.FtoC.Text = "Conversion de ºF a ºC";
            this.FtoC.UseVisualStyleBackColor = true;
            // 
            // CtoF
            // 
            this.CtoF.AutoSize = true;
            this.CtoF.Location = new System.Drawing.Point(157, 68);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(129, 17);
            this.CtoF.TabIndex = 8;
            this.CtoF.TabStop = true;
            this.CtoF.Text = "Conversion de ºC a ºF";
            this.CtoF.UseVisualStyleBackColor = true;
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(12, 76);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(169, 32);
            this.btn_conectar.TabIndex = 9;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(197, 76);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(178, 32);
            this.btn_desconectar.TabIndex = 10;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconcetar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 562);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.btn_desconectar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox temperaturaBox;
        private System.Windows.Forms.Button btn_calculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FtoC;
        private System.Windows.Forms.RadioButton CtoF;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Label label1;
    }
}

