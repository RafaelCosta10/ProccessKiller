namespace ProccessKiller
{
    partial class frmKill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotherFuckers = new System.Windows.Forms.TextBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMotherFuckers);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MFs to Kill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Killing this Proccess:";
            // 
            // txtMotherFuckers
            // 
            this.txtMotherFuckers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotherFuckers.Location = new System.Drawing.Point(7, 54);
            this.txtMotherFuckers.Multiline = true;
            this.txtMotherFuckers.Name = "txtMotherFuckers";
            this.txtMotherFuckers.Size = new System.Drawing.Size(507, 86);
            this.txtMotherFuckers.TabIndex = 0;
            this.txtMotherFuckers.Text = "Microsoft.VisualStudio.Web.Host\r\nMicrosoft.VsHub.Server.HttpHost\r\niisexpress\r\niis" +
    "expresstray";
            // 
            // btnKill
            // 
            this.btnKill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKill.Location = new System.Drawing.Point(435, 218);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(97, 23);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "Kill those MFs!";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Visible = false;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // frmKill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 253);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKill";
            this.Text = "Process Killer";
            this.Load += new System.EventHandler(this.frmKill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotherFuckers;
        private System.Windows.Forms.Button btnKill;
    }
}

