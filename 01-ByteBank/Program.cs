using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("O titular da conta é: " +contaDaGabriela.titular);
            Console.WriteLine("A agencia da conta é: " +contaDaGabriela.agencia);
            Console.WriteLine("O numero da conta é: "+contaDaGabriela.numero);
            Console.WriteLine("O saldo da conta é:R$ "+contaDaGabriela.saldo);




                Console.ReadLine(); 
        }
    }
}
