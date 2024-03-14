using System;
namespace PrimeiroProjeto
{
    using static Uteis;

    public class Data
	{
		/* Desenvolvendo como ATRIBUTO simples */
		private int dia;  /* ao modo java, não vamos fazer
		                     assim pois o conceito de getter
		                     e setter é implementado de maneira
		                     diferente */

		public void setDia(int d) {
			if ((d<1) || (d>31)) {
				return; // lançar exception !!!!
			}
			this.dia = d;
		}
		public int getDia()
		{
			return this.dia;
		}

		/* Desenvolvendo PROPRIEDADE */
        private int _mes;  // ao modo c#
		public int Mes
		{
			get => _mes;
			set {
				if ((value > 0) &&(value<13))
				{
					_mes = value;
				}
            }
        }


        private int _ano;
        public int Ano
        {
            get => _ano;
            set
            {
                if ((value > 1899) && (value < 3000))
                {
                    _ano = value;
                }
            }
        }

        public Data()
		{
			setDia(10);
			Mes = 1;
			Ano = 1900;
		}

        public string ToString()
        {
			return Uteis.zerosAEsquerda(getDia(),2) +
				"/" + zerosAEsquerda(Mes,4) +
				"/" + Ano;
		}

		
	}
}
