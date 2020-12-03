using System;

namespace _26.DiferenceBetweenAbstractClassAndAbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 
        } // abstract class ->                                 // Interface 
        //is a class that can not be instantiated !!!//     /// Methods can only be declared.
        // -his function is to be inherited!               // interface can be inherited by many classes, multiple inheritance
         // abstract class no Instance,                     // dont have a constructor! 
         //Abstract class no Instantiation!!!               //  we cant instatiating the interface !!! 
         // abstract class can be inherited , it is meant for; // can have public access modifier ! 
         // only by one other class ! no Multiple inheritance !! //interface provides full abstraction!!!!
         // no instantion ->                                   //  we can not declare an member field in interface! 
        //  no Object of Abstact class                       // by default everithing is public, So we cant declare:
         // can be made !                                      // public, private , protected; internal ;
         // Has one or more virtual methods
        // later in the child class to override it ;
        // Method can be declared and defined            //
         // Abstract class is fast in performance       // Interface is slow  because its implemeted in child classes
         // can have private , protected, public        //  can not HAVE -static, vitual , abstract, sealed
         // Abstract Class is Fast !                    // Interface is Slow in performance ! 
         // Anstract Class allows single inheritance   //  Interface provides multipole inheriatnce.
         // one class can ihherits one Abst class      // many classes can inheririt one abstract class ! 
         //  Methods fields , constants,,,etc          // interface can only contain Methods !!!
         // it can be partial, full and not implemented  //it can be only fully implemented  !

         //    Usage :                                         // Usage:

        // if many inplementations are of the same kind,   // if Many Implementations only share Methods then it is, 
        //and use common behavior then it is superior to use ,  // superior to use Methods ! 
        // an Abstract Class! 


    }
}
