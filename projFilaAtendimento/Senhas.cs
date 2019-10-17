using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFilaAtendimento
{
    public class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        #region Propriedades
        
        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        public Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }
        #endregion

        public Senhas()
        {
            filaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 1;
        }

        public void gerar()
        {
            Senha senhaGerada = new Senha(proximoAtendimento);
            FilaSenhas.Enqueue(senhaGerada);
        }



    }
}
