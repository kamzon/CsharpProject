using System;

namespace CsharpProject
{
    public class Youtuber : Creator
    {
        
        public override void Create()
        {
            if (base._creativityLevel >= 50 && base._energy>= 50){
                this.BrainStormVideoIdeas();
                this.CreateScript();
                this.VideotapeScript();
                this.EditingVideo();
                this.RenderingVideo();

            }else{
                throw new Exception("Cannot create a video. Out of ideas and/or tiered. ");
            }
        }
        private void BrainStormVideoIdeas(){
            base._energy = base._energy - 5;
            base._creativityLevel = base._creativityLevel -5;

            Console.WriteLine("Brainstorming video ideas ...");


        }

        private void CreateScript(){
            base._energy = base._energy - 5;
            base._creativityLevel = base._creativityLevel -5;

            Console.WriteLine("Creating a video script ...");
            
        }

        private void VideotapeScript(){

            base._energy = base._energy - 10;
            base._creativityLevel = base._creativityLevel -1;

            Console.WriteLine("Videotaping myself executing the script ...");
            
        }

        private void EditingVideo(){
            base._energy = base._energy - 5;
            base._creativityLevel = base._creativityLevel -5;

            Console.WriteLine("Editing the video ...");
            
        }
        private void RenderingVideo(){
            base._energy = base._energy - 1;
            base._creativityLevel = base._creativityLevel -1;

            Console.WriteLine("Rendering the video ...");
            
        }
    }
}