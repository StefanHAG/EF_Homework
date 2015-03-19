namespace net_t1_v2
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
            this.InsertButton = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.queryResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(71, 31);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 0;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(242, 31);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(75, 23);
            this.SelectAll.TabIndex = 1;
            this.SelectAll.Text = "SelectAll";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // queryResultTextBox
            // 
            this.queryResultTextBox.Location = new System.Drawing.Point(12, 71);
            this.queryResultTextBox.Multiline = true;
            this.queryResultTextBox.Name = "queryResultTextBox";
            this.queryResultTextBox.Size = new System.Drawing.Size(363, 224);
            this.queryResultTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 307);
            this.Controls.Add(this.queryResultTextBox);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.InsertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.TextBox queryResultTextBox;
    }
}

