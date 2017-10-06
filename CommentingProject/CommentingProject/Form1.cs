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
        private String enteredAuthor, enteredContent, tempAuthor, tempContent;
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
            tempAuthor = e.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tempContent = e.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enteredAuthor = tempAuthor;
            enteredContent = tempContent;
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

        public void setAuthor(String val) { enteredAuthor = val; }

        public void setValue(String val) { enteredContent = val; }

        public bool getPressed() { bool temp = buttClicked; buttClicked = false; return temp; }
    }
}