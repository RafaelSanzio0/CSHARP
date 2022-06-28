namespace DesignPatters.Templated_Method
{
    class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }

        protected override bool DeveUsarMaximaTaxacao(double orcamento)
        {
            return orcamento > 501; // imagina outra condição aqui acompanhada do AND
        }
        protected override double MaximaTaxacao(double orcamento)
        {
            return orcamento * 0.10 + CalculoDoOutroImposto(orcamento);
        }
        protected override double MinimaTaxacao(double orcamento)
        {
            return orcamento * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
