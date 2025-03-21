using NLog;
using NLog.Targets;

namespace ScumBot;

public class TextBoxTarget : TargetWithLayout
{
    public TextBox? LogTextBox { get; set; }
    
    protected override void Write(LogEventInfo logEvent)
    {
        if (LogTextBox == null) {
            return;
        }

        string logMessage = Layout.Render(logEvent);
        
        if (LogTextBox.InvokeRequired)
        {
            LogTextBox.Invoke(() =>
            {
                LogTextBox.AppendText(logMessage + Environment.NewLine);
            });
        }
        else
        {
            LogTextBox.AppendText(logMessage + Environment.NewLine);
        }
    }
}

public partial class LogForm : Form
{
    public LogForm()
    {
        InitializeComponent();

        Program.GlobalLogTextBoxTarget.LogTextBox = logTextBox;
    }
}