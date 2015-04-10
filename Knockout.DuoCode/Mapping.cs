using DuoCode.Runtime;

namespace Knockout
{
    [Js(Name = "ko.mapping", Extern = true)]
    public static class Mapping
    {
        [Js(Name = "fromJS", OmitGenericArgs = true)]
        public static extern void Map<T>(object data, object mappingOptions, T target);
    }
    
}