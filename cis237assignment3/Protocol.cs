namespace cis237assignment3
{
    internal class Protocol : Droid
    {
        private decimal total;
        private int numberLanguages;
        private const int costPerLanguage = 20;

        public Protocol(string material, string model, string color, int numLang) : base(material, model, color)
        {
            numberLanguages = numLang;
        }

        public override void CalculateTotalCost()
        {
            total = CalculateBaseCost();
            total = total + (numberLanguages * costPerLanguage);
            
        }
        public override string toString()
        {
            return "Total cost for protocol language is " + total + ", number of langauges " + numberLanguages;
        }

       
    }
}