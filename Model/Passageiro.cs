using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed2_project7.Model
{
    class Passageiro
    {
        private int inscricao; 
        public Passageiro(int inscricao)
        {
            Inscricao = inscricao;
        }

        public int Inscricao
        {
            get
            {
                return inscricao;
            }

            set
            {
                inscricao = value;
            }
        }
    } 
}
