﻿namespace Tickets.UI.Consultas
{
    partial class ClienteConsult
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
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.ClienteConsultDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.Criteriolabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteConsultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonImprimir.Location = new System.Drawing.Point(13, 401);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(87, 23);
            this.buttonImprimir.TabIndex = 31;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // ClienteConsultDataGridView
            // 
            this.ClienteConsultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteConsultDataGridView.Location = new System.Drawing.Point(13, 39);
            this.ClienteConsultDataGridView.Name = "ClienteConsultDataGridView";
            this.ClienteConsultDataGridView.Size = new System.Drawing.Size(605, 344);
            this.ClienteConsultDataGridView.TabIndex = 30;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBuscar.Location = new System.Drawing.Point(530, 10);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(88, 23);
            this.buttonBuscar.TabIndex = 29;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(293, 12);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(226, 20);
            this.CriterioTextBox.TabIndex = 28;
            // 
            // Criteriolabel
            // 
            this.Criteriolabel.AutoSize = true;
            this.Criteriolabel.Location = new System.Drawing.Point(248, 19);
            this.Criteriolabel.Name = "Criteriolabel";
            this.Criteriolabel.Size = new System.Drawing.Size(39, 13);
            this.Criteriolabel.TabIndex = 27;
            this.Criteriolabel.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "ClienteId",
            "Nombres",
            "Telefono",
            "Deuda"});
            this.FiltroComboBox.Location = new System.Drawing.Point(45, 12);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(197, 21);
            this.FiltroComboBox.TabIndex = 26;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Filtro";
            // 
            // ClienteConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 438);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.ClienteConsultDataGridView);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.Criteriolabel);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ClienteConsult";
            this.Text = "ClienteConsult";
            ((System.ComponentModel.ISupportInitialize)(this.ClienteConsultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.DataGridView ClienteConsultDataGridView;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label Criteriolabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
    }
}