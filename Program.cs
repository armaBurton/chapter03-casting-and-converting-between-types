﻿using static System.Convert;

// int a = 10;
// double b = a; //an int can be safely cast as a double
// WriteLine($"{b}");

// double c = 9.8;
// // int d = c; //compiler gives error
// int d = (int)c; //converts to int losing the decimal and rounding to nearest whole number
// WriteLine($"{d}");

// long e = 10;
// int f = (int)e;
// WriteLine($"e is {e:N0} and f is {f:N0}");

// // e = long.MaxValue; //9,223,372,036,854,775,807
// e = 5_000_000_000;
// f = (int)e;
// WriteLine($"e is {e:N0} and f is {f:N0}");

// double g = 9.8;
// int h = ToInt32(g);
// WriteLine($"g is {g}, h is {h}");

// // ROUNDING NUMBERS
// double[] doubles = new[] {
//   9.49, 9.5, 9.51, 10.49, 10.5, 10.51
// };

// foreach(double n in doubles){
//   WriteLine($"ToInt32({n}) is {ToInt32(n)}");
// }

// WriteLine($"");

// //taking control of rounding rules
// foreach(double n in doubles){
//   WriteLine(format:
//     "Math.Round({0}, 0, MidPointRounding.AwayFromZero) is {1}",
//     arg0: n, arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero)  
//   );
// }

// //Converting from any type to a string
// int number = 12;
// WriteLine($"{number.ToString()}");
// bool boolean = true;
// WriteLine($"{boolean.ToString()}");
// DateTime now = DateTime.Now;
// WriteLine($"{now.ToString()}");
// object me = new();
// WriteLine($"{me.ToString()}");

// //Convert Binary Object to String
// //allocate an array of 128 bytes
// byte[] binaryObject = new byte[128];

// //populate array with random bytes
// Random.Shared.NextBytes(binaryObject);
// WriteLine($"Binary Object as bytes:");
// for(int index = 0; index < binaryObject.Length; index++){
//   Write($"{binaryObject[index]:X} ");
// }
// WriteLine($"");

// //convert to Base64 string and output as text
// string encoded = ToBase64String(binaryObject);
// WriteLine($"Binary Object as Base64 : {encoded}");

// //Parsing from string to numbers or dates and times
// int age = int.Parse("27");
// DateTime birthday = DateTime.Parse("4 July 1980");
// WriteLine($"I was born {age} years ago.");
// WriteLine($"My birthday is {birthday}.");
// WriteLine($"My birthday is {birthday:D}.");

// //Errors using Parse
// int count = int.Parse("ABC");

// //Avoiding exceptions using the TryParse method
// Write($"How many eggs are there? ");
// string? input = ReadLine();

// if (int.TryParse(input, out int count)){
//   WriteLine($"There are {count} eggs.");
// } else {
//   WriteLine($"I could not parse the input.");
// }

// //Handling exceptions
// //try block
// WriteLine($"Before parsing.");
// Write($"What is your age? ");
// string? input = ReadLine();
// try{
//   int age = int.Parse(input);
//   WriteLine($"You are {age} years old.");
// //Catch formatException
// } catch (FormatException) {
//   WriteLine($"The age you entered is not a valid number format.");
// //OverflowException
// } catch (OverflowException){
//   WriteLine($"The age is a valid number but it is either too big or too small.");
// //Catching all other exceptions
// } catch(Exception ex){
//   WriteLine($"{ex.GetType()} says {ex.Message}");
// }
// WriteLine($"After Parsing.");

// //Catching with filters
// Write($"Enter an amount: ");
// string amount = ReadLine();
// if (string.IsNullOrEmpty(amount)) return;

// try{
//   decimal amountValue = decimal.Parse(amount);
//   WriteLine($"Amount formatted as currency: {amountValue:C}");
// } catch (FormatException) when (amount.Contains("$")) {
//   WriteLine($"Amounts cannot use the dollar sign!");
// } catch (FormatException){
//   WriteLine($"Amounts must only contain digits!");
// }

// //Fizz Buzz
// for (int i = 1; i <=100; i++){
//   if(i % 3 == 0 && i % 5 == 0){
//     Write($"FizzBuzz ");
//   } else if (i % 3 == 0){
//     Write($"Fizz ");
//   } else if (i % 5 == 0){
//     Write($"Buzz ");
//   } else {
//     Write($"{i} ");
//   }
// }

// //ErrorHandling

// Write($"Enter a number between 0 and 255: ");
// string? input1 = ReadLine();
// Write($"Enter another number between 0 and 255: ");
// string? input2 = ReadLine();
// try{
//   double division = double.Parse(input1) / double.Parse(input2);
//   WriteLine($"{input1} divided by {input2} is {division}.");
// } catch (FormatException) {
//   WriteLine($"FormatException: Input string was not in a correct format.");
// }