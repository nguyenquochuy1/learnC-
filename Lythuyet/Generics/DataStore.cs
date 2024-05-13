namespace Generics;

public class DataStore<T> where T : struct
{
    public T Data { get; set; }
}
