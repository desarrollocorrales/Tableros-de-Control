namespace RecolectorDeDatos.GUIs
{
    partial class Frm_Configuracion
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
            this.label1 = new System.Windows.Forms.Label();
            this.gpMicrosip = new System.Windows.Forms.GroupBox();
            this.numbPuertoFB = new System.Windows.Forms.NumericUpDown();
            this.txbPasswordFB = new System.Windows.Forms.TextBox();
            this.txbUsuarioFB = new System.Windows.Forms.TextBox();
            this.txbBaseDeDatosFB = new System.Windows.Forms.TextBox();
            this.txbServidorFB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numbPuertoMySQL = new System.Windows.Forms.NumericUpDown();
            this.txbPasswordMySQL = new System.Windows.Forms.TextBox();
            this.txbUsuarioMySQL = new System.Windows.Forms.TextBox();
            this.txbBaseDeDatosMySQL = new System.Windows.Forms.TextBox();
            this.txbServidorMySQL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpMicrosip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbPuertoFB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbPuertoMySQL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONFIGURACIÓN";
            // 
            // gpMicrosip
            // 
            this.gpMicrosip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpMicrosip.Controls.Add(this.numbPuertoFB);
            this.gpMicrosip.Controls.Add(this.txbPasswordFB);
            this.gpMicrosip.Controls.Add(this.txbUsuarioFB);
            this.gpMicrosip.Controls.Add(this.txbBaseDeDatosFB);
            this.gpMicrosip.Controls.Add(this.txbServidorFB);
            this.gpMicrosip.Controls.Add(this.label6);
            this.gpMicrosip.Controls.Add(this.label5);
            this.gpMicrosip.Controls.Add(this.label4);
            this.gpMicrosip.Controls.Add(this.label3);
            this.gpMicrosip.Controls.Add(this.label2);
            this.gpMicrosip.Location = new System.Drawing.Point(12, 45);
            this.gpMicrosip.Name = "gpMicrosip";
            this.gpMicrosip.Size = new System.Drawing.Size(740, 188);
            this.gpMicrosip.TabIndex = 1;
            this.gpMicrosip.TabStop = false;
            this.gpMicrosip.Text = "Configuración Microsip";
            // 
            // numbPuertoFB
            // 
            this.numbPuertoFB.Location = new System.Drawing.Point(237, 130);
            this.numbPuertoFB.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numbPuertoFB.Name = "numbPuertoFB";
            this.numbPuertoFB.Size = new System.Drawing.Size(84, 26);
            this.numbPuertoFB.TabIndex = 10;
            // 
            // txbPasswordFB
            // 
            this.txbPasswordFB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPasswordFB.Location = new System.Drawing.Point(482, 97);
            this.txbPasswordFB.Name = "txbPasswordFB";
            this.txbPasswordFB.PasswordChar = '*';
            this.txbPasswordFB.Size = new System.Drawing.Size(135, 26);
            this.txbPasswordFB.TabIndex = 8;
            // 
            // txbUsuarioFB
            // 
            this.txbUsuarioFB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbUsuarioFB.Location = new System.Drawing.Point(237, 97);
            this.txbUsuarioFB.Name = "txbUsuarioFB";
            this.txbUsuarioFB.Size = new System.Drawing.Size(146, 26);
            this.txbUsuarioFB.TabIndex = 7;
            // 
            // txbBaseDeDatosFB
            // 
            this.txbBaseDeDatosFB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbBaseDeDatosFB.Location = new System.Drawing.Point(237, 65);
            this.txbBaseDeDatosFB.Name = "txbBaseDeDatosFB";
            this.txbBaseDeDatosFB.Size = new System.Drawing.Size(380, 26);
            this.txbBaseDeDatosFB.TabIndex = 6;
            // 
            // txbServidorFB
            // 
            this.txbServidorFB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbServidorFB.Location = new System.Drawing.Point(237, 33);
            this.txbServidorFB.Name = "txbServidorFB";
            this.txbServidorFB.Size = new System.Drawing.Size(380, 26);
            this.txbServidorFB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Puerto:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ruta de base de datos:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Servidor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numbPuertoMySQL);
            this.groupBox1.Controls.Add(this.txbPasswordMySQL);
            this.groupBox1.Controls.Add(this.txbUsuarioMySQL);
            this.groupBox1.Controls.Add(this.txbBaseDeDatosMySQL);
            this.groupBox1.Controls.Add(this.txbServidorMySQL);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración MySQL";
            // 
            // numbPuertoMySQL
            // 
            this.numbPuertoMySQL.Location = new System.Drawing.Point(237, 130);
            this.numbPuertoMySQL.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numbPuertoMySQL.Name = "numbPuertoMySQL";
            this.numbPuertoMySQL.Size = new System.Drawing.Size(84, 26);
            this.numbPuertoMySQL.TabIndex = 19;
            // 
            // txbPasswordMySQL
            // 
            this.txbPasswordMySQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPasswordMySQL.Location = new System.Drawing.Point(482, 97);
            this.txbPasswordMySQL.Name = "txbPasswordMySQL";
            this.txbPasswordMySQL.PasswordChar = '*';
            this.txbPasswordMySQL.Size = new System.Drawing.Size(135, 26);
            this.txbPasswordMySQL.TabIndex = 18;
            // 
            // txbUsuarioMySQL
            // 
            this.txbUsuarioMySQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbUsuarioMySQL.Location = new System.Drawing.Point(237, 97);
            this.txbUsuarioMySQL.Name = "txbUsuarioMySQL";
            this.txbUsuarioMySQL.Size = new System.Drawing.Size(146, 26);
            this.txbUsuarioMySQL.TabIndex = 17;
            // 
            // txbBaseDeDatosMySQL
            // 
            this.txbBaseDeDatosMySQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbBaseDeDatosMySQL.Location = new System.Drawing.Point(237, 65);
            this.txbBaseDeDatosMySQL.Name = "txbBaseDeDatosMySQL";
            this.txbBaseDeDatosMySQL.Size = new System.Drawing.Size(380, 26);
            this.txbBaseDeDatosMySQL.TabIndex = 16;
            // 
            // txbServidorMySQL
            // 
            this.txbServidorMySQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbServidorMySQL.Location = new System.Drawing.Point(237, 33);
            this.txbServidorMySQL.Name = "txbServidorMySQL";
            this.txbServidorMySQL.Size = new System.Drawing.Size(380, 26);
            this.txbServidorMySQL.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Puerto:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Contraseña:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Usuario:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Base de datos:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Servidor:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(330, 439);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 31);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Frm_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 482);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpMicrosip);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(780, 520);
            this.MinimumSize = new System.Drawing.Size(780, 520);
            this.Name = "Frm_Configuracion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CONFIGURAR";
            this.Load += new System.EventHandler(this.Frm_Configuracion_Load);
            this.gpMicrosip.ResumeLayout(false);
            this.gpMicrosip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbPuertoFB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbPuertoMySQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpMicrosip;
        private System.Windows.Forms.TextBox txbPasswordFB;
        private System.Windows.Forms.TextBox txbUsuarioFB;
        private System.Windows.Forms.TextBox txbBaseDeDatosFB;
        private System.Windows.Forms.TextBox txbServidorFB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbPasswordMySQL;
        private System.Windows.Forms.TextBox txbUsuarioMySQL;
        private System.Windows.Forms.TextBox txbBaseDeDatosMySQL;
        private System.Windows.Forms.TextBox txbServidorMySQL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numbPuertoFB;
        private System.Windows.Forms.NumericUpDown numbPuertoMySQL;
    }
}