using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentingProject {
    public partial class Form1 : Form {
        private String enteredAuthor, enteredContent;
        private bool buttClicked;
        public Form1()
        {
            InitializeComponent();
            enteredAuthor = "";
            enteredContent = "";
            buttClicked = false;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            enteredAuthor = e.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            enteredContent = e.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttClicked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enteredContent = "";
            enteredAuthor = "";
            this.Close();
        }

        public String getAuthor() { return enteredAuthor; }

        public String getValue() { return enteredContent; }

        public bool getPressed() { return buttClicked; }
    }
}