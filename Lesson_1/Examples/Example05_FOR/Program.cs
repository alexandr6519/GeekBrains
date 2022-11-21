Console.Clear();
/*Console.SetCursorPosition(1, 10);
Console.WriteLine("*");
Console.SetCursorPosition(30, 0);
Console.WriteLine("*");
Console.SetCursorPosition(60, 10);
Console.WriteLine("*");*/
int a1 = 1, a2 = 16, b1 = 40, b2 = 0, c1 = 80, c2 = 16;

Console.SetCursorPosition(a1, a2);
Console.WriteLine("*");

Console.SetCursorPosition(b1, b2);
Console.WriteLine("*");

Console.SetCursorPosition(c1, c2);
Console.WriteLine("*");

 int n = 10000;
 int x = a1;
 int y = a2;
        
for (int i = 0; i < n; i++) {
    int what = new Random().Next(0, 3);
        if (what == 0) {
            x = (x + a1) / 2;
            y = (y + a2) / 2;
        } 
        if (what == 1) {
            x = (x + b1) / 2;
            y = (y + b2) / 2;
        } 
        if (what == 2) {
            x = (x + c1) / 2;
            y = (y + c2) / 2;
        } 
Console.SetCursorPosition(x, y);
Console.WriteLine("*");
}

