using System.Linq;
// See https://aka.ms/new-console-template for more information
uint doboz=0;
int áll, áru, felvet, lerak, szakaszok;
szakaszok = 0;
Console.WriteLine("Kérem az állomások számát!");
áll=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kérem az áruszállítások számát!");
áru=Convert.ToInt32(Console.ReadLine());

int[] felveteli_all=new int[áru];
int[] lerakasi_all = new int[áru];
for (int i = 0; i < áru; i++)
{
    Console.WriteLine("Kérem a felvételi pontot!");
    felvet=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Kérem a lerakási pontot!");
    lerak=Convert.ToInt32(Console.ReadLine());

    felveteli_all[i] = felvet;
    lerakasi_all[i] = lerak;

}

if (felveteli_all.Contains(1) == false)
{
    szakaszok++;
}

for (int i = 0; i < áll; i++)
{
    // contains helyett legyen for ciklus !!
    /*
    for( ; ; ){
    if (...)
    { vmi ++;}
     }
    
    ugyanezt  a minusszal --> szakaszok ++ ugyanúgy az if-en belül!!!
    */
    for (int j = 0; j <áru ; j++)
    {
        if (felveteli_all[j] == i)
        {
            doboz++;
        }
    }

    for (int j = 0; j < áru; j++)
    {
        if (lerakasi_all[j] == i)
        {
            doboz--;
            if(doboz == 0)
            {
                szakaszok++;
            }
        }
    }



}

Console.WriteLine(szakaszok);
