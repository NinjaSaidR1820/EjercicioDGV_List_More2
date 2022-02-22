namespace EjercicioDGV_List_More
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoUsuario_InicioSesion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(148, 85);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(198, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(148, 134);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(198, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // cbTipoUsuario_InicioSesion
            // 
            this.cbTipoUsuario_InicioSesion.FormattingEnabled = true;
            this.cbTipoUsuario_InicioSesion.Location = new System.Drawing.Point(148, 33);
            this.cbTipoUsuario_InicioSesion.Name = "cbTipoUsuario_InicioSesion";
            this.cbTipoUsuario_InicioSesion.Size = new System.Drawing.Size(198, 21);
            this.cbTipoUsuario_InicioSesion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(352, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(127, 219);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(86, 35);
            this.BtnIniciarSesion.TabIndex = 7;
            this.BtnIniciarSesion.Text = "Ingresar";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo de Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(375, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 130);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(557, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoUsuario_InicioSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoUsuario_InicioSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip tpMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

