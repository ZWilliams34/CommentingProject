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
        public String enteredAuthor, enteredContent;
<<<<<<< HEAD
        public Form1()
        {
            InitializeComponent();
            enteredAuthor = "";
            enteredContent = "";
        }
=======
>>>>>>> 55fcf526f627c69729b6bc086e8c621fb4ebf0ad

        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) { }

        private String getAuthor() { return "a"; }

        private String getValue() { return "a"; }
    }
}