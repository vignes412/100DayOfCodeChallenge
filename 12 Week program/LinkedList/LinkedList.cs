
using System.Security.Principal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace LinkedList
{
    public class MyLinkedList
    {
        public int Length { get; set; }
        public Node Root { get; set; }
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            var temp = Root;
            int count = 0;

            while(temp!=null)
            {
                if (count == index)
                {
                    return temp.Data;
                }
                temp = temp.Next;
                count++;
            }
            return 0;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            var newNode = new Node(val);
            if (Root == null)
            {
                Root = newNode;
                Length++;
                return;
            }
            else
            {
                newNode.Next = Root;
                Root = newNode;
                Length++;
                return;
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            var newNode = new Node(val);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
            Node curr = Root;
            Node prev = Root;
            while (curr != null)
            {
                prev = curr;
                curr = curr.Next;
            }
            prev.Next = newNode;
            return;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            var newNode = new Node(val);
            if(Root == null)
            {
                Root = newNode;
                return;
            }
            
            Node curr = Root;
            Node prev = Root;
            int count = 0;
            if (index == 0)
            {
                newNode.Next = Root;
                Root = newNode;
                return;
            }
            while (curr != null)
            {
                prev = curr;
                curr = curr.Next;
                count++;
                if (index == count && curr!=null)
                {
                    newNode.Next = curr;
                    prev.Next = newNode;
                }
            }
            return;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (Root == null)
                return;
            Node curr = Root;
            Node prev = Root;
            int Count = 0;
            if (index == 0)
            {
                Root = curr.Next;
                return;
            }
            while (curr != null)
            {
                prev = curr;
                curr = curr.Next;
                Count++;
                if (Count == index && curr!=null)
                {
                    prev.Next = curr.Next;
                    curr.Next = null;
                }
            }
        }
    }
}