namespace AdapterPattern
{
    public class TurkeyAdapter: IDuck
    {
        ITurkey turkey; //Используем агрегацию в отношениях классов, передаем ссылку на объект через конструктор
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        //реализуем методы интерфейса IDuck
        public void quack()
        {
            turkey.gobble();
        }

        public void fly()
        {
            turkey.fly();
        }

    }
}
