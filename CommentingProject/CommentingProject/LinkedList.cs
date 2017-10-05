using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentingProject {
    class LinkedList {
        Node head;
<<<<<<< HEAD
        public LinkedList() {
            head = null;
        }

        public void post(String value) {
            if(head == null) {
                head = new Node(value, null);
            } else {

            }
        }
=======
        public LinkedList(String value) { head = new Node(value, null); } 
>>>>>>> 4639c03e2d48fd476b9d6eda489f2147c5f5ec77
    }
}