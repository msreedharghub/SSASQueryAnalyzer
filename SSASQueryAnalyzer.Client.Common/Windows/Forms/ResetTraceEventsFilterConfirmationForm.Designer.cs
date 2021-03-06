﻿namespace SSASQueryAnalyzer.Client.Common.Windows.Forms
{
    partial class ResetTraceEventsFilterConfirmationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMessageSecondRow = new System.Windows.Forms.Label();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.panelBatchMode = new System.Windows.Forms.Panel();
            this.pictureTraceEventsFilter = new System.Windows.Forms.PictureBox();
            this.customLabelTraceEventsTitle = new SSASQueryAnalyzer.Client.Common.Windows.Forms.CustomLabelControl();
            this.panelBatchModeBottom = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            this.panelBatchMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTraceEventsFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMessageSecondRow);
            this.panel1.Controls.Add(this.pictureInfo);
            this.panel1.Controls.Add(this.labelMessage);
            this.panel1.Controls.Add(this.buttonYes);
            this.panel1.Controls.Add(this.buttonNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 101);
            this.panel1.TabIndex = 1;
            // 
            // labelMessageSecondRow
            // 
            this.labelMessageSecondRow.AutoSize = true;
            this.labelMessageSecondRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageSecondRow.Location = new System.Drawing.Point(49, 28);
            this.labelMessageSecondRow.Margin = new System.Windows.Forms.Padding(0);
            this.labelMessageSecondRow.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelMessageSecondRow.Name = "labelMessageSecondRow";
            this.labelMessageSecondRow.Size = new System.Drawing.Size(64, 15);
            this.labelMessageSecondRow.TabIndex = 14;
            this.labelMessageSecondRow.Text = "Continue ?";
            // 
            // pictureInfo
            // 
            this.pictureInfo.Location = new System.Drawing.Point(8, 8);
            this.pictureInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(34, 34);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInfo.TabIndex = 7;
            this.pictureInfo.TabStop = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(49, 8);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(211, 15);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.Text = "Current Trace Events filter will be reset.";
            // 
            // buttonYes
            // 
            this.buttonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Location = new System.Drawing.Point(179, 64);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(0);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(86, 28);
            this.buttonYes.TabIndex = 4;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            // 
            // buttonNo
            // 
            this.buttonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Location = new System.Drawing.Point(272, 64);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(86, 28);
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            // 
            // panelBatchMode
            // 
            this.panelBatchMode.BackColor = System.Drawing.Color.Transparent;
            this.panelBatchMode.Controls.Add(this.pictureTraceEventsFilter);
            this.panelBatchMode.Controls.Add(this.customLabelTraceEventsTitle);
            this.panelBatchMode.Controls.Add(this.panelBatchModeBottom);
            this.panelBatchMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBatchMode.Location = new System.Drawing.Point(0, 0);
            this.panelBatchMode.Name = "panelBatchMode";
            this.panelBatchMode.Size = new System.Drawing.Size(367, 48);
            this.panelBatchMode.TabIndex = 84;
            // 
            // pictureTraceEventsFilter
            // 
            this.pictureTraceEventsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTraceEventsFilter.Image = global::SSASQueryAnalyzer.Client.Common.Properties.Resources.ProfilerFiltered_32x32;
            this.pictureTraceEventsFilter.Location = new System.Drawing.Point(326, 8);
            this.pictureTraceEventsFilter.Name = "pictureTraceEventsFilter";
            this.pictureTraceEventsFilter.Size = new System.Drawing.Size(34, 34);
            this.pictureTraceEventsFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureTraceEventsFilter.TabIndex = 78;
            this.pictureTraceEventsFilter.TabStop = false;
            // 
            // customLabelTraceEventsTitle
            // 
            this.customLabelTraceEventsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabelTraceEventsTitle.AutoSize = true;
            this.customLabelTraceEventsTitle.BorderColor = System.Drawing.Color.Black;
            this.customLabelTraceEventsTitle.BorderHeightOffset = 2;
            this.customLabelTraceEventsTitle.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.customLabelTraceEventsTitle.BorderWidthOffset = 2;
            this.customLabelTraceEventsTitle.DrawBorder = false;
            this.customLabelTraceEventsTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabelTraceEventsTitle.Location = new System.Drawing.Point(237, 19);
            this.customLabelTraceEventsTitle.Margin = new System.Windows.Forms.Padding(0);
            this.customLabelTraceEventsTitle.Name = "customLabelTraceEventsTitle";
            this.customLabelTraceEventsTitle.Size = new System.Drawing.Size(88, 12);
            this.customLabelTraceEventsTitle.TabIndex = 79;
            this.customLabelTraceEventsTitle.Text = "Trace Events filter";
            this.customLabelTraceEventsTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelBatchModeBottom
            // 
            this.panelBatchModeBottom.BackColor = System.Drawing.Color.Black;
            this.panelBatchModeBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBatchModeBottom.Location = new System.Drawing.Point(0, 47);
            this.panelBatchModeBottom.Name = "panelBatchModeBottom";
            this.panelBatchModeBottom.Size = new System.Drawing.Size(367, 1);
            this.panelBatchModeBottom.TabIndex = 86;
            // 
            // ResetTraceEventsFilterConfirmationForm
            // 
            this.AcceptButton = this.buttonNo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonNo;
            this.ClientSize = new System.Drawing.Size(367, 149);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBatchMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ResetTraceEventsFilterConfirmationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASQA - Warning";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            this.panelBatchMode.ResumeLayout(false);
            this.panelBatchMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTraceEventsFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Panel panelBatchMode;
        private System.Windows.Forms.PictureBox pictureTraceEventsFilter;
        private Common.Windows.Forms.CustomLabelControl customLabelTraceEventsTitle;
        private System.Windows.Forms.Panel panelBatchModeBottom;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.Label labelMessageSecondRow;
    }
}