namespace Partial_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Nicat","niko57");
            User user2 = new User("Pasha", "bmw");
            User user3 = new User("Ali", "aliko");
            user1.PasswordChecker("Abcd123kj");
            user1.ShowInfo();
            user2.PasswordChecker("Abcd123kj");
            user2.ShowInfo();
            user3.PasswordChecker("Abcd123kj");
            user3.ShowInfo();
        }

       
    }
    

}