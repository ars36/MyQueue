﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   */

namespace MyQueue
{
    class MyQueueCls<T> //by default the class is in internal
    {
        private int head;
        private int tail;
        private int count;
        private T[] q;
        private int deFaultQueSize=50;

        public MyQueueCls()
        {
            q= new T[deFaultQueSize];
            count=0;
            head=0;
            tail=0;
        }

        public MyQueueCls(int size)
        {
            if (size > 0)
            {
                deFaultQueSize = size;
                q = new T[deFaultQueSize];
                count = 0;
                head=0;
                tail=0;
            }
            else
            {
                //throw new Exception("Size cannot be equal or smaller than zero");
                Console.WriteLine("Size has to be grater than 0!\nIntiallizing with default values...");
                q = new T[deFaultQueSize];  //this should work as well
                count = 0;
                head = 0;
                tail = 0;
            }     
            
        }

        public void Enqueue(T num) 
        {
            if(count >= deFaultQueSize) 
            {
                //throw new Exception("Queue is full");
                System.Console.WriteLine("Queue is full");
            }
            else
            {
                q[head] = num;
                /*count++;
                head++;
                head%= deFaultQueSize;  */
                head = (head +1) % deFaultQueSize;
                count++;
            }
        }

        public T Dequeue()
        {
            if(count<=0)
            {
                //throw new Exception("Queue is already empty");
                return default;
            }
            else
            {
                T rValue= q[tail];
               // tail++;
               // tail%= deFaultQueSize;
               tail = (tail+1)% deFaultQueSize;
                count--;
                return rValue;
            }
        }public bool IsEmpty(){return count==0;}

    }
}
