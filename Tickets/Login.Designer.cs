namespace Tickets
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(70, 46);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(116, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // IngresarButton
            // 
            this.IngresarButton.Location = new System.Drawing.Point(22, 115);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(75, 23);
            this.IngresarButton.TabIndex = 5;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(122, 115);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(69, 72);
            this.ClavetextBox.MaxLength = 29;
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.Size = new System.Drawing.Size(116, 20);
            this.ClavetextBox.TabIndex = 10;
            this.ClavetextBox.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tickets.Properties.Resources.tickets_icon;
            this.ClientSize = new System.Drawing.Size(225, 161);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.TextBox ClavetextBox;
    }
}

