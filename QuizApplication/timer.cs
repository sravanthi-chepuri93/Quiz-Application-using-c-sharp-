//using System.Timers;
//using Timer = System.Timers.Timer;

//namespace QuizApplication
//{
//    internal class Program
//    {
//        static void TimerElapsed(object sender, ElapsedEventArgs e)
//        {
//            Console.WriteLine("Timer elapsed!");
//        }

//        static void Main(string[] args)
//        {
//            // Create a Timer instance with a interval of 5 seconds
//            Timer timer = new Timer(5000);

//            // Hook up the Elapsed event
//            timer.Elapsed += TimerElapsed;

//            // Start the timer
//            timer.Start();

//            Console.WriteLine("Timer started. Press Enter to exit.");
//            Console.ReadLine();

//            // Stop the timer
//            timer.Stop();
//            timer.Dispose();

//            Console.WriteLine("Application finished.");
//        }

//    }
//}
