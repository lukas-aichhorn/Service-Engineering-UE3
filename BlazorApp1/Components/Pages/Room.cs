namespace BlazorApp1;

public class Room
{
    public int number { get; set; }
    public string Type { get; set; }
    public int Capacity { get; set; }
    public bool Occupied { get; set; }
    public bool Cleaned { get; set; }

    public Room(int number, string type, int capacity, bool occupied, bool cleaned)
    {
        this.number = number;
        Type = type;
        Capacity = capacity;
        Occupied = occupied;
        Cleaned = cleaned;
    }
}