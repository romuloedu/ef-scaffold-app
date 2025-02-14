
using System.ComponentModel;

namespace EFScaffoldApp
{
    partial class MainApp
    {
        private IContainer components = null;
        private TextBox txtParam1;
        private TextBox txtParam2;
        private TextBox txtParam3;
        private TextBox txtParam4;
        private TextBox txtParam5;
        private TextBox txtOutput;
        private Button btnExecute;
        private Button btnSelectContextFile;
        private Button btnSelectFolder;
        private Button btnSelectProjectFile;
        private Label lblParam1;
        private Label lblParam2;
        private Label lblParam3;
        private Label lblParam4;
        private Label lblParam5;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private BackgroundWorker backgroundWorker1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            backgroundWorker1 = new BackgroundWorker();
            txtParam1 = new TextBox();
            txtParam2 = new TextBox();
            txtParam3 = new TextBox();
            txtParam4 = new TextBox();
            txtParam5 = new TextBox();
            txtOutput = new TextBox();
            btnExecute = new Button();
            btnSelectContextFile = new Button();
            btnSelectFolder = new Button();
            btnSelectProjectFile = new Button();
            lblParam1 = new Label();
            lblParam2 = new Label();
            lblParam3 = new Label();
            lblParam4 = new Label();
            lblParam5 = new Label();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            //
            // backgroundWorker1
            //
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            // 
            // txtParam1
            // 
            txtParam1.Location = new Point(14, 32);
            txtParam1.Margin = new Padding(4, 3, 4, 3);
            txtParam1.Name = "txtParam1";
            txtParam1.Size = new Size(303, 23);
            txtParam1.TabIndex = 1;
            txtParam1.Text = "DefaultConnection";
            // 
            // txtParam2
            // 
            txtParam2.Location = new Point(14, 77);
            txtParam2.Margin = new Padding(4, 3, 4, 3);
            txtParam2.Name = "txtParam2";
            txtParam2.Size = new Size(233, 23);
            txtParam2.TabIndex = 3;
            txtParam2.Text = "DbContext";
            // 
            // txtParam3
            // 
            txtParam3.Location = new Point(14, 122);
            txtParam3.Margin = new Padding(4, 3, 4, 3);
            txtParam3.Name = "txtParam3";
            txtParam3.Size = new Size(303, 23);
            txtParam3.TabIndex = 6;
            // 
            // txtParam4
            // 
            txtParam4.Location = new Point(14, 167);
            txtParam4.Margin = new Padding(4, 3, 4, 3);
            txtParam4.Name = "txtParam4";
            txtParam4.Size = new Size(233, 23);
            txtParam4.TabIndex = 9;
            // 
            // txtParam5
            // 
            txtParam5.Location = new Point(14, 212);
            txtParam5.Margin = new Padding(4, 3, 4, 3);
            txtParam5.Name = "txtParam5";
            txtParam5.Size = new Size(233, 23);
            txtParam5.TabIndex = 12;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(14, 241);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(301, 109);
            txtOutput.TabIndex = 14;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(12, 356);
            btnExecute.Margin = new Padding(4, 3, 4, 3);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(303, 27);
            btnExecute.TabIndex = 15;
            btnExecute.Text = "Gerar Scaffold";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // btnSelectContextFile
            // 
            btnSelectContextFile.Location = new Point(254, 77);
            btnSelectContextFile.Margin = new Padding(4, 3, 4, 3);
            btnSelectContextFile.Name = "btnSelectContextFile";
            btnSelectContextFile.Size = new Size(63, 23);
            btnSelectContextFile.TabIndex = 4;
            btnSelectContextFile.Text = "Browse";
            btnSelectContextFile.UseVisualStyleBackColor = true;
            btnSelectContextFile.Click += btnSelectContextFile_Click;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(254, 167);
            btnSelectFolder.Margin = new Padding(4, 3, 4, 3);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(63, 23);
            btnSelectFolder.TabIndex = 10;
            btnSelectFolder.Text = "Browse";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // btnSelectProjectFile
            // 
            btnSelectProjectFile.Location = new Point(254, 212);
            btnSelectProjectFile.Margin = new Padding(4, 3, 4, 3);
            btnSelectProjectFile.Name = "btnSelectProjectFile";
            btnSelectProjectFile.Size = new Size(63, 23);
            btnSelectProjectFile.TabIndex = 13;
            btnSelectProjectFile.Text = "Browse";
            btnSelectProjectFile.Click += btnSelectProjectFile_Click;
            // 
            // lblParam1
            // 
            lblParam1.AutoSize = true;
            lblParam1.Location = new Point(14, 14);
            lblParam1.Margin = new Padding(4, 0, 4, 0);
            lblParam1.Name = "lblParam1";
            lblParam1.Size = new Size(156, 15);
            lblParam1.TabIndex = 0;
            lblParam1.Text = "Nome da String de Conexão";
            // 
            // lblParam2
            // 
            lblParam2.AutoSize = true;
            lblParam2.Location = new Point(14, 59);
            lblParam2.Margin = new Padding(4, 0, 4, 0);
            lblParam2.Name = "lblParam2";
            lblParam2.Size = new Size(192, 15);
            lblParam2.TabIndex = 2;
            lblParam2.Text = "Arquivo de Contexto (extensão .cs)";
            // 
            // lblParam3
            // 
            lblParam3.AutoSize = true;
            lblParam3.Location = new Point(14, 104);
            lblParam3.Margin = new Padding(4, 0, 4, 0);
            lblParam3.Name = "lblParam3";
            lblParam3.Size = new Size(217, 15);
            lblParam3.TabIndex = 5;
            lblParam3.Text = "Tabelas (Separadas por ponto-e-vírgula)";
            // 
            // lblParam4
            // 
            lblParam4.AutoSize = true;
            lblParam4.Location = new Point(14, 149);
            lblParam4.Margin = new Padding(4, 0, 4, 0);
            lblParam4.Name = "lblParam4";
            lblParam4.Size = new Size(157, 15);
            lblParam4.TabIndex = 8;
            lblParam4.Text = "Pasta de Saída das Entidades";
            // 
            // lblParam5
            // 
            lblParam5.AutoSize = true;
            lblParam5.Location = new Point(14, 194);
            lblParam5.Margin = new Padding(4, 0, 4, 0);
            lblParam5.Name = "lblParam5";
            lblParam5.Size = new Size(107, 15);
            lblParam5.TabIndex = 11;
            lblParam5.Text = "Caminho do Projeto Web";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 386);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(331, 22);
            statusStrip.TabIndex = 16;
            statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 17);
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 408);
            Controls.Add(statusStrip);
            Controls.Add(btnExecute);
            Controls.Add(btnSelectProjectFile);
            Controls.Add(txtParam5);
            Controls.Add(lblParam5);
            Controls.Add(btnSelectFolder);
            Controls.Add(txtParam4);
            Controls.Add(lblParam4);
            Controls.Add(txtParam3);
            Controls.Add(lblParam3);
            Controls.Add(btnSelectContextFile);
            Controls.Add(txtParam2);
            Controls.Add(lblParam2);
            Controls.Add(txtParam1);
            Controls.Add(lblParam1);
            Controls.Add(txtOutput);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainApp";
            Text = "EF Scaffold";
            Load += MainForm_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Executar o comando
            string command = e.Argument.ToString()!;
            e.Result = ExecuteCommand(command);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = e.Result.ToString();
            txtOutput.Clear();
            txtOutput.Text = result;
            btnExecute.Enabled = true;

            if (result.Contains("Exception"))
            {
                MessageBox.Show($"Erro ao executar o comando: {result}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Comando executado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

