using System;
using DuoCode.Runtime;

namespace Knockout
{
    [Js(Name = "ko.observable", Extern = true)]
    public class Observable<T>
    {
        [Js(Name = "subscribe", OmitGenericArgs = true)]
        public extern Subscription Subscribe(Action<T> value);

        [Js(Name = "extend")]
        internal extern Observable<T> Extend(object options);
    }
}