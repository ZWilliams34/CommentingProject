using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentingProject {
    class LinkedList {
        Node head;
        public LinkedList() {
            head = null;
        }

        public void post(String value) {
            if(head == null) {
                head = new Node(value, null);
            } else {

            }
        }
    }
}
