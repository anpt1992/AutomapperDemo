namespace AutomapperDemo;

public class Property2
{
    public string Property3 { get; set; }
    public string Property4 { get; set; }
}

public class Source
{
    public string Property1 { get; set; }
    public Property2[] Property2 { get; set; }
}


public class Property9
{
    public string Property1 { get; set; }
    public string Property3 { get; set; }
    public string Property4 { get; set; }
}
public class Destination
{
    public Property9[] Property9 { get; set; }
}
