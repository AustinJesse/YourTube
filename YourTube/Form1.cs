using System.Diagnostics;

namespace YourTube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ExtractAudiobtn_Click(object sender, EventArgs e)
        {
            string url = YoutubeURLBox.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a valid Youtube URL");
                return;
            }

            string ytDlpPath = @"C:\Users\AJesse\Desktop\YourTube project\YourTube\yt-dlp\yt-dlp.exe";
            string outputPath = @"C:\Users\AJesse\Desktop\YourTube project\YourTube\extractedaudio";

            string arguments = $"-x --audio-format mp3 -o \"{outputPath}\\%(title)s.%(ext)s\" {url}";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = ytDlpPath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                Process process = Process.Start(startInfo);
                process.WaitForExit(); // Wait for the process to finish

                MessageBox.Show("Download Complete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void YoutubeURLBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
