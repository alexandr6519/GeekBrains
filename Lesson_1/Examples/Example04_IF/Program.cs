Console.WriteLine("Input name of user!");
string username = Console.ReadLine();

if (username.ToLower() == "alex") {
    Console.WriteLine("O, Aleksandr, welcome!");
} else {
    Console.Write(username);
    Console.WriteLine("Good day!"); 
}

