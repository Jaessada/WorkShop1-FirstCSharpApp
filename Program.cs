Console.WriteLine("Hello, World!");
Console.WriteLine( "Hello, C#! " );
Console.WriteLine( "Welcome to .NET");
Console.WriteLine("My First C# Application");

Console.WriteLine("---------------------------------");

Console.WriteLine("โปรแกรมแนะนำตัวเอง");
Console.WriteLine("โปรดกรอกข้อมูลของคุณ");

String name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!.");
Console.WriteLine("---------------------------------");
Console.WriteLine("ขอบคุณที่ใช้โปรแกรมนี้");

strLine("-", 30);
void strLine( string strInput , int n)
{
    string strOutput = "";
    for (int i = 0; i < n; i++)
    {
        strOutput += strInput;
    }
    Console.WriteLine(strOutput);
}
