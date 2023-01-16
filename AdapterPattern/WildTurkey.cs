namespace AdapterPattern
{
    public class WildTurkey: ITurkey
    {
        public void gobble()
        {
            Console.WriteLine("Кулдык-кулдык");
        }
        public void fly()
        {
            Console.WriteLine("Я умею летать, но на короткие дистанции");
        }
    }
}
