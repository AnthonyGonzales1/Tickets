namespace Tickets.UI.Registros
{
    partial class ClienteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClienteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DeudaTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClienteId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deuda";
            // 
            // ClienteIdNumericUpDown
            // 
            this.ClienteIdNumericUpDown.Location = new System.Drawing.Point(84, 21);
            this.ClienteIdNumericUpDown.Name = "ClienteIdNumericUpDown";
            this.ClienteIdNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.ClienteIdNumericUpDown.TabIndex = 4;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(84, 58);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(157, 20);
            this.NombresTextBox.TabIndex = 5;
            this.NombresTextBox.TextChanged += new System.EventHandler(this.NombresTextBox_TextChanged);
            this.NombresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombresTextBox_KeyPress);
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(84, 97);
            this.TelefonoMaskedTextBox.Mask = "000-000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(77, 20);
            this.TelefonoMaskedTextBox.TabIndex = 6;
            this.TelefonoMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TelefonoMaskedTextBox_MaskInputRejected);
            this.TelefonoMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoMaskedTextBox_KeyPress);
            // 
            // DeudaTextBox
            // 
            this.DeudaTextBox.Location = new System.Drawing.Point(84, 132);
            this.DeudaTextBox.Name = "DeudaTextBox";
            this.DeudaTextBox.ReadOnly = true;
            this.DeudaTextBox.Size = new System.Drawing.Size(77, 20);
            this.DeudaTextBox.TabIndex = 7;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Location = new System.Drawing.Point(206, 184);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(67, 23);
            this.EliminarButton.TabIndex = 46;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Location = new System.Drawing.Point(111, 184);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(73, 23);
            this.GuardarButton.TabIndex = 45;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NuevoButton.Location = new System.Drawing.Point(21, 184);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(67, 23);
            this.NuevoButton.TabIndex = 44;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarButton.Location = new System.Drawing.Point(152, 18);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(89, 23);
            this.BuscarButton.TabIndex = 43;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tickets.Properties.Resources.tickets_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(294, 219);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DeudaTextBox);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.ClienteIdNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ClienteIdNumericUpDown;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.TextBox DeudaTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}