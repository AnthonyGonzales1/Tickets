namespace Tickets.UI.Registros
{
    partial class UsuarioForm
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
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Location = new System.Drawing.Point(213, 184);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(67, 23);
            this.EliminarButton.TabIndex = 58;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Location = new System.Drawing.Point(118, 184);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(73, 23);
            this.GuardarButton.TabIndex = 57;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NuevoButton.Location = new System.Drawing.Point(28, 184);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(67, 23);
            this.NuevoButton.TabIndex = 56;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarButton.Location = new System.Drawing.Point(159, 18);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(89, 23);
            this.BuscarButton.TabIndex = 55;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(91, 132);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClaveTextBox.TabIndex = 54;
            this.ClaveTextBox.TextChanged += new System.EventHandler(this.ClaveTextBox_TextChanged);
            this.ClaveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClaveTextBox_KeyPress);
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(91, 58);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(157, 20);
            this.NombresTextBox.TabIndex = 52;
            this.NombresTextBox.TextChanged += new System.EventHandler(this.NombresTextBox_TextChanged);
            this.NombresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombresTextBox_KeyPress);
            // 
            // UsuarioIdNumericUpDown
            // 
            this.UsuarioIdNumericUpDown.Location = new System.Drawing.Point(91, 21);
            this.UsuarioIdNumericUpDown.Name = "UsuarioIdNumericUpDown";
            this.UsuarioIdNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.UsuarioIdNumericUpDown.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "UsuarioId";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(91, 97);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(157, 20);
            this.EmailTextBox.TabIndex = 59;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tickets.Properties.Resources.Tickets_icon__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(305, 225);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.UsuarioIdNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UsuarioForm";
            this.Text = "UsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.NumericUpDown UsuarioIdNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}