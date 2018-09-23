using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoePitt.WinHasher.Engines;

namespace JoePitt.WinHasher.GUI
{
    public partial class MainUI : Form
    {
        static BackgroundWorker md5Worker = new BackgroundWorker();
        static string computedMD5;
        static BackgroundWorker sha1Worker = new BackgroundWorker();
        static string computedSHA1;
        static BackgroundWorker sha256Worker = new BackgroundWorker();
        static string computedSHA256;
        static BackgroundWorker sha384Worker = new BackgroundWorker();
        static string computedSHA384;
        static BackgroundWorker sha512Worker = new BackgroundWorker();
        static string computedSHA512;
        static BackgroundWorker verifyWorker = new BackgroundWorker();
        static string verifyType;
        static bool verifyTestResult;

        public MainUI()
        {
            InitializeComponent();
            md5Worker.DoWork += Md5Worker_DoWork;
            md5Worker.RunWorkerCompleted += Md5Worker_RunWorkerCompleted;
            sha1Worker.DoWork += Sha1Worker_DoWork;
            sha1Worker.RunWorkerCompleted += Sha1Worker_RunWorkerCompleted;
            sha256Worker.DoWork += Sha256Worker_DoWork;
            sha256Worker.RunWorkerCompleted += Sha256Worker_RunWorkerCompleted;
            sha384Worker.DoWork += Sha384Worker_DoWork;
            sha384Worker.RunWorkerCompleted += Sha384Worker_RunWorkerCompleted;
            sha512Worker.DoWork += Sha512Worker_DoWork;
            sha512Worker.RunWorkerCompleted += Sha512Worker_RunWorkerCompleted;
            verifyWorker.DoWork += VerifyWorker_DoWork;
            verifyWorker.RunWorkerCompleted += VerifyWorker_RunWorkerCompleted;

            computeMD5.Checked = Properties.Settings.Default.EnableMD5;
            computeSHA1.Checked = Properties.Settings.Default.EnableSHA1;
            computeSHA256.Checked = Properties.Settings.Default.EnableSHA256;
            computeSHA384.Checked = Properties.Settings.Default.EnableSHA384;
            computeSHA512.Checked = Properties.Settings.Default.EnableSHA512;

            hashType.SelectedItem = Properties.Settings.Default.VerifyType;
        }

        private void InputFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DereferenceLinks = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Multiselect = false,
                Title = "Select file to Hash/Verify"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(fileDialog.FileName))
                {
                    inputFilePath.Text = fileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("The specified file does not exist. Please try again", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ComputeHashes_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EnableMD5 = computeMD5.Checked;
            Properties.Settings.Default.EnableSHA1 = computeSHA1.Checked;
            Properties.Settings.Default.EnableSHA256 = computeSHA256.Checked;
            Properties.Settings.Default.EnableSHA384 = computeSHA384.Checked;
            Properties.Settings.Default.EnableSHA512 = computeSHA512.Checked;
            Properties.Settings.Default.Save();

            md5Hash.Clear();
            sha1Hash.Clear();
            sha256Hash.Clear();
            sha384Hash.Clear();
            sha512Hash.Clear();

            if (!File.Exists(inputFilePath.Text))
            {
                MessageBox.Show("The specified file does not exist. Please try again", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (computeMD5.Checked)
            {
                LockUI();
                md5Hash.Text = "Computing...";
                md5Worker.RunWorkerAsync();
            }
            if (computeSHA1.Checked)
            {
                LockUI();
                sha1Hash.Text = "Computing...";
                sha1Worker.RunWorkerAsync();
            }
            if (computeSHA256.Checked)
            {
                LockUI();
                sha256Hash.Text = "Computing...";
                sha256Worker.RunWorkerAsync();
            }
            if (computeSHA384.Checked)
            {
                LockUI();
                sha384Hash.Text = "Computing...";
                sha384Worker.RunWorkerAsync();
            }
            if (computeSHA512.Checked)
            {
                LockUI();
                sha512Hash.Text = "Computing...";
                sha512Worker.RunWorkerAsync();
            }
        }

        private void VerifyHash_Click(object sender, EventArgs e)
        {
            if (!File.Exists(inputFilePath.Text))
            {
                MessageBox.Show("The specified file does not exist. Please try again", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hashType.SelectedIndex == -1)
            {
                MessageBox.Show("Select a hash type first.", "Hash Type Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.VerifyType = hashType.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            LockUI();
            verifyResult.Text = "Checking...";
            verifyType = hashType.SelectedItem.ToString();
            verifyResult.BackColor = Color.LightGray;
            verifyWorker.RunWorkerAsync();
        }

        private void LockUI()
        {
            inputFileBrowse.Enabled = false;
            computeHashes.Enabled = false;
            computeMD5.Enabled = false;
            computeSHA1.Enabled = false;
            computeSHA256.Enabled = false;
            computeSHA384.Enabled = false;
            computeSHA512.Enabled = false;
            verifyHash.Enabled = false;
            hashType.Enabled = false;
            expectedHash.Enabled = false;
        }

        private void UnlockUI()
        {
            if (!md5Worker.IsBusy && !sha1Worker.IsBusy && !sha256Worker.IsBusy &&
                !sha384Worker.IsBusy && !sha512Worker.IsBusy && !verifyWorker.IsBusy)
            {
                inputFileBrowse.Enabled = true;
                computeHashes.Enabled = true;
                verifyHash.Enabled = true;
                computeMD5.Enabled = true;
                computeSHA1.Enabled = true;
                computeSHA256.Enabled = true;
                computeSHA384.Enabled = true;
                computeSHA512.Enabled = true;
                hashType.Enabled = true;
                expectedHash.Enabled = true;
            }
        }

        private void Md5Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Stream stream = File.OpenRead(inputFilePath.Text);
            string hash = MD5.Hash(stream);
            computedMD5 = Formatter.HashTidy(hash);
        }

        private void Md5Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            md5Hash.Text = computedMD5;
            UnlockUI();
        }

        private void Sha1Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Stream stream = File.OpenRead(inputFilePath.Text);
            string hash = SHA1.Hash(stream);
            computedSHA1 = Formatter.HashTidy(hash);
        }

        private void Sha1Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sha1Hash.Text = computedSHA1;
            UnlockUI();
        }

        private void Sha256Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Stream stream = File.OpenRead(inputFilePath.Text);
            string hash = SHA256.Hash(stream);
            computedSHA256 = Formatter.HashTidy(hash);
        }

        private void Sha256Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sha256Hash.Text = computedSHA256;
            UnlockUI();
        }

        private void Sha384Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Stream stream = File.OpenRead(inputFilePath.Text);
            string hash = SHA384.Hash(stream);
            computedSHA384 = Formatter.HashTidy(hash);
        }

        private void Sha384Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sha384Hash.Text = computedSHA384;
            UnlockUI();
        }

        private void Sha512Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Stream stream = File.OpenRead(inputFilePath.Text);
            string hash = SHA512.Hash(stream);
            computedSHA512 = Formatter.HashTidy(hash);
        }

        private void Sha512Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sha512Hash.Text = computedSHA512;
            UnlockUI();
        }

        private void VerifyWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Stream stream = File.OpenRead(inputFilePath.Text);
            switch (verifyType)
            {
                case "MD5":
                    verifyTestResult = MD5.Verify(stream, expectedHash.Text);
                    break;
                case "SHA1":
                    verifyTestResult = SHA1.Verify(stream, expectedHash.Text);
                    break;
                case "SHA256":
                    verifyTestResult = SHA256.Verify(stream, expectedHash.Text);
                    break;
                case "SHA384":
                    verifyTestResult = SHA384.Verify(stream, expectedHash.Text);
                    break;
                case "SHA512":
                    verifyTestResult = SHA512.Verify(stream, expectedHash.Text);
                    break;
                default:
                    MessageBox.Show("Select a hash type first.", "Hash Type Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void VerifyWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (verifyTestResult)
            {
                verifyResult.Text = "Hashes Match";
                verifyResult.BackColor = Color.LightGreen;
            }
            else
            {
                verifyResult.Text = "Hashes Do Not Match";
                verifyResult.BackColor = Color.PaleVioletRed;
            }
            UnlockUI();
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            about.Dispose();
        }

        private void ProjectPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://www.joepitt.co.uk/Project/WinHasher/");

        private void SourceCodeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://github.com/joepitt91/WinHasher");
    }
}
