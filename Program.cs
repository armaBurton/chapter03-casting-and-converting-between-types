using static System.Convert;

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

//ROUNDING NUMBERS
double[] doubles = new[] {
  9.49, 9.5, 9.51, 10.49, 10.5, 10.51
};

foreach(double n in doubles){
  WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}