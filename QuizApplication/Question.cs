using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{
	public class Question
	{
		public string QuestionText { get; }
		public string Answer { get; }
		public double percentageScore;

		public Question(string questionText, string answer)
		{
			QuestionText = questionText;
			Answer = answer;
		}
		public Question()
		{
		}
		public string percent(double percentageScore)
		{
			if (percentageScore > 90 && percentageScore <= 100)
			{
				return "you have passed with distinction";
			}
			else if (percentageScore > 75 && percentageScore <= 90)
			{
				return "you have passed";
			}
			else
			{
				return "Sorry, you have failed";
			}
		}
	}
}
