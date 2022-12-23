//Программа выдает день недели по заданному номеру (пн - 1, вс - 7)

Console.WriteLine("Write number from 1 to 7");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);

if (a1==1)
{ Console.WriteLine ("Monday"); }

if (a1==2)
{ Console.WriteLine ("Tuesday"); }

if (a1==3)
{ Console.WriteLine ("Wednesday"); }

if (a1==4)
{ Console.WriteLine ("Thursday"); }

if (a1==5)
{ Console.WriteLine ("Friday"); }

if (a1==6)
{ Console.WriteLine ("Saturday"); }

if (a1==7)
{ Console.WriteLine ("Sunday"); }

if (a1>7||a1<1)
{ Console.WriteLine ("Sorry, that day not from our planet"); }