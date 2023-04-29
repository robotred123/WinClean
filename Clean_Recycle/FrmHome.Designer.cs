namespace Clean_Recycle
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.button1 = new System.Windows.Forms.Button();
            this.CleanBtn = new System.Windows.Forms.Button();
            this.lb_IPadd = new System.Windows.Forms.Label();
            this.lb_MAC = new System.Windows.Forms.Label();
            this.lb_Tempertature = new System.Windows.Forms.Label();
            this.lb_NamePC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test KeyBoard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CleanBtn
            // 
            this.CleanBtn.Location = new System.Drawing.Point(124, 173);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(96, 38);
            this.CleanBtn.TabIndex = 1;
            this.CleanBtn.Text = "Clean PC";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // lb_IPadd
            // 
            this.lb_IPadd.AutoSize = true;
            this.lb_IPadd.Location = new System.Drawing.Point(23, 30);
            this.lb_IPadd.Name = "lb_IPadd";
            this.lb_IPadd.Size = new System.Drawing.Size(0, 13);
            this.lb_IPadd.TabIndex = 3;
            // 
            // lb_MAC
            // 
            this.lb_MAC.AutoSize = true;
            this.lb_MAC.Location = new System.Drawing.Point(23, 63);
            this.lb_MAC.Name = "lb_MAC";
            this.lb_MAC.Size = new System.Drawing.Size(0, 13);
            this.lb_MAC.TabIndex = 4;
            // 
            // lb_Tempertature
            // 
            this.lb_Tempertature.AutoSize = true;
            this.lb_Tempertature.Location = new System.Drawing.Point(23, 93);
            this.lb_Tempertature.Name = "lb_Tempertature";
            this.lb_Tempertature.Size = new System.Drawing.Size(0, 13);
            this.lb_Tempertature.TabIndex = 5;
            // 
            // lb_NamePC
            // 
            this.lb_NamePC.AutoSize = true;
            this.lb_NamePC.Location = new System.Drawing.Point(23, 123);
            this.lb_NamePC.Name = "lb_NamePC";
            this.lb_NamePC.Size = new System.Drawing.Size(0, 13);
            this.lb_NamePC.TabIndex = 6;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 243);
            this.Controls.Add(this.lb_NamePC);
            this.Controls.Add(this.lb_Tempertature);
            this.Controls.Add(this.lb_MAC);
            this.Controls.Add(this.lb_IPadd);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.Text = "WinClean";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CleanBtn;
        private System.Windows.Forms.Label lb_IPadd;
        private System.Windows.Forms.Label lb_MAC;
        private System.Windows.Forms.Label lb_Tempertature;
        private System.Windows.Forms.Label lb_NamePC;
    }
}