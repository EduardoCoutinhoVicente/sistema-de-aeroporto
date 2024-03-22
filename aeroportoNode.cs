using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace atividade_voo
{
    public class aeroportoNode
    {
        public int idAeroporto;
        public String nomeAeroporto;
        public aeroportoNode proximoNo;
        public aeroportoNode noAnterior;
        public aeroportoNode(int idAeroporto, String nomeAeroporto)
        {
            this.idAeroporto = idAeroporto;
            this.nomeAeroporto = nomeAeroporto;
            proximoNo = null;
            noAnterior = null;
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
        public VooNode Ancora;
        public void InserirInicio(int idAeroporto, string nomeAeroporto)
        {
            aeroportoNode novoNo = new aeroportoNode(idAeroporto, nomeAeroporto);
            if (inicioLista == null)
            {
                inicioLista = novoNo;
                fimLista = novoNo;
            }
            else
            {
                novoNo.proximoNo = inicioLista;
                inicioLista.noAnterior = novoNo;
                inicioLista = novoNo;
            }
        }

        public void Lista()
        {
            aeroportoNode noAtual = inicioLista;

            if (inicioLista == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }
           
            while (noAtual != null)
            {
                Console.WriteLine("id: " + noAtual.idAeroporto);
                Console.WriteLine("nome: " + noAtual.nomeAeroporto);
                Console.WriteLine();

                noAtual = noAtual.proximoNo;
            }
            Console.WriteLine();
        }
    }


}

