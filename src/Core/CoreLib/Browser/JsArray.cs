using System;
using System.Runtime.CompilerServices;

namespace Browser
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("Array")]
    public sealed class JsArray : Array
    {
        public bool Every(ArrayFilterCallback filterCallback)
        {
            return false;
        }

        public bool Every(ArrayItemFilterCallback itemFilterCallback)
        {
            return false;
        }

        public Array Filter(ArrayFilterCallback filterCallback)
        {
            return null;
        }

        public Array Filter(ArrayItemFilterCallback itemFilterCallback)
        {
            return null;
        }

        public void ForEach(ArrayCallback callback)
        {
        }

        public void ForEach(ArrayItemCallback itemCallback)
        {
        }

        public Array Map(ArrayMapCallback mapCallback)
        {
            return null;
        }

        public Array Map(ArrayItemMapCallback mapItemCallback)
        {
            return null;
        }

        public object Reduce(ArrayReduceCallback callback)
        {
            return null;
        }

        public object Reduce(ArrayReduceCallback callback, object initialValue)
        {
            return null;
        }

        public object Reduce(ArrayItemReduceCallback callback)
        {
            return null;
        }

        public object Reduce(ArrayItemReduceCallback callback, object initialValue)
        {
            return null;
        }

        public object ReduceRight(ArrayReduceCallback callback)
        {
            return null;
        }

        public object ReduceRight(ArrayReduceCallback callback, object initialValue)
        {
            return null;
        }

        public object ReduceRight(ArrayItemReduceCallback callback)
        {
            return null;
        }

        public object ReduceRight(ArrayItemReduceCallback callback, object initialValue)
        {
            return null;
        }

        public bool Some(ArrayFilterCallback filterCallback)
        {
            return false;
        }

        public bool Some(ArrayItemFilterCallback itemFilterCallback)
        {
            return false;
        }

        public void Sort(CompareCallback compareCallback)
        {
        }
    }
}