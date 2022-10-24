// See https://aka.ms/new-console-template for more information

using Ds_Al.LinkedList;

Node newnode = new Node(5);
newnode.InsertEndNode(newnode,7);
newnode.InsertEndNode(newnode,1);
newnode.InsertEndNode(newnode,4);
newnode.InsertHeadNode(newnode, 2);
newnode.PrintNodeValue(newnode);
