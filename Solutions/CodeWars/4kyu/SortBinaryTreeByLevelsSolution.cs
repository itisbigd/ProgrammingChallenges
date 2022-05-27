using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingChallenges.Solutions.CodeWars._4kyu
{
    public static class SortBinaryTreeByLevelsSolution
    {
        public static List<int> TreeByLevels(Node node)
        {
            
            return null;
        }
    }
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }
}
