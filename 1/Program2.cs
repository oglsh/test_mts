using System;
using System.Globalization; 

namespace test_mts_2
{
	class Program2
	{
		static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

		class Number
		{
			readonly int _number;

			public Number(int number)
			{
				_number = number;
			}

			public override string ToString()
			{
				return _number.ToString(_ifp);
			}

			public static string operator +(Number value1, string value2) 
			{
				return Convert.ToString(value1._number + Convert.ToInt32(value2));
			}
        }			

		static void Main(string[] args)
		{
			int someValue1 = 10;
			int someValue2 = 5;

			string result = new Number(someValue1) + someValue2.ToString(_ifp);
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}


}
