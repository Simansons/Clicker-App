namespace Clicker_App
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
            this.FirstButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RandomLocation = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.Font = new System.Drawing.Font("Lucida Handwriting", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstButton.Location = new System.Drawing.Point(245, 79);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(262, 170);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "Click Me";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            this.FirstButton.MouseEnter += new System.EventHandler(this.FirstButton_MouseEnter);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ResetButton.Location = new System.Drawing.Point(525, 295);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(178, 37);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset Button";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.ResetButton.MouseEnter += new System.EventHandler(this.ResetButton_MouseEnter);
            // 
            // RandomLocation
            // 
            this.RandomLocation.Interval = 300;
            this.RandomLocation.Tick += new System.EventHandler(this.RandomLocation_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.FirstButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Timer RandomLocation;
    }
}

