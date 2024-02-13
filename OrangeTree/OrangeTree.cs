using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        public int Age {
            get { return age; }
            set { if (age < 0) { age = value; } else { age = 0; }; }
        }
        private int height; 
            public int Height{  
            get { return height; } 
            set { height = value; }
        }
        private bool treeAlive;
        public bool TreeAlive { 
            get { return treeAlive; }
            set { treeAlive = value; }
        }
        private int numOranges;
        public int NumOranges { 
            get { return numOranges; } 
            set { numOranges = value; }
        }
        private int orangesEaten;
        public int OrangesEaten { 
            get {  return orangesEaten; } 
            set {  orangesEaten = value; }
        }



        
        public void OneYearPasses() 
        {
            orangesEaten = 0;
            numOranges = 0;
            this.age++;
            if (this.age < 80)
            {
                this.height += 2;
            } else {
                treeAlive = false;
            }
            if (this.age > 0)
            {
                this.numOranges = (age-1) * 5;
            } 
            if (!treeAlive)
            {
                this.numOranges = 0;
                //this.height = 0;
            }
        }
        public void EatOrange(int count)
        {
            if (numOranges > count) {
                numOranges -= count;
                orangesEaten += count;
            }
        } 
    }
}