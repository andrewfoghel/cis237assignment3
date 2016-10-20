namespace cis237assignment3
{
    internal class Janitor : Utility
    {
        private bool trashCompator;
        private bool vacuum;
        private decimal trashcost=0;
        private decimal vacuumcost=0;
        private decimal total;
        
        
        public Janitor(string material, string model, string color, bool connection, bool toolbox, bool arm, bool trashCompator, bool vacuum) : base(material, model, color, connection, toolbox, arm)
        {
            this.trashCompator = trashCompator;
            this.vacuum = vacuum;
            Utility x = new Utility(material, model, color, connection, toolbox, arm);
            total = x.getTotal();

        }
        public override void CalculateTotalCost()
        {
            if(trashCompator == true)
            {
                trashcost = 20;
            }
            if(vacuum == true)
            {
                vacuumcost = 20;
            }

            total = total + trashcost + vacuumcost;
        }

        public override string ToString()
        {
            return "total cost for janitor: " + total + ", trash: " + trashCompator + ",vacuum: " + vacuum;
        }

    }
}