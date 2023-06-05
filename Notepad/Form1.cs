using System;
using System.IO;
using System.Text;
namespace Notepad
{
    public partial class Mainform : Form
    {
        public File file = new File("","");
        public SaveFileDialog SaveFileDialog = new SaveFileDialog();
        public OpenFileDialog OpenFileDialog = new OpenFileDialog();

        public Mainform()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file.Path = OpenFileDialog.FileName;
                    StreamReader sr = new StreamReader(file.Path);
                    file.Content = sr.ReadToEnd();
                    MainTextBox.Text = file.Content;
                    sr.Close();
                }
                catch(Exception exc)
                {
                    MainTextBox.Text = $"Error while opening file :( {exc}";
                }
            }
            else
            {
                MainTextBox.Text = $"Error while loading file picking window :(";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just a copy of window's notepad", "About");
        }

        public void Mainform_Shown(object sender, EventArgs e)
        {
            
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file.Path = SaveFileDialog.FileName;
                    file.Content = MainTextBox.Text;
                    StreamWriter sw = new StreamWriter(file.Path);
                    sw.Write(file.Content);
                    sw.Close();
                }
                catch(Exception exc) 
                {
                    MainTextBox.Text = $"Error while saving file :( {exc}";
                }
            }
            else
            {

            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(file.Path);
            file.Content = MainTextBox.Text;
            sw.Write(file.Content);
            sw.Close();
        }
    }
}