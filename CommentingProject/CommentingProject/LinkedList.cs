using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentingProject {
    class LinkedList {
        Node head;
<<<<<<< HEAD
        public LinkedList(String value) {
            head = new Node(value, null);
        }
=======

        public LinkedList(String value) { head = new Node(value, null); }

        public void comment(String value, Node previous) { previous.addNext(new Node(value, previous)); }

        public void remove(Node removal)  { if(removal == head) { head = null; } else { removal.getPrevious().getNext().Remove(removal) ; } }
>>>>>>> 3c03d147f68cbc17e8296d761161c47156f7a452
    }
}