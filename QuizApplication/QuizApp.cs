// See https://aka.ms/new-console-template for more information
using QuizApplication;
using System.Diagnostics;

public class QuizApp
{
    static void Main(string[] args)
    {
        // Define a list of questions and answers
        List<Question> questions = new List<Question>()
        {
            new Question("What is Nisha's surname?", "abc"),
            new Question("Which planet is known as the Red Planet?", "Mars"),
            new Question("What is the capital of Telanaga?", "Hyderabad"),
            new Question("who is the current president of india?", "Narendra Modi"),
            new Question("how many letters are there in english alphabets?","26"),
            // Add more questions here
        };

        int score = 0;

        Console.WriteLine("Welcome to the Quiz Application!");
        Stopwatch stopwatch = new Stopwatch();

        // Loop through each question and present it to the user
        foreach (var question in questions)
        {
            stopwatch.Start();
            Console.WriteLine();
            Console.WriteLine("Question:");
            Console.WriteLine(question.QuestionText);

            Console.Write("Your Answer: ");
            string userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == question.Answer.ToLower())
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
                Console.WriteLine($"The correct answer is: {question.Answer}");
            }
        }
        TimeSpan timeElapsed = stopwatch.Elapsed;
        string elapsedTime = $"{timeElapsed.Hours}:{timeElapsed.Minutes}:{timeElapsed.Seconds}.{timeElapsed.Milliseconds / 10}";
        stopwatch.Stop();
        Console.WriteLine();
        Console.WriteLine("Quiz completed!");
        Console.WriteLine($"Your score: {score} out of {questions.Count}");

        // Calculate and display the percentage score
        double percentageScore = (double)score / questions.Count * 100;
        Console.WriteLine($"Percentage Score: {percentageScore}%");
        Question q = new Question();
        string result = q.percent(percentageScore);
        Console.WriteLine(result);
        Console.WriteLine("Total time to complete the quiz:" + timeElapsed);

    }
}


