namespace cis237assignment3
{
    internal class AstroMech : Utility
    {
        private int numberOfShips;
        private bool fireExting;
        private decimal total;
        private decimal fireCost;
        public AstroMech(string material, string model, string color, bool connection, bool toolbox, bool arm,int numberOfShips,bool fireExting) : base(material, model, color, connection, toolbox, arm)
        {
            this.fireExting = fireExting;
            this.numberOfShips= numberOfShips;
            Utility x = new Utility(material, model, color, connection, toolbox, arm);
            total = x.getTotal();
        }
        public override void CalculateTotalCost()
        {
            int shipCost = numberOfShips * 20;
            if(fireExting == true)
            {
                fireCost = 20;
            }
            total = total + shipCost + fireCost;
           
        }

        public override string ToString()
        {
            return "Total for astromech: " + total + ", fire exstinguiser: " + fireExting + ",Number of ships: " + numberOfShips;
        }



    }
}