using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_cource25
{
    class CodewarsTasks
    {
		/// <summary>
		/// You are given a dictionary-like object 
		/// (implementation may vary by language) containing languages as keys and 
		/// your corresponding test results as values. Return the list of languages where 
		/// your score is at least 60, in descending order of the scores.
		/// </summary>
		/// <param name="results">Dictionary of languages and scores of them</param>
		/// <returns>name of languages with score >= 60 in descending order</returns>
		public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
		{
			IEnumerable<string> res = results.Where(x => x.Value > 60).OrderByDescending(x => x.Value).Select(x => x.Key);
			return res;
		}


		/// <summary>
		/// The first input array is the key to the correct answers to an exam, like ["a", "a", "b", "d"].
		/// The second one contains a student's submitted answers.
		/// The two arrays are not empty and are the same length.Return the score for this array of answers,
		/// giving +4 for each correct answer, -1 for each incorrect answer, and +0 for each blank answer,
		/// represented as an empty string (in C the space character is used).
		/// If the score < 0, return 0.
		/// </summary>
		/// <param name="arr1">student Answers</param>
		/// <param name="arr2">test answers</param>
		/// <returns>results</returns>
		public static int CheckExam(string[] arr1, string[] arr2)
		{
			int res = 0;
			for (int i = 0; i < arr1.Length; i++)
			{
				if (arr1[i] == arr2[i])
				{
					res += 4;
				}
				else if (arr2[i] == "")
				{
				}
				else
				{
					res -= 1;
				}
			}
			if (res < 0)
			{
				res = 0;
			}
			return res;
		}

		/// <summary>
		/// In this Kata you have to create a function,named insertMissingLetters,that takes in a string and
		/// outputs the same string processed in a particular way.
		/// The function should insert only after the first occurrence of each character of the input string, 
		/// all the alphabet letters that:
		/// -are NOT in the original string
		/// -come after the letter of the string you are processing
		/// Each added letter should be in uppercase, the letters of the original string will always be in lowercase.
		/// </summary>
		/// <param name="str">input string</param>
		/// <returns>result</returns>
		public static string InsertMissingLetters(string str)
		{
			StringBuilder res = new();
			char[] chars = str.ToCharArray();

			foreach (var symb in chars)
			{

				if (!res.ToString().Contains(symb))
				{
					res.Append(symb);
					for (char c = (char)((int)symb - 31); c <= 'Z'; c++)
					{
						if (!str.Contains(char.ToLower(c)))
						{
							res.Append(c);
						}
					}
				}
				else
				{
					res.Append(symb);
				}
			}
			return res.ToString();
		}

		public static string FirstNonRepeatingLetter(string s)
		{
			var startS = s;
			s = s.ToLower();
			Dictionary<string, int[]> dict = new();
			for (int i = 0; i < s.Length; i++)
			{
				string symb = s[i].ToString();
				if (!dict.ContainsKey(symb))
				{
					dict[symb] = new int[] { 0, 0 };
				}
				dict[symb][0] += 1;
				dict[symb][1] = i;
			}
			var kvpRes = dict.Where(x => x.Value[0] == 1).OrderBy(x => x.Value[1]).FirstOrDefault(new KeyValuePair<string, int[]>("", new int[] { 0, 0 }));

			if (kvpRes.Key == "")
			{
				return "";
			}
			return startS[kvpRes.Value[1]].ToString();
		}
	}

}
