using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFilaAtendimento
{
    public class Senha
    {
        private int id;
        private DateTime dataGerac, horaGerac, dataAtend, horaAtend;

        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }

        public Senha(int i)
        {
            id = i;
            // tratar para so pegar data e o outro so pegar hora
            DataGerac = DateTime.Now;
            HoraGerac = DateTime.Now;
            
        }

        public string dadosParciais()
        {
            return id + "-" + DataGerac.ToShortDateString() + "-" + HoraGerac.ToLongTimeString();
        }

        public string dadosCompletos()
        {
            return id + "-" + DataGerac.ToShortDateString() + "-" + HoraGerac.ToLongTimeString() + "-" + DataAtend.ToShortDateString() + "-" + HoraAtend.ToLongTimeString();
        }


    }
}
