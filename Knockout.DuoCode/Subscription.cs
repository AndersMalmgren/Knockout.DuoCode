using System;
using DuoCode.Runtime;

namespace Knockout
{
    [Js(Extern = true)]
    public class Subscription : IDisposable
    {
        [Js(Name = "dispose")]
        public extern void Dispose();
    }
}