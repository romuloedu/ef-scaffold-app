using System.ComponentModel;
using System.Diagnostics;

namespace EFScaffoldApp
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Verificar se o comando 'dotnet ef dbcontext' está disponível e exibir na barra de status
            if (CheckDotNetEfCommand())
            {
                statusLabel.Text = "dotnet ef scaffold está instalado.";
            }
            else
            {
                statusLabel.Text = "dotnet ef scaffold não está instalado.";
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            btnExecute.Enabled = false;

            string param1 = txtParam1.Text;
            string param2 = txtParam2.Text;
            string param3 = txtParam3.Text;
            string param4 = txtParam4.Text;
            string param5 = txtParam5.Text;

            var tables = param3.Split(';').Select(table => $"-t {table.Trim()}");
            string tablesArgument = string.Join(" ", tables);

            string command = $"dotnet ef dbcontext scaffold Name=\"{param1}\" Oracle.EntityFrameworkCore " +
                $"-c {param2} {tablesArgument} -o {param4} --project {param5} --no-onconfiguring --force";

            txtOutput.Clear();
            txtOutput.Text = $"Executando comando: {command}\r\n\r\n";
            backgroundWorker1.RunWorkerAsync(command);
        }

        private bool CheckDotNetEfCommand()
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "dotnet",
                        Arguments = "ef dbcontext",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };
                process.Start();
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return !string.IsNullOrEmpty(result);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string ExecuteCommand(string command)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            return !string.IsNullOrEmpty(error) ? $"Erro: {error}" : $"Saída: {output}";
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtParam3.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnSelectContextFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtParam2.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                }
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtParam4.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnSelectProjectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Project Files (*.csproj;*.sln)|*.csproj;*.sln|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtParam5.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
