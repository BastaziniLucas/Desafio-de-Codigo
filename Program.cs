using System;
using System.Linq;
class Program
{
    public static string[] examples = { "Miritiba 339" , "Babaçu 500" , "Cambuí 804B" , "Rio Branco 23" , "Quirino dos Santos 23 b" , "4, Rue de la République" , "100 Broadway Av" , "Calle Sagasta, 26" , "Calle 44 No 1991"};
    public static string fullAddress = "";
    public static string[] address;
    public static string street = "";
    public static string number = "";
    public static void Main()
    {
        for (int h = 0; h < examples.Length; h++)
        {
            fullAddress = examples[h];
            fullAddress = fullAddress.Replace(",", "");
            address = fullAddress.Split(" ");
            Console.WriteLine("Endereço: " + examples[h]);
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == "No" | address[i] == "no")
                {
                    street = "";
                    for (int j = 0; j < i; j++)
                    {
                        street += address[j] + " ";
                    }
                    number = "";
                    for (int k = i; k < address.Length; k++)
                    {
                        number += address[k] + " ";
                    }
                    i = address.Length;
                }
                else if (address[i] == address[address.Length - 2] && address[i].All(Char.IsNumber) && address[i + 1].All(Char.IsLetter))
                {
                    number = address[i] + " " + address[i + 1];
                    i++;
                }
                else if (address[i].All(Char.IsLetter))
                {
                    street += address[i] + " ";
                }
                else
                {
                    number += address[i] + " ";
                }
            }
            Console.WriteLine("Rua: " + street + "; " + "Número da Rua: " + number + "\n");
            street = "";
            number = "";
        }
    }
}