using System;
using System.Collections.Generic;
using System.Text;

namespace GymSystem
{
    public class ResistanceMachine : Equipment
    {
        private int weightStackMax;

        public int WeightStackMax
        {
            get { return weightStackMax; }
            set { weightStackMax = value; }
        }

        public ResistanceMachine(int equipmentId, string name, bool isAvailable, int weightStackMax)
            : base(equipmentId, name, isAvailable)
        {
            this.weightStackMax = weightStackMax;
        }
    }
}
