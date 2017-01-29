namespace CC
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
            this.Camp1 = new System.Windows.Forms.Label();
            this.Camp2 = new System.Windows.Forms.Label();
            this.Camp3 = new System.Windows.Forms.Label();
            this.Camp4 = new System.Windows.Forms.Label();
            this.Save_botton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.Army1 = new System.Windows.Forms.TextBox();
            this.Army2 = new System.Windows.Forms.TextBox();
            this.Army3 = new System.Windows.Forms.TextBox();
            this.Army4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // Camp1
            // 
            this.Camp1.AutoSize = true;
            this.Camp1.Location = new System.Drawing.Point(29, 19);
            this.Camp1.Name = "Camp1";
            this.Camp1.Size = new System.Drawing.Size(69, 13);
            this.Camp1.TabIndex = 0;
            this.Camp1.Text = "Army Camp 1";
            // 
            // Camp2
            // 
            this.Camp2.AutoSize = true;
            this.Camp2.Location = new System.Drawing.Point(29, 51);
            this.Camp2.Name = "Camp2";
            this.Camp2.Size = new System.Drawing.Size(69, 13);
            this.Camp2.TabIndex = 1;
            this.Camp2.Text = "Army Camp 2";
            // 
            // Camp3
            // 
            this.Camp3.AutoSize = true;
            this.Camp3.Location = new System.Drawing.Point(29, 83);
            this.Camp3.Name = "Camp3";
            this.Camp3.Size = new System.Drawing.Size(69, 13);
            this.Camp3.TabIndex = 2;
            this.Camp3.Text = "Army Camp 3";
            // 
            // Camp4
            // 
            this.Camp4.AutoSize = true;
            this.Camp4.Location = new System.Drawing.Point(29, 118);
            this.Camp4.Name = "Camp4";
            this.Camp4.Size = new System.Drawing.Size(69, 13);
            this.Camp4.TabIndex = 3;
            this.Camp4.Text = "Army Camp 4";
            // 
            // Save_botton
            // 
            this.Save_botton.Location = new System.Drawing.Point(32, 186);
            this.Save_botton.Name = "Save_botton";
            this.Save_botton.Size = new System.Drawing.Size(75, 23);
            this.Save_botton.TabIndex = 6;
            this.Save_botton.Text = "Save";
            this.Save_botton.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(115, 19);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(140, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TabStop = false;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(115, 51);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(141, 45);
            this.trackBar2.TabIndex = 11;
            this.trackBar2.TabStop = false;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(115, 83);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(140, 45);
            this.trackBar3.TabIndex = 12;
            this.trackBar3.TabStop = false;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(115, 118);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(140, 45);
            this.trackBar4.TabIndex = 6;
            this.trackBar4.TabStop = false;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // Army1
            // 
            this.Army1.Location = new System.Drawing.Point(261, 16);
            this.Army1.Name = "Army1";
            this.Army1.Size = new System.Drawing.Size(35, 20);
            this.Army1.TabIndex = 17;
            this.Army1.Validated += new System.EventHandler(this.Army1_Validated);
            // 
            // Army2
            // 
            this.Army2.Location = new System.Drawing.Point(261, 48);
            this.Army2.Name = "Army2";
            this.Army2.Size = new System.Drawing.Size(35, 20);
            this.Army2.TabIndex = 18;
            this.Army2.Validated += new System.EventHandler(this.Army2_Validated);
            // 
            // Army3
            // 
            this.Army3.Location = new System.Drawing.Point(261, 80);
            this.Army3.Name = "Army3";
            this.Army3.Size = new System.Drawing.Size(35, 20);
            this.Army3.TabIndex = 19;
            this.Army3.Validated += new System.EventHandler(this.Army3_Validated);
            // 
            // Army4
            // 
            this.Army4.Location = new System.Drawing.Point(261, 115);
            this.Army4.Name = "Army4";
            this.Army4.Size = new System.Drawing.Size(35, 20);
            this.Army4.TabIndex = 20;
            this.Army4.Validated += new System.EventHandler(this.Army4_Validated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 337);
            this.Controls.Add(this.Army4);
            this.Controls.Add(this.Army3);
            this.Controls.Add(this.Army2);
            this.Controls.Add(this.Army1);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Save_botton);
            this.Controls.Add(this.Camp4);
            this.Controls.Add(this.Camp3);
            this.Controls.Add(this.Camp2);
            this.Controls.Add(this.Camp1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Camp1;
        private System.Windows.Forms.Label Camp2;
        private System.Windows.Forms.Label Camp3;
        private System.Windows.Forms.Label Camp4;
        private System.Windows.Forms.Button Save_botton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TextBox Army1;
        private System.Windows.Forms.TextBox Army2;
        private System.Windows.Forms.TextBox Army3;
        private System.Windows.Forms.TextBox Army4;
    }
}

