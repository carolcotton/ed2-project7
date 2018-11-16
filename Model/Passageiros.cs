using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed2_project7.Model
{
    class Passageiros
    {
        private Queue<Passageiro> lsPassageiros;
        private int id;

        public Passageiros()
        {
            LsPassageiros = new Queue<Passageiro>();
            id = 0;
        }

        internal Queue<Passageiro> LsPassageiros
        {
            get
            {
                return lsPassageiros;
            }

            set
            {
                lsPassageiros = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public void addPassageiro()
        {
            int inscricao = id + 1;
            id++;
            LsPassageiros.Enqueue(new Passageiro(inscricao));
        }
    }
}
