namespace p32bx_24_12_24
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Выбирите стиль игры:\n" + "1-Fanteasy\n" + "2-Cyberpunk:\n");
                int consol = int.Parse(Console.ReadLine());

            ItopicFactary factory = null;
                if (consol == 1)
                {
                    factory = new DarkThemeFactary();


                }
                else if (consol == 2)
                {

                    factory = new ALightThemeFactary();
                }
                else
                {
                    Console.WriteLine("error");
                }
                Game game = new Game(factory);
                game.Start();
            }

        }





        public interface Itopic
    {
            void Describe();

        }
       
        public class DarkThemeTopic : Itopic
    {


            public void Describe()
            {
                Console.WriteLine("Создано окно: Тёмное.");
                Console.WriteLine("Создана кнопка: Тёмная.");
        }

        }

       
        public class ALightThemeTopic : Itopic
    {


            public void Describe()
            {
            Console.WriteLine("Создано окно: Светлая.");
            Console.WriteLine("Создана кнопка: Светлая.");
        }

        }

     

        public interface ItopicFactary
    {
        Itopic CreateTopic();
            

        }
        public class DarkThemeFactary : ItopicFactary
    {
            public Itopic CreateTopic()
            {
                return new DarkThemeTopic();
            }
        }
        public class ALightThemeFactary : ItopicFactary
    {
        public Itopic CreateTopic()
        {
                return new ALightThemeTopic();
            }

           
        }
        public class Game
        {
            private Itopic _topic;
            
            public Game(ItopicFactary factary)
            {
            _topic = factary.CreateTopic();
                
            }
            public void Start()
            {
                Console.WriteLine("добро пожаловать");
            _topic.Describe();
                
            }
        }

    }

