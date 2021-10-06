
namespace PC_Monitoring_Tool.UI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.gpuSensorListBox = new System.Windows.Forms.ListBox();
            this.cpuUtilisationListBox = new System.Windows.Forms.ListBox();
            this.cpuClocksListBox = new System.Windows.Forms.ListBox();
            this.cpuTempsListBox = new System.Windows.Forms.ListBox();
            this.cpuHeadingLabel = new System.Windows.Forms.Label();
            this.gpuHeadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpuSensorListBox
            // 
            this.gpuSensorListBox.FormattingEnabled = true;
            this.gpuSensorListBox.ItemHeight = 25;
            this.gpuSensorListBox.Location = new System.Drawing.Point(469, 92);
            this.gpuSensorListBox.Name = "gpuSensorListBox";
            this.gpuSensorListBox.Size = new System.Drawing.Size(340, 204);
            this.gpuSensorListBox.TabIndex = 5;
            // 
            // cpuUtilisationListBox
            // 
            this.cpuUtilisationListBox.FormattingEnabled = true;
            this.cpuUtilisationListBox.ItemHeight = 25;
            this.cpuUtilisationListBox.Location = new System.Drawing.Point(34, 183);
            this.cpuUtilisationListBox.Name = "cpuUtilisationListBox";
            this.cpuUtilisationListBox.Size = new System.Drawing.Size(340, 204);
            this.cpuUtilisationListBox.TabIndex = 6;
            // 
            // cpuClocksListBox
            // 
            this.cpuClocksListBox.FormattingEnabled = true;
            this.cpuClocksListBox.ItemHeight = 25;
            this.cpuClocksListBox.Location = new System.Drawing.Point(34, 399);
            this.cpuClocksListBox.Name = "cpuClocksListBox";
            this.cpuClocksListBox.Size = new System.Drawing.Size(340, 204);
            this.cpuClocksListBox.TabIndex = 7;
            // 
            // cpuTempsListBox
            // 
            this.cpuTempsListBox.FormattingEnabled = true;
            this.cpuTempsListBox.ItemHeight = 25;
            this.cpuTempsListBox.Location = new System.Drawing.Point(34, 92);
            this.cpuTempsListBox.Name = "cpuTempsListBox";
            this.cpuTempsListBox.Size = new System.Drawing.Size(340, 79);
            this.cpuTempsListBox.TabIndex = 8;
            // 
            // cpuHeadingLabel
            // 
            this.cpuHeadingLabel.AutoSize = true;
            this.cpuHeadingLabel.Location = new System.Drawing.Point(168, 52);
            this.cpuHeadingLabel.Name = "cpuHeadingLabel";
            this.cpuHeadingLabel.Size = new System.Drawing.Size(48, 25);
            this.cpuHeadingLabel.TabIndex = 9;
            this.cpuHeadingLabel.Text = "CPU";
            // 
            // gpuHeadingLabel
            // 
            this.gpuHeadingLabel.AutoSize = true;
            this.gpuHeadingLabel.Location = new System.Drawing.Point(626, 52);
            this.gpuHeadingLabel.Name = "gpuHeadingLabel";
            this.gpuHeadingLabel.Size = new System.Drawing.Size(49, 25);
            this.gpuHeadingLabel.TabIndex = 10;
            this.gpuHeadingLabel.Text = "GPU";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 615);
            this.Controls.Add(this.gpuHeadingLabel);
            this.Controls.Add(this.cpuHeadingLabel);
            this.Controls.Add(this.cpuTempsListBox);
            this.Controls.Add(this.cpuClocksListBox);
            this.Controls.Add(this.cpuUtilisationListBox);
            this.Controls.Add(this.gpuSensorListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox gpuSensorListBox;
        private System.Windows.Forms.ListBox cpuUtilisationListBox;
        private System.Windows.Forms.ListBox cpuClocksListBox;
        private System.Windows.Forms.ListBox cpuTempsListBox;
        private System.Windows.Forms.Label cpuHeadingLabel;
        private System.Windows.Forms.Label gpuHeadingLabel;
    }
}