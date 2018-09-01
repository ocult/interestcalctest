using System;

namespace Test.Models.Lib
{

    /// <summary>
    /// Calculadora de juros
    /// </summary>
    public class InterestCalc
    {
        /// <summary>
        /// Valor inicial
        /// </summary>
        /// <value>Valor inicial</value>
        public decimal Initial
        {
            get;
            set;
        }
        /// <summary>
        /// Tempo em meses
        /// </summary>
        /// <value>Tempo em meses (inteiro)</value>
        public decimal Months
        {
            get;
            set;
        }

        private double MonthsDouble
        {
            get { return (double)this.Months; }
        }

        private double InterestDouble
        {
            get { return (double)this.Interest; }
        }

        private decimal _interest = 0.01M;

        /// <summary>
        /// % de taxa de juros ao mês. 
        /// </summary>
        /// <value>Já dividido por cem. Exemplo: 1% = 0.01 50% = 0.5</value>
        public decimal Interest
        {
            get
            {
                return _interest;
            }
            set
            {
                this._interest = value;
            }
        }

        /// <summary>
        /// contrutor vazio
        /// </summary>
        public InterestCalc()
        {

        }

        /// <summary>
        /// construtor padrão
        /// </summary>
        /// <param name="initial">Valor inicial</param>
        /// <param name="months">Meses</param>
        /// <param name="interest">Taxa de juros ao mês. Padrao 0.01 (1%)</param>
        public InterestCalc(decimal initial, int months, decimal interest = 0.01M)
        {
            this.Initial = initial;
            this.Months = months;
            this.Interest = interest;
        }

        /// <summary>
        /// Calcula o valor final.
        /// Valor Final = Valor Inicial * (1 + juros) ^ Tempo.
        /// </summary>
        /// <returns>Valor final</returns>
        public decimal Calc()
        {
            double result = ((double)this.Initial) * Math.Pow((1 + this.InterestDouble), this.MonthsDouble);
            return Math.Truncate((decimal)result * 100)/100;
        }
    }
}