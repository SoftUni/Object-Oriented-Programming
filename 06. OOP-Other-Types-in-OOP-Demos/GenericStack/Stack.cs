namespace GenericStack
{
    using System;
    using System.Linq;

    public class Stack<T> 
        where T : IComparable<T>, IEquatable<T>
    {
        private T[] elements;
        private int index;

        public Stack()
        {
            this.elements = new T[16];
            this.index = 0;
        }

        public int Count
        {
            get
            {
                return this.index;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return this.index == 0;
            }
        }

        public void Push(T element)
        {
            if (this.index == this.elements.Length)
            {
                this.Resize();    
            }

            this.elements[this.index] = element;
            this.index++;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.index; i++)
            {
                T current = this.elements[i];
                if (current.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public T Max()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T max = this.elements[0];
            for (int i = 1; i < this.index; i++)
            {
                T current = this.elements[i];
                if (current.CompareTo(max) == 1)
                {
                    max = current;
                }
            }

            return max;
        }

        public T Pop()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T element = this.elements[this.index - 1];
            this.elements[this.index] = default(T);
            this.index--;

            return element;
        }

        public void Clear()
        {
            for (int i = 0; i < this.index; i++)
            {
                this.elements[i] = default(T);
            }
        }

        private void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];
            for (int i = 0; i < this.index; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        public override string ToString()
        {
            var realElements = this.elements
                .Take(this.index);

            return string.Join(", ", realElements);
        }
    }
}
