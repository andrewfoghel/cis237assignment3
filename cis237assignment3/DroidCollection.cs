using System.Collections.Generic;

namespace cis237assignment3
{
    internal class DroidCollection
    {
        UI x = new UI();
        List<IDroid> droids = new List<IDroid>();
        string[] droidString;
        decimal total = 0;

        public List<IDroid> addDroid()
        {
           IDroid droid = x.createDroid();
            droids.Add(droid);
            return droids;
        }
        public void printList()
        {
            foreach(IDroid x in droids)
            {
                System.Console.WriteLine(x.ToString());
            }  
        }
        public void totalCost()
        {
            foreach(IDroid x in droids)
            {
                total = total + x.totalCost;

            }
        }
    }
}