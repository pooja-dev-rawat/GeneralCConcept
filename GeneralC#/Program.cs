// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;


//Value type reference 
class program
{
    static void Main(string[] args)
    {
        // this is the clear example of value type variable and the calues are stored in stack
        int x = 100, y = 200;

        Console.WriteLine(x);
        Console.WriteLine(y);

        y = 300;

        Console.WriteLine(x);
        Console.WriteLine(y);

    }


}

class User
{
    public int age = 32;
}

class program2
{
    static void Main(string[] args)
    {
        User user1 = new User();
        User user2 = user1;

        Console.WriteLine($"User1 age will be " + user1.age + " User 2 age will be " + user2.age);

        //Suppose i am updating the value of user 1 age then see what will bne the out put

        user2.age = 45;

        Console.WriteLine($"User 1 age will be " + user1.age + " user 2 age will be " + user2.age);


    }


}

