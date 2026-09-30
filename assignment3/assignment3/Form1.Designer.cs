namespace assignment3
{
    partial class sacda
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
            System.Windows.Forms.Label xamd;
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.lblpreviousreading = new System.Windows.Forms.Label();
            this.lblcurrent = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Label();
            this.anfac = new System.Windows.Forms.Label();
            this.sahro = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblusage = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            xamd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(548, 12);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(100, 20);
            this.txtcustomer.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(548, 60);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(100, 20);
            this.txtprevious.TabIndex = 2;
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(548, 116);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(100, 20);
            this.txtcurrent.TabIndex = 3;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(548, 185);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(100, 20);
            this.txtunitprice.TabIndex = 4;
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.Location = new System.Drawing.Point(135, 19);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(106, 13);
            this.lblcustomer.TabIndex = 5;
            this.lblcustomer.Text = "enter customer name";
            // 
            // lblpreviousreading
            // 
            this.lblpreviousreading.AutoSize = true;
            this.lblpreviousreading.Location = new System.Drawing.Point(135, 60);
            this.lblpreviousreading.Name = "lblpreviousreading";
            this.lblpreviousreading.Size = new System.Drawing.Size(112, 13);
            this.lblpreviousreading.TabIndex = 6;
            this.lblpreviousreading.Text = "enter previous reading";
            // 
            // lblcurrent
            // 
            this.lblcurrent.AutoSize = true;
            this.lblcurrent.Location = new System.Drawing.Point(135, 100);
            this.lblcurrent.Name = "lblcurrent";
            this.lblcurrent.Size = new System.Drawing.Size(105, 13);
            this.lblcurrent.TabIndex = 7;
            this.lblcurrent.Text = "enter current reading";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(135, 142);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(110, 13);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "enter price per unit ($)";
            // 
            // btncalculate
            // 
            this.btncalculate.AutoSize = true;
            this.btncalculate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(337, 135);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(110, 20);
            this.btncalculate.TabIndex = 9;
            this.btncalculate.Text = "calculate Bill";
            this.btncalculate.Click += new System.EventHandler(this.label5_Click);
            // 
            // anfac
            // 
            this.anfac.AutoSize = true;
            this.anfac.Location = new System.Drawing.Point(126, 205);
            this.anfac.Name = "anfac";
            this.anfac.Size = new System.Drawing.Size(114, 13);
            this.anfac.TabIndex = 10;
            this.anfac.Text = "electricity usage (units)";
            this.anfac.Click += new System.EventHandler(this.label1_Click);
            // 
            // sahro
            // 
            this.sahro.AutoSize = true;
            this.sahro.Location = new System.Drawing.Point(154, 249);
            this.sahro.Name = "sahro";
            this.sahro.Size = new System.Drawing.Size(86, 13);
            this.sahro.TabIndex = 16;
            this.sahro.Text = "Tax amount (7%)";
            this.sahro.Click += new System.EventHandler(this.lbltax_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(107, 294);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(170, 13);
            this.lbltotal.TabIndex = 17;
            this.lbltotal.Text = "Total bill including  $5 fixed charge";
            // 
            // lblusage
            // 
            this.lblusage.AutoSize = true;
            this.lblusage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblusage.Location = new System.Drawing.Point(302, 205);
            this.lblusage.Name = "lblusage";
            this.lblusage.Size = new System.Drawing.Size(120, 15);
            this.lblusage.TabIndex = 18;
            this.lblusage.Text = "                                     ";
            this.lblusage.Click += new System.EventHandler(this.lblusage_Click);
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Location = new System.Drawing.Point(695, 342);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(0, 13);
            this.lbltax.TabIndex = 19;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblamount.Location = new System.Drawing.Point(281, 247);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(141, 15);
            this.lblamount.TabIndex = 20;
            this.lblamount.Text = "                                            ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(436, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // xamd
            // 
            xamd.AutoSize = true;
            xamd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            xamd.Location = new System.Drawing.Point(341, 294);
            xamd.Name = "xamd";
            xamd.Size = new System.Drawing.Size(63, 15);
            xamd.TabIndex = 22;
            xamd.Text = "                  ";
            xamd.Click += new System.EventHandler(this.label2_Click);
            // 
            // sacda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(756, 427);
            this.Controls.Add(xamd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.lblusage);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.sahro);
            this.Controls.Add(this.anfac);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblcurrent);
            this.Controls.Add(this.lblpreviousreading);
            this.Controls.Add(this.lblcustomer);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.txtcustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sacda";
            this.Text = "                                                                                 " +
    "                                                         ";
            this.Load += new System.EventHandler(this.lbltotal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.Label lblpreviousreading;
        private System.Windows.Forms.Label lblcurrent;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label btncalculate;
        private System.Windows.Forms.Label anfac;
        private System.Windows.Forms.Label sahro;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblusage;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label label1;
    }
}

