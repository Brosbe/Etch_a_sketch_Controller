﻿namespace etchASketch
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEtchMode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMouseToggle = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lstPorts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Etch Control:";
            // 
            // lblEtchMode
            // 
            this.lblEtchMode.AutoSize = true;
            this.lblEtchMode.Font = new System.Drawing.Font("Verdana", 20F);
            this.lblEtchMode.ForeColor = System.Drawing.Color.Red;
            this.lblEtchMode.Location = new System.Drawing.Point(247, 9);
            this.lblEtchMode.Name = "lblEtchMode";
            this.lblEtchMode.Size = new System.Drawing.Size(51, 32);
            this.lblEtchMode.TabIndex = 1;
            this.lblEtchMode.Tag = "";
            this.lblEtchMode.Text = "off";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20F);
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 32);
            this.label3.TabIndex = 2;
            this.label3.Tag = "";
            this.label3.Text = "Mouse Toggle:";
            // 
            // lblMouseToggle
            // 
            this.lblMouseToggle.AutoSize = true;
            this.lblMouseToggle.Font = new System.Drawing.Font("Verdana", 20F);
            this.lblMouseToggle.ForeColor = System.Drawing.Color.Red;
            this.lblMouseToggle.Location = new System.Drawing.Point(247, 52);
            this.lblMouseToggle.Name = "lblMouseToggle";
            this.lblMouseToggle.Size = new System.Drawing.Size(51, 32);
            this.lblMouseToggle.TabIndex = 3;
            this.lblMouseToggle.Tag = "";
            this.lblMouseToggle.Text = "off";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(382, 120);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "button1";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // lstPorts
            // 
            this.lstPorts.FormattingEnabled = true;
            this.lstPorts.Location = new System.Drawing.Point(383, 24);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(120, 82);
            this.lstPorts.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 181);
            this.Controls.Add(this.lstPorts);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblMouseToggle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEtchMode);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 220);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Etch a sketch controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEtchMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMouseToggle;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lstPorts;
    }
}
