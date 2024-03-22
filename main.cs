using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static atividade_voo.VooNode;

namespace atividade_voo
{
    /// <summary>
    /// feito por Eduardo E Kailany
    /// </summary>
    public class principal
    {
        static void Main(string[] args)
        {
         

            listaDuplamenteEncadeada listaEmpresa = new listaDuplamenteEncadeada();
            listaDuplamenteEncadeadaAeroporto aeroporto = new listaDuplamenteEncadeadaAeroporto();
            int j = 0;
            int opcao = 1232;
            if (opcao == 1232)
            {
                menu();
            }
            // Método que exibe o menu principal que chamara os outros menus
            void menu()
            {
                while (opcao != 4)// equanto opc não for 4 o while ira continuar rodando
                {
                    Console.Clear();
                    Console.WriteLine(":::::::::::::::::::::::::::::::::");
                    Console.WriteLine(":.............MENU..............:");
                    Console.WriteLine(":...............................:");
                    Console.WriteLine(":  Menu Empresa Aérea     < 1 > :");
                    Console.WriteLine(":...............................:");
                    Console.WriteLine(":  Menu Aeroporto         < 2 > :");
                    Console.WriteLine(":...............................:");
                    Console.WriteLine(":  Menu Voo               < 3 > :");
                    Console.WriteLine(":...............................:");
                    Console.WriteLine(":  Sair                   < 4 > :");
                    Console.WriteLine(":::::::::::::::::::::::::::::::::");
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (opcao)
                    {
                        case 1:
                            //chama o menu de Empresa
                            MenuEmpresaAerea();
                            break;
                        case 2:
                            //chama o menu do Aeroporto
                            MenuAeroporto();
                            break;
                        case 3:
                            //chama o menu do Voo
                            MenuVoo();
                            break;
                    }

                  
                }
            }
            Console.ReadKey();
            // Método que exibe o menu da empresa aérea
            void MenuEmpresaAerea()
            {
                opcao = 2355;  

                j = 0;
                

                while (opcao != null)
                {
                    Console.Clear();
                    Console.WriteLine(":::::::::::::::::::::::::::::::::");
                    Console.WriteLine(":.....Menu Empresa Aérea........:");
                    Console.WriteLine(":...............................:");
                    Console.WriteLine(": Cadastrar Empresa Aérea < 1 > :");
                    Console.WriteLine(":...............................:");
                    Console.WriteLine(":  Listar Empresas Aérea  < 2 > :");
                    Console.WriteLine(":...............................:");
                    Console.WriteLine(":  Sair                   < 0 > :");
                    Console.WriteLine(":::::::::::::::::::::::::::::::::");
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcao)
                    {
                        case 0:
                            menu();

                            break;
                        case 1:
                            if (j < 10)
                            {
                                Console.Clear();
                                Console.WriteLine("Entre com o " + (j + 1) + "° empresa: \n");
                                Console.WriteLine("Entre com o código da Empresa Aérea: ");
                                int idEmpresa = int.Parse(Console.ReadLine());
                                Console.WriteLine("Entre com o nome da Empresa Aérea:");
                                string nomeEmpresa = Console.ReadLine();

                                listaEmpresa.InserirInicio(idEmpresa, nomeEmpresa);
                                j++;
                            }
                            break;
                        case 2:

                            Console.Clear();
                            Console.WriteLine("=== Listar Empresas Aéreas ===");
                            listaEmpresa.Lista();
                            Console.ReadKey();  
                            break;
                    
                    }
                }
            }
                    void MenuAeroporto()
                    {

                        j = 0;
                        

                        while (opcao != 4)
                        {
                            Console.Clear();
                            Console.WriteLine(":::::::::::::::::::::::::::::::::");
                            Console.WriteLine(":.........Menu Aeroporto........:");
                            Console.WriteLine(":...............................:");
                            Console.WriteLine(":  Cadastrar Aeroporto    < 1 > :");
                            Console.WriteLine(":...............................:");
                            Console.WriteLine(":  Listar Aeroporto       < 2 > :");
                            Console.WriteLine(":...............................:");
                            Console.WriteLine(":  Sair                   < 0 > :");
                            Console.WriteLine(":::::::::::::::::::::::::::::::::");
                            opcao = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            switch (opcao)
                            {
                                case 0:
                                    menu();

                                    break;
                                case 1:
                                    if (j < 10)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" " + (j + 1) + "° Aeroporto: \n");
                                        Console.WriteLine("Entre com o código do Aeroporto: ");
                                        int idAeroporto = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Entre com o nome do Aeroporto  :");
                                        string nomeAeroporto = Console.ReadLine();

                                       aeroporto.InserirInicio(idAeroporto, nomeAeroporto);
                                        j++;
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("=== Listar de Aeroportos  ===");
                                      aeroporto.Lista();
                                     Console.ReadKey();
                            break;

                            }
                               Console.WriteLine();
                        }
                    }
            void MenuVoo()
            {

             j = 0;
             listaDuplamenteEncadeadaVoo listaVoo = new listaDuplamenteEncadeadaVoo();

                while (opcao != null)
                {
                  Console.Clear();
                  Console.WriteLine(":::::::::::::::::::::::::::::::::");
                  Console.WriteLine(":...........Menu voo............:");
                  Console.WriteLine(":...............................:");
                  Console.WriteLine(":  Cadastrar voo          < 1 > :");
                  Console.WriteLine(":...............................:");
                  Console.WriteLine(":  Listar voos            < 2 > :");
                  Console.WriteLine(":...............................:");
                  Console.WriteLine(":  Pesquisar voos         < 3 > :");
                  Console.WriteLine(":...............................:");
                  Console.WriteLine(":  Excluir voos           < 4 > :");
                  Console.WriteLine(":...............................:");
                  Console.WriteLine(":  voltar                 < 0 > :");
                  Console.WriteLine(":::::::::::::::::::::::::::::::::");
                                    opcao = int.Parse(Console.ReadLine());
                                    Console.WriteLine();

                  switch (opcao)
                  {
                     case 0:
                     menu();
                     break;

                    case 1:
                    if (j < 10)
                     {
                                Console.Clear();
                                Console.WriteLine("Entre com o " + (j + 1) + "° Voo: \n");
                                Console.WriteLine("Entre com o código do Voos: ");
                                int idVoo = int.Parse(Console.ReadLine());
                                Console.WriteLine("Entre com a origem do Voo:");
                                string origem = Console.ReadLine();
                                Console.WriteLine("Entre com a destino do Voo:");
                                string destino = Console.ReadLine();
                                Console.WriteLine("Entre com a hora de partida do Voo:");
                                string horaDePartida = Console.ReadLine();
                                Console.WriteLine("Entre com o código do aeroporto:");
                                int idAeroporto = int.Parse(Console.ReadLine());
                                Console.WriteLine("Entre com o código da empresa Aerea:");
                                int idEmpresa = int.Parse(Console.ReadLine());
                                listaVoo.InserirInicio(idVoo, origem, destino, horaDePartida, idAeroporto, idEmpresa);
                                j++;
                    }
                                            break;

                                        case 2:

                                            while (opcao != null)
                                            {
                                                Console.Clear();
                                                Console.WriteLine(":::::::::::::::::::::::::::::::::");
                                                Console.WriteLine(":..........Listar Voos de.......:");
                                                Console.WriteLine(":...............................:");
                                                Console.WriteLine(":  empresas               < 1 > :");
                                                Console.WriteLine(":...............................:");
                                                Console.WriteLine(":  aeroporto              < 2 > :");
                                                Console.WriteLine(":...............................:");
                                                Console.WriteLine(":  Sair                   < 0 > :");
                                                Console.WriteLine(":::::::::::::::::::::::::::::::::");
                                                opcao = int.Parse(Console.ReadLine());
                                                switch (opcao)
                                                {
                                                    case 0:
                                                        MenuVoo();

                                                        break;
                                                    case 1:
                                                        Console.WriteLine("Entre com o codigo da Empresa");
                                                       int id = int.Parse(Console.ReadLine());
                                                       listaVoo.listarEmpresa(id);
                                                       Console.ReadKey();
                                                       break;
                                                    case 2:
                                                     Console.WriteLine("Entre com o codigo do Aeroporto");
                                                        id= int.Parse(Console.ReadLine());
                                       
                                                     listaVoo.listarAeroporto(id);
                                                      Console.ReadKey();
                                                     break;
                                                }
                                            }
                                            break;
                                        case 3:
                                        Console.WriteLine("Entre com o codigo do voo:");
                                         int idPesquisa = int.Parse(Console.ReadLine());
                                         listaVoo.pesquisar(idPesquisa);
                                         Console.ReadKey();

                                        break;
                                                 case 4:

                            Console.WriteLine("Entre com o codigo do voo Para Deleta lo:");
                            int IdVoo = int.Parse(Console.ReadLine());
                            listaVoo.Deletar(IdVoo);
                            Console.ReadKey();
                            break;

                   }

                                    Console.WriteLine();
                }



            }
                        
                    
                
            
        }
    }

}   
         
 
