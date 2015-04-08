using System;
using DuoCode.Runtime;

namespace Knockout.DuoCode
{
    [Js(Extern = true)]
    public class Subscription : IDisposable
    {
        [Js(Name = "dispose")]
        public extern void Dispose();
    }
}