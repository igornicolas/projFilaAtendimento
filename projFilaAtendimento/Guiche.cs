using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFilaAtendimento
{
    public class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public Guiche()
        {
            Atendimentos = new Queue<Senha>();
            Id = 0;
        }

        public Guiche(int i)
        {
            Atendimentos = new Queue<Senha>();
            Id = i;
        }

        public int Id { get => id; set => id = value; }
        public Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            try { 
            Senha senhaEmMovimento= filaSenhas.First();
            filaSenhas.Dequeue();
                senhaEmMovimento.DataAtend = DateTime.Now;
                senhaEmMovimento.HoraAtend = DateTime.Now;
                Atendimentos.Enqueue(senhaEmMovimento);
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
