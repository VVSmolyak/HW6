Console.WriteLine ("Введите значение b1: ");
double b1 = double.Parse (Console.ReadLine ()!);
Console.WriteLine ("Введите значение k1: ");
double k1 = double.Parse (Console.ReadLine ()!);
Console.WriteLine ("Введите значение b2: ");
double b2 = double.Parse (Console.ReadLine ()!);
Console.WriteLine ("Введите значение k2: ");
double k2 = double.Parse (Console.ReadLine ()!);

double x = findX (b1, k1, b2, k2);
double y = findY (x, k1, b1);


double findX (double b1, double k1, double b2, double k2) {

    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double findY (double x, double k1, double b1) {

    double y = k1 * x + b1;
    Console.WriteLine ("x = " + x + " y = " + y);
    return y;
}

