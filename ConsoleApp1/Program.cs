// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int[] kamala = new int[6];
//int[] hasan = { 1, 5, 6, 999, -78, 777, 888,44,22, 999, -12 };

//int max = hasan[0];



//for(int i=0; i< hasan.Length; i++)
//{
//    if (hasan[i] % 2 == 0)
//    {
//        Console.WriteLine(hasan[i]);
//    }
//}

//for(int i =0; i<hasan.Length; i++)
//{
//    if (max < hasan[i])
//    {
//        max = hasan[i];


//    }

//}

//Console.WriteLine(max);

//int[,] kkk = new int[2,3];

//Console.WriteLine(kkk);


//Console.WriteLine(DateTime.Now.ToString("dd/MM/yy
//

Console.WriteLine("Pulun miqdarini daxil edin");

double money = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Daxil etdiyiniz valyuta- azn, dollar, rubl, tl, euro");
string valyuta1 = Console.ReadLine();

Console.WriteLine("Convert etm'k istediyiniz  valyuta- azn, dollar, rubl, tl, euro");
string valyuta2 = Console.ReadLine();

if (valyuta1 == "azn" || valyuta2 == "dollar")
{
    double conver = money * 1.7;
    Console.WriteLine(conver);
}

else if(valyuta1 == "dollar" || valyuta2 == "azn")
{
    double conver = money / 1.7;
    Console.WriteLine(conver);
}