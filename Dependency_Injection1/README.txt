install nuget package called StructureMap
then follow program file code....

// Configure and build a brand new
// StructureMap Container object
            var container = new Container(_ =>
            {
                _.For<IFoo>().Use<Foo>();
                _.For<IBar>().Use<Bar>();
            });

// Now, resolve a new object instance of IFoo
            container.GetInstance<IFoo>()
                // should be type Foo
                .ShouldBeOfType<Foo>()

                // and the IBar dependency too
                .Bar.ShouldBeOfType<Bar>();


var container = new Container(_ =>
{
    _.Scan(x =>
    {
        x.TheCallingAssembly();
        x.WithDefaultConventions();
    });
});