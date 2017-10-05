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
        private String author;
        private String post;

        public Node(String auth, String posted, Node previousus) {
            author = auth;
            post = posted;
            previous = previousus;
            next = new ArrayList();
        }

        public String getAuthor() { return author; }

        public String getPost() { return post; }

        public Node getPrevious() { return previous; }

        public ArrayList getNext() { return next; }

        public void addNext(Node newReply) => next.Add(newReply);
    }
}
