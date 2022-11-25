using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class Array
    {
        private int[] arr;
        private int initialPointer;
        private int finalPointer;

        // Constructor of the array
        public Array()
        {
            this.arr = new int[10];
            this.initialPointer = 0;
            this.finalPointer = 0;
        }
        public int size()
        {
            return finalPointer;
        }
        public bool isEmpty()
        {
            return initialPointer == finalPointer;
        }

        //at(index) returns item at given index, blows up if index out of bound
        public int at(int index)
        {
            if (!isEmpty())
            {
                if (index >= 0 && index < finalPointer)
                {
                    return arr[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice inexistente");
                }
            }
            else
            {
                throw new ArgumentNullException("Lista vazia");
            }
        }

        public void push(int item)
        {
            resizeUp();
            arr[finalPointer] = item;
            finalPointer++; 
        }

        public void insert (int index, int item)
        {
            resizeUp();
           for (int i = finalPointer; i > index; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[index] = item;
            finalPointer++;
            
        }

        //prepend(item) can use insert above at index 0;
        public void prepend(int item)
        {
            resizeUp();
            for (int i = finalPointer; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = item;
            finalPointer++;
        }

        public int pop()
        {
            if (!isEmpty())
            {
                resizeDown();
                int tmp = arr[finalPointer];
                finalPointer--;
                return tmp;
            }
            else
            {
                throw new ArgumentNullException("Lista vazia");
            }
        }

        public void delete(int index)
        {
            if (!isEmpty())
            {
                for (int i = index; i < finalPointer; i++)
                {
                    arr[i] = arr[i + 1];
                }
                pop();
            }
            else
            {
                throw new ArgumentNullException("Lista vazia");
            }
        }

        public void remove (int item)
        {
            if (!isEmpty())
            {
                for (int i = 0; i < size(); i++)
                {
                    if (arr[i] == item)
                    {
                        delete(i);
                    }
                }
            }
            else
            {
                throw new ArgumentNullException("Lista vazia");
            }
        }

        public int findFirst (int item)
        {
            if (!isEmpty())
            {
                for (int i = 0; i < size(); i++)
                {
                    if (arr[i] == item)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else
            {
                throw new ArgumentNullException("Lista vazia");
            }
        }

        public void resizeUp()
        {
            if (finalPointer == arr.Length)
            {
               int[] newArray = new int[2 * arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArray[i] = arr[i];
                }
                this.arr = newArray;
            }
        }

        public void resizeDown()
        {
            if (finalPointer == arr.Length/4)
            {
                int[] newArray = new int[arr.Length/2];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = arr[i];
                }
                this.arr = newArray;
            }
        }

        public int vectorLen()
        {
            return arr.Length;
        }

    }
}
