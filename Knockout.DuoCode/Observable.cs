using System;
using DuoCode.Runtime;

namespace Knockout.DuoCode
{
    [Js(Name = "ko.observable", Extern = true)]
    public class Observable<T>
    {
        [Js(Name = "subscribe", OmitGenericArgs = true)]
        public extern Subscription Subscribe(Action<T> value);

        [Js(Name = "extend")]
        public extern Observable<T> Extend(object options);
    }
}