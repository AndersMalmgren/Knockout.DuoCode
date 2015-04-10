using System;
using DuoCode.Runtime;
using Knockout.ObserverableExtenders;

namespace Knockout
{
    public static class ObservableExtensions
    {
        public static void Set<T>(this Observable<T> observable, T value)
        {
            observable.As<Action<T>>()(value);
        }

        public static T Get<T>(this Observable<T> observable)
        {
            return observable.As<Func<T>>()();
        }

        public static ExtendResult<T> Extend<T>(this Observable<T> observable)
        {
            return new ExtendResult<T>(observable);
        }
    }
}