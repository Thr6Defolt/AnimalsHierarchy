namespace Animals_hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Owl owl = new Owl("Rick", 2, "150m");
            Eagle eagle = new Eagle("Morti", 4, "4000m");

            Shark shark = new Shark("Nemo", 6, "2000м");
            GoldenFish goldenFish = new GoldenFish("Dori", 3, "400м");

            owl.Move();
            owl.Speak();
            owl.Sleep();

            eagle.Move();
            eagle.Speak();
            eagle.Sleep();

            shark.Move();
            shark.Speak();
            shark.Sleep();

            goldenFish.Move();
            goldenFish.Speak();
            goldenFish.Sleep();
        }
    }
}