int a = 10;
double b = a; //an int can be safely cast as a double
WriteLine($"{b}");

double c = 9.8;
// int d = c; //compiler gives error
int d = (int)c; //converts to int losing the decimal and rounding to nearest whole number
WriteLine($"{d}");