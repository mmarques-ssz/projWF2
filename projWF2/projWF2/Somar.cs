using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projWF2
{
    class Somar
    {
        #region Atributos
        private int n1;
        private int n2;
        private int resultado;
        #endregion

        #region Construtores
        public Somar()
        {
            this.n1 = 0;
            this.n2 = 0;
        }

        public Somar(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        #endregion

        #region Setter's & Getter's
        public void setN1(int n1)
        {
            this.n1 = n1;
        }

        public void setN2(int n2)
        {
            this.n2 = n2;
        }

        public int getN1()
        {
            return this.n1;
        }

        public int getN2()
        {
            return this.n2;
        }

        public int getResultado()
        {
            return this.resultado;
        }
        #endregion

        #region Métodos Funcionais
        public void calcular()
        {
            this.resultado = this.n1 + this.n2;
        }
        #endregion
    }
}
