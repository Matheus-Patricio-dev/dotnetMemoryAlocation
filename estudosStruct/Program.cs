using System;
using System.Net.Http.Headers;

namespace estudosStruct
{
    class Program
    {
        static void Main(string[] args)
        {

            //explorando structs - criacao de tipos em dotnet
            Pointer p = new Pointer();
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);

            //Explorando alocação e desalocação de memoria.


            //ALOCAÇÃO - PONTEIROS

            Products products, productsReference;
                // Memoria instanciada com variavel/ponteiro no Stack e Valores de Objeto no Heap.
            products = new Products("Iphone 16Pro Max", 12000, 10);
               // productsReference aponta para o mesmo local onde está apontado os objetos do ponteiro products.
            productsReference = products;


            //DESALOCAÇÃO POR GARBAGE COLLECTOR
            Products p1, p2;
                // p1 se tornou um ponteiro e recebeu o endereço de memória.
            p1 = new Products("tv", 100, 10);
                // p1 e p2 são ponteiros e receberam cada um seu endereço de memória.
            p2 = new Products("celular", 300, 20);

                // aqui p1 está recebendo o endereço de memória onde os objetos de p2 estão localizados, O GC (Garbage Collector)
                // irá desalocar os objetos de p1 futuramente, pois o mesmo não possui mais referencia/ponteiro.
            p1 = p2;

            //DESALOCAÇÃO POR ESCOPO

            void method1()
            {
                //chamada da funcao method2
                Products p3 = method2();
                Console.WriteLine(p3.ProductName);
            }

            Products method2()
            {
                // apos a chamada no method1, é criado o ponteiro p4 que recebe os objetos e retorna posteriormente.
                Products p4 = new Products("geladeira", 1000, 2);
                // ao retornar, o endereço de memoria é passado para p3 e o escopo do method2 é desalocado pois a execução terminou
                // fechando os escopo e p4 não possui mais a referencia de memória.
                return p4;
            }

            //chamada da funcao method1
            method1();
        }
    }
}