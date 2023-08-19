using AutoMapper;

namespace AutomapperDemo;

internal class ArrayConverter : ITypeConverter<Source, Property9[]>
{
    public Property9[] Convert(Source source, Property9[] destination, ResolutionContext context)
        => source.Property2.Select(x => new Property9() { Property1 = source.Property1, Property3 = x.Property3, Property4 = x.Property4 }).ToArray();
}
