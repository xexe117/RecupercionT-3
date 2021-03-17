namespace RecuperacioTema_2
{
    partial class Form1
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
            this.ordersCB = new System.Windows.Forms.ComboBox();
            this.customerCB = new System.Windows.Forms.ComboBox();
            this.ordersVisual1 = new RecuperacioTema_2.ordersVisual();
            this.SuspendLayout();
            // 
            // ordersCB
            // 
            this.ordersCB.FormattingEnabled = true;
            this.ordersCB.Location = new System.Drawing.Point(328, 45);
            this.ordersCB.Name = "ordersCB";
            this.ordersCB.Size = new System.Drawing.Size(121, 21);
            this.ordersCB.TabIndex = 1;
            this.ordersCB.SelectedIndexChanged += new System.EventHandler(this.ordersCB_SelectedIndexChanged);
            // 
            // customerCB
            // 
            this.customerCB.FormattingEnabled = true;
            this.customerCB.Location = new System.Drawing.Point(60, 45);
            this.customerCB.Name = "customerCB";
            this.customerCB.Size = new System.Drawing.Size(219, 21);
            this.customerCB.TabIndex = 4;
            this.customerCB.SelectedIndexChanged += new System.EventHandler(this.customerCB_SelectedIndexChanged_1);
            // 
            // ordersVisual1
            // 
            this.ordersVisual1.Location = new System.Drawing.Point(12, 102);
            this.ordersVisual1.Name = "ordersVisual1";
            this.ordersVisual1.Size = new System.Drawing.Size(850, 556);
            this.ordersVisual1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 739);
            this.Controls.Add(this.ordersVisual1);
            this.Controls.Add(this.customerCB);
            this.Controls.Add(this.ordersCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ordersCB;
        private System.Windows.Forms.ComboBox customerCB;
        private ordersVisual ordersVisual1;
    }
}

