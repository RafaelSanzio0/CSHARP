namespace DesignPatters.Templated_Method
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(Imposto outroImposto) : base(outroImposto) { }
        public ICPP() : base() { }

        protected override bool DeveUsarMaximaTaxacao(double orcamento)
        {
            return orcamento > 500;
        }
        protected override double MaximaTaxacao(double orcamento)
        {
            return orcamento * 0.07 + CalculoDoOutroImposto(orcamento);
        }
        protected override double MinimaTaxacao(double orcamento)
        {
            return orcamento * 0.05 + CalculoDoOutroImposto(orcamento);
        }
    }
}
