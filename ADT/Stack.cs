using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Stack
    {
        private int size;
        private int[] items;
        private int head;

        public Stack(int theSize)
        {
            this.size = theSize;
            this.head = 0;
            this.items = new int[size];
        }

        public void push(int newValue) 
        {
            if (head == size)
            {
                Console.WriteLine("The array is full ");
            }
            else
            {
                items[head++] = newValue;
            }
        }
        public int pop() 
        {
            if (head == 0)
            {
                Console.WriteLine("The array is empty.");
                return -1;
            }
            else
            {
                return items[--head];
            }
        }
        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            details.AppendLine("Stack contains");
            foreach (var item in items)
            {
                details.AppendLine(items.ToString());
            }
            return details.ToString();
        }
    }
}
