using System;
using System.Linq;
using System.Text;

namespace RandomStringGenerator
{
  class Program
  {
    static void Main(string[] args)
    {
      // Option 1
      char[] charSet = "qwertyuiopasdfghjklzxcvbnm0987654321".ToCharArray();
      Random rand = new Random();
      StringBuilder sb = new StringBuilder();
      Enumerable.Range(0, 25).ToList().ForEach(_ => sb.Append(charSet[rand.Next(0, charSet.Length)])) ;
      Console.WriteLine(sb.ToString());

      // Option 2
      var randomString = Guid.NewGuid().ToString("N").Substring(0, 25);
      Console.WriteLine(randomString);

      // Option 3 - Not Alpha numeric - 0-9 & A-F : Hexadecimal chars
      var buffer = new byte[10];
      new Random().NextBytes(buffer);
      var x = string.Join("", buffer.Select(b => b.ToString("X2")));
      Console.WriteLine(x);
    }
  }
}
