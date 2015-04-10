using System;
using DuoCode.Runtime;

namespace Knockout
{
    [Js(Name = "ko.observableArray", Extern = true)]
    public class ObservableArray<T> : Observable<JsArray<T>>
    {
        [Js(Name = "push", OmitGenericArgs = true)]
        public extern void Push(T value);

        [Js(Name = "remove", OmitGenericArgs = true)]
        public extern T[] Remove(T item);

        [Js(Name = "remove", OmitGenericArgs = true)]
        public extern T[] Remove(Predicate<T> predicate);

        [Js(Name = "removeAll")]
        public extern T[] RemoveAll();

        [Js(Name = "sort", OmitGenericArgs = true)]
        public extern void Sort(Func<T, T, int> sort);

        [Js(Name = "sort")]
        public extern void Sort();

        [Js(Name = "splice")]
        public extern T[] Splice(int start, int length);
        
    }
}