using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFilaAtendimento
{
    public class Guiches
    {
        private List<Guiche> _listaGuiches;
        public List<Guiche> ListaGuiches { get => _listaGuiches; set => _listaGuiches = value; }

        public Guiches()
        {
            _listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            ListaGuiches.Add(guiche);
        }
       
    }
}
