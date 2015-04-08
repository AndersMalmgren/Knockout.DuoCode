using System;
using DuoCode.Runtime;

namespace Knockout.DuoCode
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
    }
}