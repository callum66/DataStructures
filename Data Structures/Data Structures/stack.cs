using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class stack
    {
        int[] Stack;
        int sp;
        int max;

        public stack(int size)
        {
            max = size;
            Stack = new int[max];
            sp = 0;
        }
        public void push(int item)
        {

            if (sp < max)
            {
                Stack[sp] = item;
                sp++;
            }
        }
        public int pop()
        {
            if (sp > 0)
            {
                //sp--;
                return Stack[--sp];
            }
            
                throw new Exception("STACK EMPTY");

        }
    }
}
