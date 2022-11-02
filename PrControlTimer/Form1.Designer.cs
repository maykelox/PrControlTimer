namespace PrControlTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblhora = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.lblb = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(409, 52);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(33, 15);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "Hora";
            this.lblhora.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(409, 100);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(89, 29);
            this.btnplay.TabIndex = 1;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(409, 161);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(89, 27);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.BackColor = System.Drawing.Color.LightCoral;
            this.lblb.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblb.ForeColor = System.Drawing.Color.Red;
            this.lblb.Location = new System.Drawing.Point(138, 130);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(181, 32);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "IncanatoIT";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.BackColor = System.Drawing.Color.LightCoral;
            this.lbla.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbla.Location = new System.Drawing.Point(138, 130);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(181, 32);
            this.lbla.TabIndex = 4;
            this.lbla.Text = "IncanatoIT";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(578, 310);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lbla);
            this.Name = "Form1";
            this.Text = ".:. Control Timer .:.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblhora;
        private Button btnplay;
        private Button btnstop;
        private Label lblb;
        private Label lbla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}