using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace atividade_voo
{
    public class VooNode
    {
       // listaDuplamenteEncadeadaAeroporto idAeroporto = new   listaDuplamenteEncadeadaAeroporto();
        public int idVoo { get; set; }
        public String origem { get; set; }
        public String destino { get; set; }
        public String horaDePartida { get; set; }
        public int idAeroporto { get; set; }
        public int idEmpresa { get; set; }

        public VooNode proximoNo { get; set; }
        public VooNode noAnterior { get; set; }

        public VooNode(int idVoo, String origem, String destino, String horaDePartida, int idAeroporto, int idEmpresa)
        {
            this.idVoo = idVoo;
            this.origem = origem;
            this.destino = destino; 
            this.horaDePartida = horaDePartida;
            this.idAeroporto = idAeroporto;
            this.idEmpresa = idEmpresa;
            proximoNo = null;
            noAnterior = null;
        }

        public VooNode()
        {
        }


        public class listaDuplamenteEncadeadaVoo
        {
            private VooNode inicioLista;
            private VooNode fimLista;
            public listaDuplamenteEncadeadaVoo()
            {
                inicioLista = null;
                fimLista = null;

            }

            public VooNode Ancora;

            public void listarAeroporto(int id)
            {
                VooNode noAtual = inicioLista; //Começa a busca pelo primeiro nó da lista

                //Verificar se a lista está vazia, se estiver vazia finaliza o método.
                if (noAtual == null)
                {
                    return;
                }

              
               
                while (noAtual != null)
                {
                    if (noAtual.idAeroporto == id)//VERIFICA se  o  id que usuario entrou existe
                    {
                        Console.WriteLine("id: " + noAtual.idVoo);
                        Console.WriteLine("origem: " + noAtual.origem);
                        Console.WriteLine("destino: " + noAtual.destino);
                        Console.WriteLine("hora Da Partida: " + noAtual.horaDePartida);
                        Console.WriteLine();
                        noAtual = noAtual.proximoNo; //Avançar para o próximo nó da lista
                    }

                    return;
                }
            }

           




                public void listarEmpresa(int id)
            {
                VooNode noAtual = inicioLista; //Começa a busca pelo primeiro nó da lista

                //Verificar se a lista está vazia, se estiver vazia finaliza o método.
                if (noAtual == null)
                {
                    return;
                }



                while (noAtual != null)
                {
                    if (noAtual.idEmpresa == id)//VERIFICA se  o  id que usuario entrou existe
                    {
                        Console.WriteLine("id: " + noAtual.idVoo);
                        Console.WriteLine("origem: " + noAtual.origem);
                        Console.WriteLine("destino: " + noAtual.destino);
                        Console.WriteLine("hora Da Partida: " + noAtual.horaDePartida);
                        Console.WriteLine();
                        noAtual = noAtual.proximoNo; //Avançar para o próximo nó da lista
                    }

                    return;
                }
            }
            public void pesquisar(int idPesquisa)
            {
                VooNode noAtual = inicioLista; //Começa a busca pelo primeiro nó da lista

                //Verificar se a lista está vazia, se estiver vazia finaliza o método.
                if (noAtual == null)
                {
                    return;
                }



                while (noAtual != null)
                {
                    if (noAtual.idVoo == idPesquisa)//VERIFICA se  o  id que usuario entrou existe
                    {
                        Console.WriteLine("id: " + noAtual.idVoo);
                        Console.WriteLine("origem: " + noAtual.origem);
                        Console.WriteLine("destino: " + noAtual.destino);
                        Console.WriteLine("hora Da Partida: " + noAtual.horaDePartida);
                        Console.WriteLine();
                        noAtual = noAtual.proximoNo; //Avançar para o próximo nó da lista
                    }


                }
            }
            public void InserirInicio(int idVoo, string origem, string destino, string horaDePartida, int idAeroporto, int idEmpresa)
            {
                VooNode novoNo = new VooNode(idVoo, origem, destino, horaDePartida, idAeroporto, idEmpresa);

                if (inicioLista == null)
                {
                    // Se a lista está vazia, o novo nó se torna o primeiro e o último nó da lista
                    inicioLista = novoNo;
                    fimLista = novoNo;
                }
                else
                {
                    // Se a lista já contém elementos, o novo nó é inserido no início da lista
                    novoNo.proximoNo = inicioLista;
                    inicioLista.noAnterior = novoNo;
                    inicioLista = novoNo;
                }
            }

            public void Deletar(int IdVoo)
            {
                if (inicioLista == null)
                {
                    Console.WriteLine("A lista está vazia.");
                    return;
                }

                VooNode noAtual = inicioLista; // Começa a busca pelo primeiro nó da lista

                while (noAtual != null)
                {
                    if (noAtual.idVoo == IdVoo)
                    {
                        if (noAtual == inicioLista)
                        {
                            // O nó a ser removido é o primeiro nó da lista
                            inicioLista = noAtual.proximoNo;
                            if (inicioLista != null)
                                inicioLista.noAnterior = null;
                            else
                                fimLista = null;
                        }
                        else if (noAtual == fimLista)
                        {
                            // O nó a ser removido é o último nó da lista
                            fimLista = noAtual.noAnterior;
                            if (fimLista != null)
                                fimLista.proximoNo = null;
                            else
                                inicioLista = null;
                        }
                        else
                        {
                            // O nó a ser removido está no meio da lista
                            noAtual.noAnterior.proximoNo = noAtual.proximoNo;
                            noAtual.proximoNo.noAnterior = noAtual.noAnterior;
                        }

                        Console.WriteLine("O Voo foi removido da Lista.");
                        return;
                    }
                    noAtual = noAtual.proximoNo; // Avançar para o próximo nó da lista
                }

                Console.WriteLine("O Voo não foi encontrado na Lista.");
            }



        }



        public class listaDuplamenteEncadeadaAeroporto
            {
                private aeroportoNode inicioLista;
                private aeroportoNode fimLista;

                public listaDuplamenteEncadeadaAeroporto()
                {
                    inicioLista = null;
                    fimLista = null;
                }
            }
        }
    }











