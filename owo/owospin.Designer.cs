namespace owo
{
    partial class owospin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owospin));
            this.owo = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // owo
            // 
            this.owo.BackColor = System.Drawing.Color.Transparent;
            this.owo.Dock = System.Windows.Forms.DockStyle.Top;
            this.owo.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owo.ForeColor = System.Drawing.Color.White;
            this.owo.Location = new System.Drawing.Point(0, 0);
            this.owo.Name = "owo";
            this.owo.Size = new System.Drawing.Size(752, 309);
            this.owo.TabIndex = 0;
            this.owo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 75;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(0, 299);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(752, 46);
            this.text.TabIndex = 1;
            this.text.Text = "*spins furiously*";
            this.text.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // owospin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(752, 345);
            this.Controls.Add(this.text);
            this.Controls.Add(this.owo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "owospin";
            this.Text = "owo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label owo;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label text;
    }
}

