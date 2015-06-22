using System.Collections;
using System.Collections.Generic;

class LinkedListEnumerator<T> : IEnumerator<T>
{
    private LinkedList<T> initialNode;
    private LinkedList<T> currentNode;
    private bool isStarted = false;

    public LinkedListEnumerator(LinkedList<T> firstNode)
    {
        this.currentNode = firstNode;
        this.initialNode = firstNode;
    }

    public T Current
    {
        get { return this.currentNode.Value; }
    }

    object IEnumerator.Current
    {
        get { return this.currentNode.Value; }
    }

    public bool MoveNext()
    {
        if (!this.isStarted)
        {
            this.isStarted = true;
            return true;
        }

        if (this.currentNode.NextNode != null)
        {
            this.currentNode = this.currentNode.NextNode;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        this.isStarted = false;
        this.currentNode = this.initialNode;
    }

    public void Dispose()
    {
    }
}
