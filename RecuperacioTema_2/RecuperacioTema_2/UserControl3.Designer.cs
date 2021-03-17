namespace RecuperacioTema_2
{
    partial class UserControl3
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pB_primerProducto = new System.Windows.Forms.PictureBox();
            this.tB_primerProducto = new System.Windows.Forms.TextBox();
            this.tB_qtyPrimer = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tB_pricePrimer = new System.Windows.Forms.TextBox();
            this.tB_totalPrimer = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tB_sumaTOTAL = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderNumberLB = new System.Windows.Forms.Label();
            this.orderDateLB = new System.Windows.Forms.Label();
            this.requDateLB = new System.Windows.Forms.Label();
            this.shhipDateLB = new System.Windows.Forms.Label();
            this.statusLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB_primerProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_primerProducto
            // 
            this.pB_primerProducto.Location = new System.Drawing.Point(27, 144);
            this.pB_primerProducto.Name = "pB_primerProducto";
            this.pB_primerProducto.Size = new System.Drawing.Size(65, 69);
            this.pB_primerProducto.TabIndex = 0;
            this.pB_primerProducto.TabStop = false;
            // 
            // tB_primerProducto
            // 
            this.tB_primerProducto.Location = new System.Drawing.Point(116, 170);
            this.tB_primerProducto.Name = "tB_primerProducto";
            this.tB_primerProducto.Size = new System.Drawing.Size(242, 20);
            this.tB_primerProducto.TabIndex = 2;
            // 
            // tB_qtyPrimer
            // 
            this.tB_qtyPrimer.Location = new System.Drawing.Point(406, 170);
            this.tB_qtyPrimer.Name = "tB_qtyPrimer";
            this.tB_qtyPrimer.Size = new System.Drawing.Size(100, 20);
            this.tB_qtyPrimer.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tB_pricePrimer
            // 
            this.tB_pricePrimer.Location = new System.Drawing.Point(512, 170);
            this.tB_pricePrimer.Name = "tB_pricePrimer";
            this.tB_pricePrimer.Size = new System.Drawing.Size(100, 20);
            this.tB_pricePrimer.TabIndex = 7;
            // 
            // tB_totalPrimer
            // 
            this.tB_totalPrimer.Location = new System.Drawing.Point(687, 170);
            this.tB_totalPrimer.Name = "tB_totalPrimer";
            this.tB_totalPrimer.Size = new System.Drawing.Size(70, 20);
            this.tB_totalPrimer.TabIndex = 9;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // tB_sumaTOTAL
            // 
            this.tB_sumaTOTAL.Location = new System.Drawing.Point(687, 501);
            this.tB_sumaTOTAL.Name = "tB_sumaTOTAL";
            this.tB_sumaTOTAL.Size = new System.Drawing.Size(70, 20);
            this.tB_sumaTOTAL.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 243);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(730, 252);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Required Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Shipped Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Status:";
            // 
            // orderNumberLB
            // 
            this.orderNumberLB.AutoSize = true;
            this.orderNumberLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumberLB.Location = new System.Drawing.Point(24, 41);
            this.orderNumberLB.Name = "orderNumberLB";
            this.orderNumberLB.Size = new System.Drawing.Size(0, 17);
            this.orderNumberLB.TabIndex = 19;
            // 
            // orderDateLB
            // 
            this.orderDateLB.AutoSize = true;
            this.orderDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateLB.Location = new System.Drawing.Point(143, 41);
            this.orderDateLB.Name = "orderDateLB";
            this.orderDateLB.Size = new System.Drawing.Size(0, 17);
            this.orderDateLB.TabIndex = 20;
            // 
            // requDateLB
            // 
            this.requDateLB.AutoSize = true;
            this.requDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requDateLB.Location = new System.Drawing.Point(254, 41);
            this.requDateLB.Name = "requDateLB";
            this.requDateLB.Size = new System.Drawing.Size(0, 17);
            this.requDateLB.TabIndex = 21;
            // 
            // shhipDateLB
            // 
            this.shhipDateLB.AutoSize = true;
            this.shhipDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shhipDateLB.Location = new System.Drawing.Point(403, 41);
            this.shhipDateLB.Name = "shhipDateLB";
            this.shhipDateLB.Size = new System.Drawing.Size(0, 17);
            this.shhipDateLB.TabIndex = 22;
            // 
            // statusLB
            // 
            this.statusLB.AutoSize = true;
            this.statusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLB.Location = new System.Drawing.Point(563, 41);
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(0, 17);
            this.statusLB.TabIndex = 23;
            this.statusLB.Click += new System.EventHandler(this.statusLB_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusLB);
            this.Controls.Add(this.shhipDateLB);
            this.Controls.Add(this.requDateLB);
            this.Controls.Add(this.orderDateLB);
            this.Controls.Add(this.orderNumberLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tB_sumaTOTAL);
            this.Controls.Add(this.tB_totalPrimer);
            this.Controls.Add(this.tB_pricePrimer);
            this.Controls.Add(this.tB_qtyPrimer);
            this.Controls.Add(this.tB_primerProducto);
            this.Controls.Add(this.pB_primerProducto);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(784, 559);
            ((System.ComponentModel.ISupportInitialize)(this.pB_primerProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_primerProducto;
        private System.Windows.Forms.TextBox tB_primerProducto;
        private System.Windows.Forms.TextBox tB_qtyPrimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tB_pricePrimer;
        private System.Windows.Forms.TextBox tB_totalPrimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox tB_sumaTOTAL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label orderNumberLB;
        private System.Windows.Forms.Label orderDateLB;
        private System.Windows.Forms.Label requDateLB;
        private System.Windows.Forms.Label shhipDateLB;
        private System.Windows.Forms.Label statusLB;
    }
}
