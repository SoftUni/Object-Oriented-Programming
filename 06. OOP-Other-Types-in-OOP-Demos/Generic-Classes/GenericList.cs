using System;

public class GenericList<T> 
{
	const int DefaultCapacity = 4096;

	private T[] elements;
	private int count = 0;

	public GenericList(int capacity = DefaultCapacity)
	{
		this.elements = new T[capacity];
	}

    public int Count 
	{
		get 
		{
			return this.count;
		}
	}

	public void Add(T element)
	{
		if (this.count >= this.elements.Length) 
		{
			throw new IndexOutOfRangeException(String.Format(
				"The list capacity of {0} was exceeded.", this.elements.Length));
		}
		this.elements[this.count] = element;
		this.count++;
	}

	public T this[int index]
	{
		get
		{
			if (index < 0 || index >= this.count)
			{
				throw new IndexOutOfRangeException(String.Format(
					"Invalid index: {0}.", index));
			}

			T result = this.elements[index];

			return result;
		}
	}
}
