using DotNetEnv;
using NLog;

namespace ScumBot;

static class Program
{
    public static TextBoxTarget GlobalLogTextBoxTarget = new()
    {
        Layout = "${date:format=dd-MM-yyyy HH\\:mm\\:ss} [${level:uppercase=true}] ${message}"
    };

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ApplicationConfiguration.Initialize();

        Env.Load();
        Env.Load(".env.local", new LoadOptions());

        string environment = Env.GetString("APP_ENV", "dev");
        string logPath = "log/" + environment + "/";
        if (!Directory.Exists(logPath))
        {
            Directory.CreateDirectory(logPath);
        }

        LogForm logForm = new LogForm();
        
        LogManager.Setup().LoadConfiguration(builder => {
            builder.ForLogger().FilterMinLevel(LogLevel.Debug).WriteToConsole();
            builder.ForLogger().FilterMinLevel(LogLevel.Info).WriteToFile(fileName: $"{logPath}{environment}.log");
            builder.ForLogger().FilterMinLevel(LogLevel.Debug).WriteTo(GlobalLogTextBoxTarget);
        });

        Thread uiLogThread = new Thread(() =>
        {
            Application.Run(logForm);
        });
        uiLogThread.SetApartmentState(ApartmentState.STA);
        uiLogThread.Start();

        Logger logger = LogManager.GetCurrentClassLogger();

        logger.Info("Initialisierung abgeschlossen.");
    }
}