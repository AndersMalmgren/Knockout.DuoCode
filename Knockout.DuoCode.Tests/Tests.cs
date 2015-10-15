using System;
using System.Collections.Generic;
using System.Linq;
using DuoCode.Dom;

namespace Knockout.DuoCode.Tests
{
    [Test]
    public sealed class When_initilizing_a_observable_array_with_default_items
    {
	    private ObservableArray<int> array;

	    [TestSetup]
        public void Setup()
	    {
		    array = Global.ObservableArray<int>(new object[] {1, 2, 3, 4});
	    }

	    [TestMethod]
        public void It_should_create_instance_correctly()
	    {
		    array.Push(1); //THis will crash if DuoCode is not doing it correctly
			QUnit.ok(true);
	    }
    }
}