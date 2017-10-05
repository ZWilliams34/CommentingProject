using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentingProject {
    class Node {
        private Node[,] next;
        private Node previous;
        private String value;

        public Node(String valueus, Node previousus, Node[,] nextus) {
            value = valueus;
            previous = previousus;
            next = nextus;
        }
    }
}
