﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentingProject {
    class LinkedList {
        Node head;
        public LinkedList(String value) {
            head = new Node(value, null);
        }
    }
}