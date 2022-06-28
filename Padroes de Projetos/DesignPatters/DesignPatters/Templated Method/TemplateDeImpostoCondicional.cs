namespace DesignPatters.Templated_Method
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { } // mudança para o decorator
        public TemplateDeImpostoCondicional() : base() { } // mudança para o decorator

        public override double Calcula(double orcamento)
        {           
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }

        public override double CalculoDoOutroImposto(double orcamento) // metodo no decorator
        {
            return (OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento));
        }

        protected abstract bool DeveUsarMaximaTaxacao(double orcamento);
        protected abstract double MaximaTaxacao(double orcamento);
        protected abstract double MinimaTaxacao(double orcamento);
    }
}
