using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficManager {
    internal class Queue {
        private int[] arr;
        private int front ;
        private int currSize;
        private int size;

        public Queue(int size) {
            this.size = size;
            arr = new int[size];
            front = 0;
            currSize = 0;
        }

        public int Push(int data) {
            if(currSize == size) return -1;
            
            int rear = (front + currSize) % size;
            arr[rear] = data;
            currSize++;

            return 1;
        }

        public int Pop() {
            if(currSize == 0) return -1;

            int res = arr[front];
            front = (front + 1) % size;
            currSize--;

            return res;
        }

        public int Peek() { 
            if(currSize == 0) return -1;

            return arr[front];
        }
    }
}
