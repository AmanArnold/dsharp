using System;
using System.Runtime.CompilerServices;

namespace Browser
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("Array")]
    public sealed class JsArray : Array
    {
        public extern Array Concat(params object[] objects);

        public extern bool Every(ArrayFilterCallback filterCallback);

        public extern bool Every(ArrayItemFilterCallback itemFilterCallback);

        public extern JsArray Filter(ArrayFilterCallback filterCallback);

        public extern JsArray Filter(ArrayItemFilterCallback itemFilterCallback);

        public extern void ForEach(ArrayCallback callback);

        public extern void ForEach(ArrayItemCallback itemCallback);

        public extern Array GetRange(int index);

        public extern Array GetRange(int index, int count);

        public extern string Join();

        public extern string Join(string delimiter);

        public extern JsArray Map(ArrayMapCallback mapCallback);

        public extern JsArray Map(ArrayItemMapCallback mapItemCallback);

        [ScriptAlias("ss.toArray")]
        public extern static Array Parse(string s);

        public extern object Reduce(ArrayReduceCallback callback);

        public extern object Reduce(ArrayReduceCallback callback, object initialValue);

        public extern object Reduce(ArrayItemReduceCallback callback);

        public extern object Reduce(ArrayItemReduceCallback callback, object initialValue);

        public extern object ReduceRight(ArrayReduceCallback callback);

        public extern object ReduceRight(ArrayReduceCallback callback, object initialValue);

        public extern object ReduceRight(ArrayItemReduceCallback callback);

        public extern object ReduceRight(ArrayItemReduceCallback callback, object initialValue);

        public extern object Shift();

        public extern JsArray Slice(int start);

        public extern JsArray Slice(int start, int end);

        public extern bool Some(ArrayFilterCallback filterCallback);

        public extern bool Some(ArrayItemFilterCallback itemFilterCallback);

        public extern void Sort(CompareCallback compareCallback);

        public extern void Splice(int start, int deleteCount);

        public extern void Splice(int start, int deleteCount, params object[] itemsToInsert);

        [ScriptAlias("ss.toArray")]
        public extern static Array ToArray(object o);

        public extern void Unshift(params object[] items);
    }
}