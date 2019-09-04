namespace DataValidationWF
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
            this.ResultsTable = new System.Windows.Forms.TableLayoutPanel();
            this.LocationDisplay = new System.Windows.Forms.Label();
            this.ResultsDaf1220Box = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ResultsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsTable
            // 
            this.ResultsTable.ColumnCount = 4;
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.93273F));
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.93273F));
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06726F));
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06726F));
            this.ResultsTable.Controls.Add(this.LocationDisplay, 0, 0);
            this.ResultsTable.Controls.Add(this.ResultsDaf1220Box, 1, 1);
            this.ResultsTable.Location = new System.Drawing.Point(216, 92);
            this.ResultsTable.Name = "ResultsTable";
            this.ResultsTable.RowCount = 5;
            this.ResultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultsTable.Size = new System.Drawing.Size(572, 294);
            this.ResultsTable.TabIndex = 0;
            this.ResultsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultsTable_Paint);
            // 
            // LocationDisplay
            // 
            this.LocationDisplay.AutoSize = true;
            this.LocationDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocationDisplay.Location = new System.Drawing.Point(3, 0);
            this.LocationDisplay.Name = "LocationDisplay";
            this.LocationDisplay.Size = new System.Drawing.Size(136, 58);
            this.LocationDisplay.TabIndex = 1;
            this.LocationDisplay.Text = "Not Started";
            this.LocationDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LocationDisplay.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // ResultsDaf1220Box
            // 
            this.ResultsDaf1220Box.AutoSize = true;
            this.ResultsDaf1220Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsDaf1220Box.Location = new System.Drawing.Point(145, 58);
            this.ResultsDaf1220Box.Name = "ResultsDaf1220Box";
            this.ResultsDaf1220Box.Size = new System.Drawing.Size(136, 58);
            this.ResultsDaf1220Box.TabIndex = 0;
            this.ResultsDaf1220Box.Text = "Not Started";
            this.ResultsDaf1220Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultsDaf1220Box.Click += new System.EventHandler(this.ResultsDaf1220Box_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(44, 12);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(138, 57);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Check for Files";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Location
            // 
            this.Location.AllowDrop = true;
            this.Location.FormattingEnabled = true;
            this.Location.Items.AddRange(new object[] {
            "Local",
            "Primary",
            "Secondary"});
            this.Location.Location = new System.Drawing.Point(219, 26);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(59, 43);
            this.Location.Sorted = true;
            this.Location.TabIndex = 2;
            this.Location.SelectedIndexChanged += new System.EventHandler(this.Location_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ResultsTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResultsTable.ResumeLayout(false);
            this.ResultsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ResultsDaf1220Box;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.ListBox Location;
        private System.Windows.Forms.Label LocationDisplay;
        private System.Windows.Forms.TableLayoutPanel ResultsTable;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

