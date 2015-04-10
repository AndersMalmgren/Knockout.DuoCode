using System;
using DuoCode.Runtime;

namespace Knockout.ObserverableExtenders
{
    public class Extenders
    {
        private readonly static Action<string, object> register = Js.referenceAs<Action<string, object>>(@"(function(name, extender) {
       ko.extenders[name] = extender.Extend;
})");

        public Extenders Register<TExtender>() where TExtender : IObservableExtender, new()
        {
            return Register(new TExtender());
        }

        public Extenders Register<TExtender>(TExtender instance) where TExtender : IObservableExtender
        {
            register(typeof(TExtender).Name, instance);
            return this;
        }
    }
}