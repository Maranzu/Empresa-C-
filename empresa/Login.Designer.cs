namespace empresa
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btningreso = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pbimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.label1.Location = new System.Drawing.Point(179, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.tbUser.Location = new System.Drawing.Point(265, 60);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(133, 21);
            this.tbUser.TabIndex = 1;
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.tbpassword.Location = new System.Drawing.Point(265, 86);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(133, 21);
            this.tbpassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.label2.Location = new System.Drawing.Point(179, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // btningreso
            // 
            this.btningreso.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.btningreso.Location = new System.Drawing.Point(404, 58);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(75, 23);
            this.btningreso.TabIndex = 4;
            this.btningreso.Text = "Acceder";
            this.btningreso.UseVisualStyleBackColor = true;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Cascadia Code Light", 9F);
            this.btnsalir.Location = new System.Drawing.Point(404, 86);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pbimage
            // 
            this.pbimage.Image = ((System.Drawing.Image)(resources.GetObject("pbimage.Image")));
            this.pbimage.Location = new System.Drawing.Point(38, 25);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(136, 109);
            this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbimage.TabIndex = 6;
            this.pbimage.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 178);
            this.Controls.Add(this.pbimage);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btningreso);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btningreso;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.PictureBox pbimage;
    }
}

