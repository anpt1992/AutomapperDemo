using AutoMapper;
using AutomapperDemo;

var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
var mapper = config.CreateMapper();

// Create a source object
var sourceObject = new Source { Property1 = "Value1", Property2 = new Property2[] { new Property2() { Property3 = "Value3", Property4 = "Value4" }, new Property2() { Property3 = "Value5", Property4 = "Value6" } } };

// Perform the mapping
var destinationObject = mapper.Map<Destination>(sourceObject);

Console.WriteLine("Done!");
