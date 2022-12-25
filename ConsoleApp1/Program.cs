// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




Console.WriteLine("Pulun miqdarini daxil edin");

double money = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Daxil etdiyiniz valyuta- azn, dollar");
string valyuta1 = Console.ReadLine();

Console.WriteLine("Convert etm'k istediyiniz  valyuta- azn, dollar");
string valyuta2 = Console.ReadLine();

if (valyuta1 == "azn" || valyuta2 == "dollar")
{
    double conver = money / 1.7;
    Console.WriteLine(conver);
}

else if(valyuta1 == "dollar" || valyuta2 == "azn")
{
    double conver = money * 1.7;
    Console.WriteLine(conver);
}