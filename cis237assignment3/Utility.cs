using System;

namespace cis237assignment3
{
    internal class Utility : Droid
    {
       private  bool toolbox;
        private bool connection;
       private bool arm;
        private decimal total;
        private decimal tool = 0;
        private decimal a = 0;
        private decimal connect =0 ;
  
       



        public Utility(string material, string model, string color, bool connection, bool toolbox, bool arm) : base(material, model, color)
        {
            this.connection = connection;
            this.toolbox = toolbox;
            this.arm = arm;
        }
        public override void CalculateTotalCost()
        {
           if(connection == true)
            {
                connect = 20;
            }
            if (arm == true)
            {
                a = 20;
            }
            if (toolbox == true)
            {
                tool = 20;
            }
           

            decimal baseCost = CalculateBaseCost();
            total = baseCost + tool + a + connect;

        }

        public decimal getTotal()
        {
            CalculateTotalCost();
              return total;
        }

        public override string toString()
        {
            return "total cost for utility droid: " + this.total + ", arm:" + arm + ",toolbox:" + toolbox + "connection:" + connection;
        }
    }
}