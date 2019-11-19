using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    public partial class LinkList
    {
        public class Node
        {
            public LinkList Value { get; set; }
            public Node Next { get; set; }
            public LinkList Cost { get; set; }
        }
        public void Push(LinkList value)
        {
            Size++;
            var node = new Node() { Value = value };
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Current.Next = node;
            }
            Current = node;

        }


        public void ListNodes()
        {
            Node tempNode = Head;

            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(tempNode.Value);
                tempNode = tempNode.Next;
            }
        }

        public LinkList this[int position]
        {
            get
            {
                Node tempNode = Head;
                for (int i = 0; i < position; ++i)
                    //переходим к следующему узлу списка
                    tempNode = tempNode.Next;
                return tempNode.Value;
            }
        }
        public void DeleteNode(int number)
        {

            if ((Head != null) && (number < Size) && (number >= 0))
            {
                Node tempNode = Head;
                Node prevNode = null;
                for (int i = 0; i < number; i++)
                {
                    prevNode = tempNode;
                    tempNode = tempNode.Next;

                }


                if (tempNode == Head)
                {

                    prevNode = tempNode;
                    tempNode = tempNode.Next;
                    Head = tempNode;
                    Size--;
                }
                else
                {


                    prevNode = tempNode.Next;
                    Size--;

                }

            }


        }
        private Node Head { get; set; }
        private Node Tails { get; set; }
        private Node Current { get; set; }
        private Node Current1 { get; set; }
        public int Size { get; set; }
        public int Cost { get; set; }
    }
}
