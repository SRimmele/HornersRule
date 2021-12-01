//Horner's Rule using C#/.NET implementation 
using System;
 
class Horners
{
    // Function that returns value of 
    // pn(x) = a[0] + a[1]x + ... + a[n-1]x^n-1 + a[n]x^n
    // inputs: a, n, and x, where a is the coefficient.
    static double horner(double []a, int n, int x)
    {
        // Initialize result
        double result = a[0];
 
        // Evaluate value of polynomial
        // using Horner's method
        // based on the pseudocode discussed in class
        for (int i = 1; i < n; i++)
            result = result * x + a[i];
        return result;
    }

    static void derivative(double[] a, int n){
        double[] a_new = new double[n]; //an array of power_new elements
       
        Console.Write("The first derivative is: \n");  
        for(int i = 0; i < n; i++){ 
            //Initialize the power of the polynomial
            int power = (n - (i + 1)); 
            int power_new = power - 1; 
            //multiply the power of n to the coeffecient at a[n]; 
            a_new[i] = (power * a[i]);
            Console.Write(a_new[i] + "x^" + (power_new) + " + ");
        }

        Console.Write("\n\n"); 
    }

    static void polynomial(int n, double[] a){
        Console.Write("The polynomial is: \n");  
            for(int i = 0; i < n; i++){
                int power = n - (i + 1);  

                Console.Write(a[i] + "x^" + (power) + " + ");
            }   

        Console.Write("\n\n"); 
    }
     
    // Driver Code
    static void Main()
    {
        // Evaluate value of:
        // 5x6 + x5 + 3x4 + 3x3 + x2 + 1 for x = 1 and
        // 1 - x2/2 + x4/24
        //double []a= {5.0, 1.0, 3.0, 3.0, 1.0, 0.0, 1.0};
        double []a = {0.041667, 0.0, -0.5, 0.0, 1.0};

        int x = 1; 
        int n = a.Length;  
        polynomial(n, a); 
        derivative(a, n); 

        Console.Write("The result at x = " + x +" is: " + horner(a,n,x));
        // output is the value of p(x) when x = 1. 
        
    }
}