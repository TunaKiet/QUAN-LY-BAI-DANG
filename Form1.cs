using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_quan_ly_bai_dang
{
    public partial class Form1 : Form
    {
        string FileImageName = null;
        private PostManager postManager;
        public Form1()
        {
            InitializeComponent();
            postManager = new PostManager();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void LoadImage(ref string imageName)
        {
            OpenFileDialog fileImageName = new OpenFileDialog();
            if(fileImageName.ShowDialog() == DialogResult.OK)
            {
                imageName = fileImageName.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadImage(ref FileImageName);
            pictureBox1.Image = new Bitmap(FileImageName);
           
        }
        private void DeletePost()
        {
            txbTitle.Text = "";
            txbContent.Text = "";
            txbUserName.Text = "";
            pictureBox1.Image = null;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = txbTitle.Text;
            string content = txbContent.Text;
            string username = txbUserName.Text; 
            if(!string.IsNullOrEmpty(title)&& !string.IsNullOrEmpty(content)&& !string.IsNullOrEmpty(username))
            {
                Post newPost = new Post(title, content, username);
                postManager.AddPost(newPost);
                DisplayPosts();
            }
        }
        private bool CheckPost()
        {
            if (txbTitle.Text == "")
            {
                MessageBox.Show("Moi ban nhap tieu de"); 
                return false;
            }
            if (txbContent.Text == "")
            {
                MessageBox.Show("Moi ban nhap noi dung");
                return false;
            }
            if (txbUserName.Text == "")
            {
                MessageBox.Show("Moi ban nhap ten nguoi dung");
                return false;
            }
            return true;
        }
        private void DisplayPosts()
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
