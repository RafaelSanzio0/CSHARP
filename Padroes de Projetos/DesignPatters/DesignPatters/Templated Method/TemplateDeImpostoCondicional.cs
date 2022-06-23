namespace DesignPatters.Templated_Method
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public double Calcula(double orcamento)
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

        protected abstract bool DeveUsarMaximaTaxacao(double orcamento);
        protected abstract double MaximaTaxacao(double orcamento);
        protected abstract double MinimaTaxacao(double orcamento);
    }
}
