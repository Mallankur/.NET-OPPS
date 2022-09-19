using System;
using System.Collections.Generic;

namespace ServerChat_piolet_projet
{

   
        public class stack
        {
            private readonly List<object> _list = new List<object>();
            public void Push(object obj)
            {
                if(obj == null)
                {
                    throw new InvalidOperationException("you can not add a null object to the stack.");
                }
                _list.Add(obj);
            }

            public Object Pop()
            {
                if (_list.Count == 0) throw new InvalidOperationException("There are no element in the stack yet.");
                 var index = _list.Count - 1;
                var toReturn= _list[index];
                _list.RemoveAt(index);
                return toReturn;

            }

        }

    }

