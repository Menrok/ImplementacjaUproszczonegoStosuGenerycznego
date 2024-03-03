using System.Collections.Generic;

namespace StrukturaStos
{
    public class Stos<T> : IStos<T>
    {
        private readonly List<T> elements;

        public Stos()
        {
            elements = new List<T>();
        }

        public void Push(T value)
        {
            elements.Add(value);
        }

        public T Peek
        {
            get
            {
                if (IsEmpty)
                {
                    throw new StosEmptyException("Stos jest pusty");
                }

                return elements[Count - 1];
            }
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new StosEmptyException("Nie można usunąć elementu - stos jest pusty");
            }

            T removedItem = elements[Count - 1];
            elements.RemoveAt(Count - 1);
            return removedItem;
        }

        public int Count
        {
            get { return elements.Count; }
        }

        public bool IsEmpty
        {
            get { return elements.Count == 0; }
        }

        public void Clear()
        {
            elements.Clear();
        }

        public T[] ToArray()
        {
            return elements.ToArray();
        }
    }
}