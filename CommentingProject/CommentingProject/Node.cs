using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentingProject {
    class Node {
        private ArrayList next;
        private Node previous;
        private String value;

        public Node(String valueus, Node previousus) {
            value = valueus;
            previous = previousus;
            next = new ArrayList();
        }

        public String getValue() { return value; }

        public Node getPrevious() { return previous; }

        public ArrayList getNext() { return next; }

        public void addNext(Node newReply) => next.Add(newReply);

    }
}
