using System;
using System.Collections.Generic;
using DuoCode.Runtime;

namespace Knockout.ObserverableExtenders
{
    public class ExtendResult<T>
    {
        private readonly Observable<T> observable;
        private readonly Dictionary<string, object> extensions = new Dictionary<string, object>();

        public ExtendResult(Observable<T> observable)
        {
            this.observable = observable;
        }

        public ExtendResult<T> With<TExtension, TOptions>(TOptions options) where TExtension : IObservableExtender
        {
            Add(typeof(TExtension), options);
            return this;
        }

        public ExtendResult<T> With<TExtension>() where TExtension : IObservableExtender
        {
            Add(typeof (TExtension), null);
            return this;
        }

        private void Add(Type type, object option)
        {
            var name = type.Name;
            if (IsExtern(type))
            {
                var getNameFromScope = Js.referenceAs<Func<object, string>>(@"(function(e) {
    for(var index in ko.extenders) {
        if(ko.extenders[index] === e.self) {
            return index;
        }
    }
})");
                name = getNameFromScope(type);
            }

            extensions[name] = option;
        }

        private bool IsExtern(Type type)
        {
            return type.BaseType == null;
        }

        public Observable<T> Done()
        {
            object options = null;
            var optionsBuilder = Js.referenceAs<Func<string, object, object, object>>(@"(function(name, option, options) {
    options = options || {};
    options[name] = option;
    return options;
})");
            foreach (var e in extensions)
                options = optionsBuilder(e.Key, e.Value, options);

            return observable.Extend(options);
        }
    }
}