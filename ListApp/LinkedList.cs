using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListApp
{
    public class LinkedList<T> : IEnumerable<T>
    {
        ListElements<T> firstElement;
        ListElements<T> lastElement;
        int count;

        /// <summary>
        /// Добавление в конец списка
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            var newListElement = new ListElements<T>(data);

            if (firstElement == null)
                firstElement = newListElement;
            else
                lastElement.Next = newListElement;

            lastElement = newListElement;
            count++;
        }

        /// <summary>
        /// Удаление по значению
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Remove(T data)
        {
            var current = firstElement;
            ListElements<T> previous = null;

            while (current != null)
            {
                if(current.Data.Equals(data))
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next;
                        if(current.Next == null)
                            lastElement = previous;
                    }
                    else
                    {
                        firstElement = firstElement.Next;

                        if (firstElement == null)
                            lastElement = null;
                    }

                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public bool Contains(T data)
        {
            var current = firstElement;
            while(current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Вывод количества элементов
        /// </summary>
        /// <returns></returns>
        public int Count() => count;


        /// <summary>
        /// интерфейс IEnumerable для цикла foreach
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = firstElement;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        /// <summary>
        /// Вставка по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <param name="data"></param>
        public void InsertOf(int index, T data)
        {
            var newListElement = new ListElements<T>(data);
            var current = firstElement;
            ListElements<T> previous = null;

            while(index > 0 && current != null)
            {
                previous = current;
                current = current.Next;
                index --;
            }
            if(current != null)
            {
                newListElement.Data = data;
                newListElement.Next = current;
                if (previous == null)
                    firstElement = newListElement;
                else
                    previous.Next = newListElement;
            }
            count++;
        }

        /// <summary>
        /// Удаление по индексу
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            var current = firstElement;

                for (int i = 0; i <= index && current != null; i++)
                {
                    if (i != index)
                    {
                        current = current.Next;
                    }
                    else Remove(current.Data);
                }
        }
    }
}
