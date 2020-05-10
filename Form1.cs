using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Passworder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sizeBox.SelectedIndex = 0;
            MessageBox.Show("Welcome to Password Brute Force.\n" +
                            "\n" + 
                            "**THIS APPLICATION IS MEANT FOR EDUCATIONAL USE ONLY!!** \n" +
                            "**ACCESSING ANY SERVER OR DATA YOU DO NOT OWN WITHOUT PERMISSION OF THE OWNER IS ILLEGAL**\n\n" +
                            "\n\n\n\n\n" +
                            "-Maximum input length limited to 8 characters\n" +
                            //" (Even with fast solving settings anything longer simply takes too long)\n\n" +
                            "\n\n\n" +
                            "-Recommended Settings (Follow these rules to keep solve times under 5 minutes):\n\n" +
                            "   ---Use at least \"Only Lower\" or \"No Output\" for input longer than 2\n       characters.\n\n" +
                            "   ---No inputs longer than 5 with only \"No Output\" turned on.\n\n" +
                            "   ---No inputs longer than 3 with only \"Only Lower\" turned on.\n\n" +
                            "   ---No inputs longer than 6-7 with both \"No Output\" and \"Only Lower\"" +
                            "        (7 can take up to 10 minutes.) ", "Password Brute Force * *EDUCATION ONLY * * ");
        }
        string sysPass;
        string password = "";
        double attempts;
        int columns;
        bool showingResults = false;
        CancellationTokenSource m_cancelTokenSource = null;
        bool running = false;
        public void saveResults(double time)
        {//update results save file
            using (StreamWriter writer = File.AppendText("saveResults.txt"))
            {
                string size = sizeBox.Text;
                if (sizeBox.Enabled == false)
                {
                    size = "0";
                }
                writer.WriteLine(password.PadRight(9) + " | " + attempts.ToString().PadRight(15) + " | " + getTime(time).PadRight(25) + " | " +
                    onlyLower.Checked.ToString().PadRight(20) + " | " + noOutput.Checked.ToString().PadRight(19) +
                    " | " + defineSize.Checked.ToString().PadRight(5) + ", " + size.PadRight(16) + " |", true);
                writer.WriteLine("----------|-----------------|---------------------------|----------------------|---------------------|-------------------------|");
            }
        }
        public void loadResults()
        {//load results save file
            if (File.Exists("saveResults.txt"))
            {
                using (StreamReader reader = new StreamReader("saveResults.txt"))
                {
                    resultsBox.Text =     "Password  |     Attempts    |       Time (Seconds)      |   Only Lower - T/F   |   No Output - T/F   | Define Size - T/F, Size |";
                    resultsBox.AppendText(Environment.NewLine);
                    resultsBox.AppendText("----------|-----------------|---------------------------|----------------------|---------------------|-------------------------|");
                    resultsBox.AppendText(Environment.NewLine);
                    resultsBox.AppendText(reader.ReadToEnd());
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {//Start solver
            bool validInput = true;
            if(onlyLower.Checked == true)
            { 
                foreach (char a in inputBox.Text)
                {
                    if (!char.IsLetter(a)|| char.IsUpper(a))
                    {
                        validInput = false;
                    }
                }
            }
            if (validInput == false)
            {
                MessageBox.Show("Only lowercase letters are valid input in \"Only Lower\" mode.");

            }
            else if(!running)
            {
                inputBox.Enabled = false;
                sizeBox.Enabled = false;
                noOutput.Enabled = false;
                onlyLower.Enabled = false;
                defineSize.Enabled = false;
                running = true;
                button1.Text = "Stop";
                button1.Update();
                attempts = 0;
                columns = 0;
                sysPass = "";
                password = inputBox.Text.ToString();
                activityView.AppendText("New Attempt:");
                if (noOutput.Checked == true)
                {
                    activityView.AppendText("-|- Active Output Disabled.");
                }
                if (onlyLower.Checked == true)
                {
                    activityView.AppendText("-|- Running ONLY LOWER Mode.");
                }
                activityView.AppendText(Environment.NewLine);
                Stopwatch timer = Stopwatch.StartNew();
                if(defineSize.Checked == true)
                {
                    columns = int.Parse(sizeBox.Text)-1;
                }
                m_cancelTokenSource = new CancellationTokenSource();
                try
                {
                    progressBar1.Show();
                    while (sysPass != password && onlyLower.Checked == false)
                    {
                        columns++;
                        await SlowProcess(1,m_cancelTokenSource.Token);
                    }
                    while (sysPass != password && onlyLower.Checked == true)
                    {
                        columns++;
                        await SlowProcess(2, m_cancelTokenSource.Token);
                    }

                }
                catch(OperationCanceledException)
                {
                   
                }
                finally
                {
                    timer.Stop();
                    inputBox.Enabled = true;
                    if(defineSize.Checked == true)
                    sizeBox.Enabled = true;
                    noOutput.Enabled = true;
                    onlyLower.Enabled = true;
                    defineSize.Enabled = true;
                    progressBar1.Hide();
                    running = false;
                    button1.Text = "Go";
                    timerNum.Text = Convert.ToDouble(timer.ElapsedMilliseconds / 1000.00) + " Second(s)";
                    solutionNum.Text = sysPass;
                    attempNum.Text = attempts.ToString();
                    if (!(timer.ElapsedMilliseconds == 0))
                    {
                        solveRateNum.Text = Convert.ToInt32((attempts / double.Parse(timer.ElapsedMilliseconds.ToString())) * 1000) + " /sec";
                    }
                    else
                    {
                        solveRateNum.Text = "N/A /sec";
                    }
                    if (m_cancelTokenSource.Token.IsCancellationRequested == false)
                    {
                        saveResults(double.Parse((timer.ElapsedMilliseconds / 1000.00).ToString()));
                    }
                    loadResults();
                }
            }
            else
            {
                m_cancelTokenSource.Cancel();
            }
        }
        public string getTime(double seconds)
        {
            int min = 0;
            int hrs = 0;
            string secString = "";
            if(seconds < 60)
            {
                secString = seconds.ToString() + "000000";
            }
            if (seconds >= 60)
            {
                min = (Convert.ToInt32(seconds) / 60);
                secString = (seconds - (min * 60)).ToString() + "000000";
            }
            else
            {
                return (secString.Substring(0, 6) + " Sec");
            }
            if (min >= 60)
            {
                hrs = min / 60;
                min = min - (hrs * 60);
                return (hrs +"Hr "+ min +"Min "+ secString.Substring(0,6) +" Sec");
            }
            else
            {
                return (min + "Min " + secString.Substring(0, 6) + " Sec");
            }
        }
        public void tryAll(string keyTry, int columns, CancellationToken ct)
        {//use only lower case character set
            if (keyTry.Length == columns || keyTry == password)
            {
                sysPass = keyTry;
                attempts++;
                if (noOutput.Checked == false)
                {
                    this.Invoke(new MethodInvoker(delegate { activityView.AppendText((attempts) + " : " + keyTry); }));
                    this.Invoke(new MethodInvoker(delegate { activityView.AppendText(Environment.NewLine); }));
                }
                return;
            }
            for (char c = 'a'; sysPass != password && c <= 'z'; c++)
            {
                tryAll(keyTry + c, columns, ct);
            }
            ct.ThrowIfCancellationRequested();

        }
        public void tryAll(string keyTry, int columns, bool extended,CancellationToken ct)
        {//use full character set (using separate methods decreases solve time by ~6%)

            if (keyTry.Length == columns || keyTry == password)
            {
                sysPass = keyTry;
                attempts++;
                if (noOutput.Checked == false)
                {
                    this.Invoke(new MethodInvoker(delegate { activityView.AppendText((attempts) + " : " + keyTry); }));
                    this.Invoke(new MethodInvoker(delegate { activityView.AppendText(Environment.NewLine); }));
                }
                return;
            }
            for (char c = '!'; sysPass != password && c <= 'z'; c++)
            {
                tryAll(keyTry + c, columns, true,ct);
            }
            ct.ThrowIfCancellationRequested();
        }
        public Task SlowProcess(int version, CancellationToken ct)
        {
            
            return Task.Run(() =>
            {
                if (version == 1)
                {
                    tryAll(string.Empty, columns, true,ct);
                }
                if (version == 2)
                {
                    tryAll(string.Empty, columns,ct);
                }
            }
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {//History button
            if (showingResults == false)
            {//show results
                loadResults();
                resultsButton.Text = "Hide Results History";
                this.MaximumSize = new System.Drawing.Size(1398, 615);
                this.MinimumSize = new System.Drawing.Size(1398, 615);
                this.Size = new System.Drawing.Size(1398, 615);
                showingResults = true;
            }
            else if (showingResults == true)
            {//hide results
                resultsButton.Text = "Show Results History";
                this.MaximumSize = new System.Drawing.Size(460, 615);
                this.MinimumSize = new System.Drawing.Size(460, 615);
                this.Size = new System.Drawing.Size(460, 615);
                showingResults = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {//define size checkBox
            if (defineSize.Checked == true)
            {
                sizeBox.Enabled = true;
            }
            if (defineSize.Checked == false)
            {
                sizeBox.Enabled = false;
            }
        }
    }
}
