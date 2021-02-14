using System;

public abstract class Creator {

    public int _energy = 100;
    public int _creativityLevel = 100;

    public abstract void Create();


/*
    public int _energy{
        get{
            return _energy;
        }
        set{
            if(value>=0 && value <=100){
                _energy = value;
            }else{
                throw new Exception("Energy level can only be a value betwen 0 and 100.");
            }
        }
    }

    public int _creativityLevel{
        get{
            return _creativityLevel;
        }
        set{
            if(value>=0 && value <=100){
                _energy = value;
            }else{
                throw new Exception("Creativity level can only be a value betwen 0 and 100.");
            }
        }
    }
*/

}