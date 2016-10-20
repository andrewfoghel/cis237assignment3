using System;

namespace cis237assignment3
{
    //INHERITANCE AND ABSTRACT CLASS
    internal abstract class Droid : IDroid
    {

        //Added variables
        string model;
        string material;
        string color;
        decimal baseCost;
        string[] materials = { "titanium", "aluminum", "steel"};
        string[] models = { "R2D2", "C3P0", "BB-8" };
        decimal modelcost;
        decimal materialcost;

        //   decimal totalCost;

        //made constructor
        public Droid(string model,string material,string color)
        {
            this.model = model;
            this.material = material;
            this.color = color;
        }

        //Base cost method
        public decimal CalculateBaseCost()
        {
           
           
            if (material.Equals(materials[0]))
            {
                materialcost = 20;
            }else if (material.Equals(materials[1])){
                materialcost = 30;
            }else if (material.Equals(materials[2]))
            {
                materialcost = 40;
            }

            if (model.Equals(model[0]))
            {
                modelcost = 20;
            }
            else if (model.Equals(model[1]))
            {
                modelcost = 30;
            }
            else if (model.Equals(model[2]))
            {
                modelcost = 40;
            }



            baseCost = modelcost * materialcost;

            return baseCost;
        }



        public decimal totalCost
        {
            get
            {
                return totalCost;
            }

            set
            {
                CalculateTotalCost();
                
            }
        }

        public virtual void CalculateTotalCost()
        {
            totalCost = baseCost;
        }

        public abstract string toString();
       

    }
}