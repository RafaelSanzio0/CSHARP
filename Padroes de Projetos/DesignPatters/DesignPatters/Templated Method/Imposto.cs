namespace DesignPatters.Templated_Method
{
    public abstract class Imposto
    {
        public Imposto? OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
        }

        public abstract double Calcula(double orcamento);
        public abstract double CalculoDoOutroImposto(double orcamento);
    }
}
