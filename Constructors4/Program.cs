using System;

namespace Constructors_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //StructTest test;
            //test.t = 7;
            //test.MethodStruct(9);
            StructTest test2 = new StructTest();
            test2.t = 9;

            StructTest test3 = new StructTest(7);
            //Console.WriteLine("Hello World!");
        }
    }

    public struct StructTest
    {
        public int t;
        public string MethodStruct(int t)
        {

            return "all is good";
        }
        public StructTest(int a, int yuy)
        {
            this.t = 7;
            MethodStruct(yuy);
        }
        public StructTest(int r)
        {
            this.t = r;
        }
        //public StructTest(int b)
        //{
        //    this.t =  b;
        //}
        //~StructTest()
        //{

        //}
    }
}



//        Some of the key points regarding constructor are
//A class can have any number of constructors.
//A constructor doesn't have any return type, not even void.
//A static constructor can not be a parametrized constructor.
//Within a class, you can create one static constructor only.

//(Don't get hung up on the word 'destructor ' here; we're basically
//talking about a magic method on structs that gets called automatically
//when the variable goes out of scope. In other words, a language feature
//analogous to C++'s destructors.)

//The first thing to realize is that we don't care about releasing memory.
//Whether the object is on the stack or on the heap (eg. a struct in a class),
//the memory will be taken care of one way or another sooner or later; either
//by being popped off the stack or by being collected. The real reason for having
//something that's destructor-like in the first place is for managing external
//resources - things like file handles, window handles, or other things that
//need special handling to get them cleaned up that the CLR itself doesn't know about.

//Now supposed you allow a struct to have a destructor that can do this cleanup..
//Fine. Until you realize that when structs are passed as parameters, they get passed
//by value: they are copied. Now you've got two structs with the same internal fields,
//and they're both going to attempt to clean up the same object. One will happen first,
//and so code that is using the other one afterwards will start to fail mysteriously...
//and then its own cleanup will fail (hopefully! - worst case is it might succeed in
//cleaning up some other random resource - this can happen in situations where handle
//values are reused, for example.)

//You could conceivably make a special case for structs that are parameters
//so that their 'destructors' don't run (but be careful - you now need to
//remember that when calling a function, it's always the outer one that
//'owns' the actual resource - so now some structs are subtly different
//to others...) -but then you still have this problem with regular struct
//variables, where one can be assigned to another, making a copy.

//You could perhaps work around this by adding a special mechanism to
//assignment operations that somehow allows the new struct to negotiate
//ownership of the underlying resource with its new copy - perhaps they
//share it or transfer ownership outright from the old to the new -
//but now you've essentially headed off into C++-land, where you need
//copy constructors, assignment operators, and have added a bunch of
//subtleties waiting to trap the unaware novice programmer. And keep
//in mind that the entire point of C# is to avoid that type of C++-style
//complexity as much as possible.

//And, just to make things a bit more confusing, as one of the other
//answers pointed out, structs don't just exist as local objects.
//With locals, scope is nice and well defined; but structs can also
//be members of a class object. When should the 'destructor' get
//called in that case? Sure, you can do it when the container class is
//finalized; but now you have a mechanism that behaves very differently
//depending on where the struct lives: if the struct is a local, it
//gets triggered immediately at end of scope; if the struct is
//within a class, it gets triggered lazily... So if you really
//care about ensuring that some resource in one of your structs is
//cleaned up at a certain time, and if your struct could end up as a
//member of a class, you'd probably need something explicit like
//IDisposable/using () anyhow to ensure you've got your bases covered.

//So while I can't claim to speak for the language designers, I
//can make a pretty good guess that one reason they decided not
//to include such a feature is because it would be a can of worms,
//and they wanted to keep C# reasonably simple.

