namespace Hello_World
{
    partial class InitalForm
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.AccessibleDescription = "";
            this.btnClickThis.AccessibleName = "";
            this.btnClickThis.BackColor = System.Drawing.Color.Transparent;
            this.btnClickThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClickThis.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnClickThis.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClickThis.FlatAppearance.BorderSize = 0;
            this.btnClickThis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClickThis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClickThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnClickThis.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClickThis.Location = new System.Drawing.Point(274, 219);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(280, 62);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Start Game";
            this.btnClickThis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnClickThis.UseVisualStyleBackColor = false;
            this.btnClickThis.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Magneto", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.textBox1.Location = new System.Drawing.Point(98, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 82);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Space Invaders";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "";
            this.button3.AccessibleName = "";
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(274, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 62);
            this.button3.TabIndex = 5;
            this.button3.Text = "LeaderBoard";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.AccessibleName = "";
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(744, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // InitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::Hello_World.Properties.Resources.ScreenshotStarfield;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClickThis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitalForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

