public static class Menu
{
    private static Quad quad;
    public static Scripture GetScripture()
    {
        quad = new Quad();
        System.Console.WriteLine("Select a Scripture!");
        return quad.GetScripture();
    }
}