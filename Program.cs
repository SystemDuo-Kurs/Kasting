int broj = 56;

double nestoTamo = broj; //implicitni kast, bez rizika

double problem = 5.99999;

int neki = (int)problem; //ekspicitni kast, postoji rizik,
                         //moramo mi izricito da kazemo da to hocemo

byte x = 250;

do
{
    Console.WriteLine(x);
    x++;
}
while (x != 5);

float f = (float)5.35;
float f2 = 5.35f;
double d = 5.35;
decimal dd = (decimal)5.35;

int nesto = int.Parse("11");
bool b = bool.Parse("true");