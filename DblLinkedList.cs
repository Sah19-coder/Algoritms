using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorims
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }
    public interface ILinkedList
    {
        int GetCount();
        void AddNode(int value);
        void AddNodeAfter(Node node, int value)
        void RemoveNode(int index);
        void RemoveNode(Node node);

    }
    internal class DblLinkedList : ILesson, ILinkedList
    {
        public void AddNode(int value)
        {
            throw new NotImplementedException();
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        public bool DoTest()
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }
    }
}
 