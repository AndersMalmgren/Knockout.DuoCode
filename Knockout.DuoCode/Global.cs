using System;
using DuoCode.Runtime;

namespace Knockout.DuoCode
{
    [Js(Name = "ko", Extern = true)]
    public static class Global
    {
        [Js(Name = "observable", OmitGenericArgs = true)]
        public static extern Observable<T> Observable<T>();

        [Js(Name = "observable", OmitGenericArgs = true)]
        public static extern Observable<T> Observable<T>(T value);

        [Js(Name = "observableArray", OmitGenericArgs = true)]
        public static extern ObservableArray<T> ObservableArray<T>(object[] values); //DuoCode compiler cant handle T[] as argument as of current beta

        [Js(Name = "observableArray", OmitGenericArgs = true)]
        public static extern ObservableArray<T> ObservableArray<T>();

        [Js(Name = "computed", OmitGenericArgs = true)]
        public static extern Observable<T> Computed<T>(Func<T> computed);

        [Js(Name = "applyBindings")]
        public static extern void ApplyBindings(object viewModel);

    }
}