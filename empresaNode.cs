using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace atividade_voo
{
    public class empresaNode
    {
        public int idEmpresa { get; set; }
        public string nomeEmpresa { get; set; }
        public empresaNode proximoNo { get; set; }
        public empresaNode noAnterior { get; set; }

        public empresaNode(int idEmpresa, string nomeEmpresa)
        {
            this.idEmpresa = idEmpresa;
            this.nomeEmpresa = nomeEmpresa;
            proximoNo = null;
            noAnterior = null;
        }
    }

    public class listaDuplamenteEncadeada
    {
        private empresaNode inicioLista;
        private empresaNode fimLista;

        public listaDuplamenteEncadeada()
        {
            inicioLista = null;
            fimLista = null;
        }

        public void InserirInicio(int idEmpresa, string nomeEmpresa)
        {
            empresaNode novoNo = new empresaNode(idEmpresa, nomeEmpresa);

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
            empresaNode noAtual = inicioLista;

            if (noAtual == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            while (noAtual != null)
            {
                Console.WriteLine("id: " + noAtual.idEmpresa);
                Console.WriteLine("nome: " + noAtual.nomeEmpresa);
                Console.WriteLine();

                noAtual = noAtual.proximoNo;
            }
            Console.WriteLine();
        }
    }
}












