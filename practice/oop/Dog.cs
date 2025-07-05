using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog
{

    string name;
    string breed;
    int age;
    string color;

    public Dog(string name, string breed, int age, string color)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
        this.color = color;
    }

    public string getName()
    {
        return this.name;
    }

    public string getBreed()
    {
        return this.breed;
    }

    public int getAge()
    {
        return this.age;
    }

    public string getColor()
    {
        return this.color;
    }

    public override string ToString()
    {
        return $"My name is {this.name} \n My breed is {this.breed} \n My age is {this.age} \n my color is {this.color}";
    }


    public static void Main(string[] args)
    {
        Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
        Console.WriteLine(tuffy.ToString());
    }
}
