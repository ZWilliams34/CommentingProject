using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentingProject {
    class LinkedList {
        Node head;

        public LinkedList(String author, String value) { head = new Node(author, value, null); }

        public void comment(String author, String value, Node previous) { previous.addNext(new Node(author, value, previous)); }

        public void remove(Node removal)  { if(removal == head) { head = null; } else { removal.getPrevious().getNext().Remove(removal) ; } }
    }
}