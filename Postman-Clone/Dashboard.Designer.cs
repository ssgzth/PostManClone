namespace Postman_Clone
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLabel = new Label();
            ApiUrlLabel = new Label();
            ApiUrl = new TextBox();
            ApiUrlBtn = new Button();
            ResultLabel = new Label();
            ResultsText = new TextBox();
            statusStrip1 = new StatusStrip();
            SystemStatus = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(106, 48);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(374, 70);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "PostMan Clone";
            // 
            // ApiUrlLabel
            // 
            ApiUrlLabel.AutoSize = true;
            ApiUrlLabel.Location = new Point(106, 152);
            ApiUrlLabel.Name = "ApiUrlLabel";
            ApiUrlLabel.Size = new Size(148, 48);
            ApiUrlLabel.TabIndex = 1;
            ApiUrlLabel.Text = "API Url :";
            // 
            // ApiUrl
            // 
            ApiUrl.ForeColor = SystemColors.InactiveCaption;
            ApiUrl.Location = new Point(260, 149);
            ApiUrl.Name = "ApiUrl";
            ApiUrl.Size = new Size(1105, 55);
            ApiUrl.TabIndex = 2;
            ApiUrl.Text = "Enter Your API Url here";
            // 
            // ApiUrlBtn
            // 
            ApiUrlBtn.Location = new Point(1371, 149);
            ApiUrlBtn.Name = "ApiUrlBtn";
            ApiUrlBtn.Size = new Size(112, 55);
            ApiUrlBtn.TabIndex = 3;
            ApiUrlBtn.Text = "Go";
            ApiUrlBtn.UseVisualStyleBackColor = true;
            ApiUrlBtn.Click += ApiUrlBtn_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(106, 245);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(131, 48);
            ResultLabel.TabIndex = 4;
            ResultLabel.Text = "Results";
            // 
            // ResultsText
            // 
            ResultsText.BackColor = SystemColors.Window;
            ResultsText.ForeColor = SystemColors.ControlLightLight;
            ResultsText.Location = new Point(106, 310);
            ResultsText.Multiline = true;
            ResultsText.Name = "ResultsText";
            ResultsText.ReadOnly = true;
            ResultsText.ScrollBars = ScrollBars.Both;
            ResultsText.Size = new Size(1377, 688);
            ResultsText.TabIndex = 5;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { SystemStatus });
            statusStrip1.Location = new Point(0, 1071);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1600, 45);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "Ready";
            // 
            // SystemStatus
            // 
            SystemStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SystemStatus.Name = "SystemStatus";
            SystemStatus.Size = new Size(92, 38);
            SystemStatus.Text = "Ready";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 1116);
            Controls.Add(statusStrip1);
            Controls.Add(ResultsText);
            Controls.Add(ResultLabel);
            Controls.Add(ApiUrlBtn);
            Controls.Add(ApiUrl);
            Controls.Add(ApiUrlLabel);
            Controls.Add(TitleLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "PostManClone";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label ApiUrlLabel;
        private TextBox ApiUrl;
        private Button ApiUrlBtn;
        private Label ResultLabel;
        private TextBox ResultsText;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel SystemStatus;
    }
}
