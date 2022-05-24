using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{
    // this class will represent all food items in our program
    internal class Food
    {
        // properties (characteristics)
        // property declaration
        // accessModifier propertyType propertyName
        public string Name;
        // flavor
        public string Flavor;
        // texture
        public string Texture;
        // tasty
        private bool IsTasty;
        // portions
        public int Portions;
        // cost
        public float Cost;
        // calories
        public int Calories;
        // ingredients
        public List<string> Ingredients;

        // methods (functions / capabilities)
        // bundled set of code that performs actions on some kind of inputs and returns some output based
        // on those actions

        // RETURN - when something is being handed to us to use, we say that it is being returned to us
        // a function returns a string

        // constructor
        // constructor is a method that instantiates our object, either based on default values or
        // the values we provide to that method (inputs, parameters)

        // inputs are the values that we provide to a method/function in order for it to run
        // outputs are the values that a method/function HANDS to us to use
        // (we used this terminology with operators)

        // method template
        // accessModifier optionalModifiers returnType methodName(inputType inputName) {
        //      code we'd like to run
        // }

        // aM - same as with properties
        // oM - additional keywords that change how our methods work and can be called
        //         - static (you can call that method without needing to create an object first)
        // returnType - what TYPE of data is this method going to RETURN for us to use
        //         - void (indicates to us that the method DOES NOT RETURN ANYTHING!)
        // mN - name of the method
        // inputType inputName - variable declaration
        // code we'd like to run - code. if we have a return type, we MUST include the 'return' keyword somewhere.

        // default constructor, empty constructor
        // Method overloading - multiple methods have the same name but different inputs
        public Food() {
            Name = "Lasagna";
            Flavor = "Sour";
            Texture = "Hard";
            IsTasty = true;
            Cost = 5;
            Portions = 1;
            Calories = 500;
            Ingredients = new List<string>() {"pasta", "tomato sauce", "lemon" };
        }

        public Food(string name, string flavor, string texture, bool isTasty, int cost, int portions, int calories, List<string> ingredients)
        {
            Name = name;
            Flavor = flavor;
            Texture = texture;
            IsTasty = isTasty;
            Cost = cost;
            Portions = portions;
            Calories = calories;
            Ingredients = ingredients;
        }

        // performs an action, does not return a value
        public void Eat() {
            Portions--; // decreases portions value by 1.
        }

        public void Eat(int numToEat)
        {
            Portions -= numToEat;
        }

        // performs an action, does not require an object to use
        public static string DisplayMessage()
        {
            return "I love food!";
        }

        // returns a value, must be used on an object
        public bool IsFoodTasty()
        {
            return IsTasty;
        }
    }
}
