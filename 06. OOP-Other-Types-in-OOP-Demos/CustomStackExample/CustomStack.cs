namespace CustomStackExample
{
    using System;
    using System.Linq;

    public class CustomStack<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int currentIndex;

        public int Count
        {
            get { return this.currentIndex; }
        }

        public bool IsEmpty
        {
            get { return this.currentIndex == 0; }
        }

        public CustomStack(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.currentIndex = 0;
        }

        public void Push(T element)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.currentIndex] = element;
            this.currentIndex++;
        }

        public T Pop()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T topElement = this.elements[this.currentIndex - 1];
            this.elements[this.currentIndex - 1] = default(T);
            this.currentIndex--;

            return topElement;
        }

        public void Clear()
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                this.elements[i] = default(T);
            }

            this.currentIndex = 0;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T min = this.elements[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.CompareTo(min) < 0)
                {
                    min = currentElement;
                }
            }

            return min;
        }

        private void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        public override string ToString()
        {
            var resultElements = this.elements.Take(this.currentIndex);

            return string.Join(", ", resultElements);
        }
    }
}
