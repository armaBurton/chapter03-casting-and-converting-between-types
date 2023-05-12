int a = 10;
double b = a; //an int can be safely cast as a double
WriteLine($"{b}");

double c = 9.8;
// int d = c; //compiler gives error
int d = (int)c; //converts to int losing the decimal and rounding to nearest whole number
WriteLine($"{d}");

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
