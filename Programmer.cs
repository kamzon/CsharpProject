using System;

namespace CsharpProject
{
    public class Programmer : Creator
    {
        public override void Create()
        {
            if (base._creativityLevel >= 70 && base._energy>= 80){
                this.BrainStormSolutions();
                this.PickMostOptimalSolution();
                this.WriteCode();
                this.TestCode();

            }else{
                throw new Exception("Cannot create a program. Out of ideas and/or tiered. ");
            }
        }
        private void BrainStormSolutions(){
            base._energy = base._energy - 10;
            base._creativityLevel = base._creativityLevel -15;

            Console.WriteLine("Brainstorming solutions ...");


        }

        private void PickMostOptimalSolution(){
            base._energy = base._energy - 5;
            base._creativityLevel = base._creativityLevel -5;

            Console.WriteLine("Picking most optimal solutions ...");
            
        }

        private void WriteCode(){

            base._energy = base._energy - 7;
            base._creativityLevel = base._creativityLevel -5;

            Console.WriteLine("Writing code ...");
            
        }

        private void TestCode(){
            base._energy = base._energy - 3;
            base._creativityLevel = base._creativityLevel -3;

            Console.WriteLine("Testing code ...");
            
        }
    }
}