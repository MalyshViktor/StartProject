using Microsoft.Practices.Unity;

namespace StartProject
{
    public partial class Form1 : Form
    {
        /* Иньекция через свойства
        [Dependency]
        public IHasher hasher { get; set; }
        */
        private readonly IHasher hasher;
        private readonly NLog.Logger logger;
        public Form1(IHasher hasher, NLog.Logger logger)
        {
            this.hasher = hasher;
            this.logger = logger;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Loaded");
            listBox1.Items.Add(hasher.Hash("Loaded"));
        }

        private void buttonTrace_Click(object sender, EventArgs e)
        {
            logger.Trace("Trace message");
            listBox1.Items.Add("Trace message logged!");
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            logger.Debug("Debug message");
            listBox1.Items.Add("Debug message logged!");
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            logger.Info("Info message");
            listBox1.Items.Add("Info message logged!");
        }

        private void buttonWarn_Click(object sender, EventArgs e)
        {
            logger.Warn("Warn message");
            listBox1.Items.Add("Warn message logged!");
        }

        private void buttonError_Click(object sender, EventArgs e)
        {
            logger.Error("Error message");
            listBox1.Items.Add("Error message logged!");
        }
        private void buttonFatal_Click(object sender, EventArgs e)
        {
            logger.Fatal("Fatal message");
            listBox1.Items.Add("Fatal message logged!");
        }
    }
}