using System;


namespace Exercicio_Fixacao
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentaSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem/100);
        }
        public override string ToString()
        {
            return Nome + ", R$ "+ SalarioLiquido();
        }
    }

}
