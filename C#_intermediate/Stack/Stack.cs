using System;
using System.Collections;
using System.Collections.Generic;

namespace Udemy.Stack
{
   public class Stack
    {
        private readonly List<Object> _stack;

        public Stack()
        {
            _stack = new List<Object>();
        }

        public void Push(object v)
        {
            if (v == null)
            {
                throw new InvalidOperationException("Push1: stack is empty");
            }
            _stack.Add(v);
        }

        public Object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Pop1: stack is empty");
            }

            var lastIndex = _stack.Count - 1;
            var v = _stack[lastIndex];
            _stack.RemoveAt(lastIndex);
            return v;
        }

        public void Clear()
        {
            _stack.Clear();
        }

    }
}
