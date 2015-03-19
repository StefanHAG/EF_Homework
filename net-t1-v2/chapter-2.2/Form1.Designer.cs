namespace chapter_2._2
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
            this.insertButton = new System.Windows.Forms.Button();
            this.showData = new System.Windows.Forms.Button();
            this.showView = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(38, 24);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(197, 24);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(75, 23);
            this.showData.TabIndex = 1;
            this.showData.Text = "Show Data";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // showView
            // 
            this.showView.Location = new System.Drawing.Point(362, 23);
            this.showView.Name = "showView";
            this.showView.Size = new System.Drawing.Size(75, 23);
            this.showView.TabIndex = 2;
            this.showView.Text = "Show View";
            this.showView.UseVisualStyleBackColor = true;
            this.showView.Click += new System.EventHandler(this.showView_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(38, 53);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(399, 197);
            this.textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 262);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.showView);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.insertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.Button showView;
        private System.Windows.Forms.TextBox textBox;
    }
}

