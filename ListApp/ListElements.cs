using System;
using System.Collections.Generic;
using System.Text;

namespace ListApp
{
    /// <summary>
    /// Один экземпляр списка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListElements<T>
    {
        public ListElements(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public ListElements<T> Next { get; set; }
    }
}
