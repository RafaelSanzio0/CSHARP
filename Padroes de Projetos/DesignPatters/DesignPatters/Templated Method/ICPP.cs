namespace DesignPatters.Templated_Method
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(double orcamento)
        {
            return orcamento > 500;
        }
        protected override double MaximaTaxacao(double orcamento)
        {
            return orcamento * 0.07;
        }
        protected override double MinimaTaxacao(double orcamento)
        {
            return orcamento * 0.05;
        }
    }
}
