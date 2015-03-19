namespace chapter_2._7
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThumbnailSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullImageSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertData = new System.Windows.Forms.Button();
            this.showData = new System.Windows.Forms.Button();
            this.photographsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.ThumbnailSize,
            this.FullImageSize});
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(400, 209);
            this.dataGridView.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.HeaderText = "Photo Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // ThumbnailSize
            // 
            this.ThumbnailSize.HeaderText = "Photo Thumb Size";
            this.ThumbnailSize.Name = "ThumbnailSize";
            this.ThumbnailSize.ReadOnly = true;
            // 
            // FullImageSize
            // 
            this.FullImageSize.HeaderText = "Full Image Size";
            this.FullImageSize.Name = "FullImageSize";
            this.FullImageSize.ReadOnly = true;
            // 
            // insertData
            // 
            this.insertData.Location = new System.Drawing.Point(12, 12);
            this.insertData.Name = "insertData";
            this.insertData.Size = new System.Drawing.Size(75, 23);
            this.insertData.TabIndex = 1;
            this.insertData.Text = "Insert Data";
            this.insertData.UseVisualStyleBackColor = true;
            this.insertData.Click += new System.EventHandler(this.insertData_Click);
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(93, 12);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(75, 23);
            this.showData.TabIndex = 2;
            this.showData.Text = "Show Data";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 262);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.insertData);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photographsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button insertData;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.BindingSource photographsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThumbnailSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullImageSize;
    }
}

