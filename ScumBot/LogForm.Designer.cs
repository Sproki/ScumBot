using System.ComponentModel;

namespace ScumBot;

partial class LogForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        logTextBox = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // logTextBox
        // 
        logTextBox.Location = new System.Drawing.Point(12, 31);
        logTextBox.Multiline = true;
        logTextBox.Name = "logTextBox";
        logTextBox.ReadOnly = true;
        logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        logTextBox.Size = new System.Drawing.Size(774, 300);
        logTextBox.TabIndex = 0;
        // 
        // LogForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(logTextBox);
        Text = "LogForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox logTextBox;

    #endregion
}