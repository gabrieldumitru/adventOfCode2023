namespace Day03_1
{
    public static class Neighbours
    {
        public static List<Neighbour> neighbours = new()
    {
        new(0, 1),
        new(1, 0),
        new(0, -1),
        new(-1, 0),
        new(-1, 1),
        new(1, -1),
        new(1, 1),
        new(-1, -1)
    };
    }
}
