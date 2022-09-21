namespace pjCasoATM
{
    internal class Cuenta
    {
        private int numroCuenta;
        private int pin;
        private decimal saldoTotal;

        public Cuenta(int numroCuenta, int pin, decimal saldoTotal)
        {
            this.numroCuenta = numroCuenta;
            this.pin = pin;
            this.saldoTotal = saldoTotal;   
        }

        public int NumeroCuenta
        { get { return numroCuenta; } }

        public decimal SaldoTotal
            { get { return saldoTotal; } }

        internal bool ValidarPIN(int pINUsuario)
        {
            return (pin == pINUsuario) ;
        }
    }
}