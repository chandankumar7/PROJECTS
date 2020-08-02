namespace BOOKSTORE
{
    partial class AppBody
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
            this.Titlebar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.minimizebutton = new System.Windows.Forms.Button();
            this.Logoffbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Titlebar.Controls.Add(this.minimizebutton);
            this.Titlebar.Controls.Add(this.Logoffbutton);
            this.Titlebar.Controls.Add(this.closebutton);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(335, 34);
            this.Titlebar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "select";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(105, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "join";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // minimizebutton
            // 
            this.minimizebutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizebutton.BackgroundImage = global::BOOKSTORE.Properties.Resources.minimize;
            this.minimizebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebutton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.minimizebutton.Location = new System.Drawing.Point(260, 2);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(36, 32);
            this.minimizebutton.TabIndex = 3;
            this.minimizebutton.UseVisualStyleBackColor = false;
            this.minimizebutton.Click += new System.EventHandler(this.minimizebutton_Click);
            // 
            // Logoffbutton
            // 
            this.Logoffbutton.BackgroundImage = global::BOOKSTORE.Properties.Resources.logout_1;
            this.Logoffbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logoffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoffbutton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Logoffbutton.Location = new System.Drawing.Point(218, 3);
            this.Logoffbutton.Name = "Logoffbutton";
            this.Logoffbutton.Size = new System.Drawing.Size(36, 32);
            this.Logoffbutton.TabIndex = 2;
            this.Logoffbutton.UseVisualStyleBackColor = true;
            this.Logoffbutton.Click += new System.EventHandler(this.Logoffbutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackgroundImage = global::BOOKSTORE.Properties.Resources.close1_;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.closebutton.Location = new System.Drawing.Point(302, 3);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(33, 32);
            this.closebutton.TabIndex = 1;
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(335, 404);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button minimizebutton;
        private System.Windows.Forms.Button Logoffbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}