

using PostManCloneLibrary;

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
            Status = new Label();
            DropDown = new ComboBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Stencil", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.DarkSlateGray;
            TitleLabel.Location = new Point(106, 48);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(444, 61);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "PostMan Clone";
            // 
            // ApiUrlLabel
            // 
            ApiUrlLabel.AutoSize = true;
            ApiUrlLabel.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApiUrlLabel.ForeColor = Color.DarkSlateGray;
            ApiUrlLabel.Location = new Point(95, 160);
            ApiUrlLabel.Name = "ApiUrlLabel";
            ApiUrlLabel.Size = new Size(176, 43);
            ApiUrlLabel.TabIndex = 1;
            ApiUrlLabel.Text = "API Url :";
            // 
            // ApiUrl
            // 
            ApiUrl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApiUrl.ForeColor = SystemColors.InactiveCaption;
            ApiUrl.Location = new Point(430, 157);
            ApiUrl.Name = "ApiUrl";
            ApiUrl.Size = new Size(1105, 55);
            ApiUrl.TabIndex = 2;
            ApiUrl.Text = "Enter Your API Url here";
            // 
            // ApiUrlBtn
            // 
            ApiUrlBtn.BackColor = Color.SteelBlue;
            ApiUrlBtn.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApiUrlBtn.ForeColor = Color.White;
            ApiUrlBtn.Location = new Point(1541, 158);
            ApiUrlBtn.Name = "ApiUrlBtn";
            ApiUrlBtn.Size = new Size(112, 55);
            ApiUrlBtn.TabIndex = 3;
            ApiUrlBtn.Text = "Go";
            ApiUrlBtn.UseVisualStyleBackColor = false;
            ApiUrlBtn.Click += ApiUrlBtn_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultLabel.ForeColor = Color.DarkSlateGray;
            ResultLabel.Location = new Point(95, 243);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(169, 43);
            ResultLabel.TabIndex = 4;
            ResultLabel.Text = "Results";
            // 
            // ResultsText
            // 
            ResultsText.BackColor = SystemColors.Window;
            ResultsText.ForeColor = SystemColors.ControlText;
            ResultsText.Location = new Point(95, 289);
            ResultsText.Multiline = true;
            ResultsText.Name = "ResultsText";
            ResultsText.ReadOnly = true;
            ResultsText.ScrollBars = ScrollBars.Both;
            ResultsText.Size = new Size(1562, 647);
            ResultsText.TabIndex = 5;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { SystemStatus });
            statusStrip1.Location = new Point(0, 1101);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1771, 40);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "Ready";
            // 
            // SystemStatus
            // 
            SystemStatus.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SystemStatus.ForeColor = Color.DarkSlateGray;
            SystemStatus.Name = "SystemStatus";
            SystemStatus.Size = new Size(103, 33);
            SystemStatus.Text = "Ready";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Status.ForeColor = Color.DarkSlateGray;
            Status.Location = new Point(1422, 953);
            Status.Name = "Status";
            Status.Size = new Size(235, 43);
            Status.TabIndex = 7;
            Status.Text = "StatusCode";
            // 
            // DropDown
            // 
            DropDown.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DropDown.FormattingEnabled = true;
            DropDown.Items.AddRange(new object[] { HttpPost.GET, HttpPost.POST, HttpPost.PUT, HttpPost.DELETE, HttpPost.PATCH });
            DropDown.Location = new Point(277, 157);
            DropDown.Name = "DropDown";
            DropDown.Size = new Size(147, 56);
            DropDown.TabIndex = 8;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1771, 1141);
            Controls.Add(DropDown);
            Controls.Add(Status);
            Controls.Add(statusStrip1);
            Controls.Add(ResultsText);
            Controls.Add(ResultLabel);
            Controls.Add(ApiUrlBtn);
            Controls.Add(ApiUrl);
            Controls.Add(ApiUrlLabel);
            Controls.Add(TitleLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkSlateGray;
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
        private Label Status;
        private ComboBox DropDown;
    }
}
