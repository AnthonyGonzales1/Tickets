namespace Tickets.UI.Registros
{
    partial class TipoTicketForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.LugarTextBox = new System.Windows.Forms.TextBox();
            this.TipoTicketIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TipoTicketIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Fecha";
            // 
            // LugarTextBox
            // 
            this.LugarTextBox.Location = new System.Drawing.Point(73, 101);
            this.LugarTextBox.Name = "LugarTextBox";
            this.LugarTextBox.Size = new System.Drawing.Size(171, 20);
            this.LugarTextBox.TabIndex = 72;
            this.LugarTextBox.TextChanged += new System.EventHandler(this.LugarTextBox_TextChanged);
            this.LugarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LugarTextBox_KeyPress);
            // 
            // TipoTicketIdNumericUpDown
            // 
            this.TipoTicketIdNumericUpDown.Location = new System.Drawing.Point(97, 22);
            this.TipoTicketIdNumericUpDown.Name = "TipoTicketIdNumericUpDown";
            this.TipoTicketIdNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.TipoTicketIdNumericUpDown.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Lugar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "TipoTicketId";
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Location = new System.Drawing.Point(228, 187);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(67, 23);
            this.EliminarButton.TabIndex = 65;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Location = new System.Drawing.Point(128, 187);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(73, 23);
            this.GuardarButton.TabIndex = 64;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NuevoButton.Location = new System.Drawing.Point(36, 187);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(67, 23);
            this.NuevoButton.TabIndex = 63;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarButton.Location = new System.Drawing.Point(155, 19);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(89, 23);
            this.BuscarButton.TabIndex = 62;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(102, 60);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(142, 20);
            this.DescripcionTextBox.TabIndex = 76;
            this.DescripcionTextBox.TextChanged += new System.EventHandler(this.DescripcionTextBox_TextChanged);
            this.DescripcionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionTextBox_KeyPress);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(73, 138);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(86, 20);
            this.FechaDateTimePicker.TabIndex = 78;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // TipoTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tickets.Properties.Resources.Tickets_icon__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(324, 228);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LugarTextBox);
            this.Controls.Add(this.TipoTicketIdNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.DoubleBuffered = true;
            this.Name = "TipoTicketForm";
            this.Text = "TipoTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.TipoTicketIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LugarTextBox;
        private System.Windows.Forms.NumericUpDown TipoTicketIdNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}