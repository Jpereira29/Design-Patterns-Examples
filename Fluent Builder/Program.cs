using System;

namespace FluentBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailBuilder = new EmailBuilder();

            var email = emailBuilder
                       .To("microsoft@email.com")
                       .From("jorgepereira29ele@gmail.com")
                       .Subject("Micrsofot Build")
                       .Body("Microsoft Build 2023\n\t11 a 27 de Janeiro 2023" +
                                "\n\tNovidades Windows, Azure, Office e mais")
                       .CriaEmail();

            Console.WriteLine(email.ToString());
            Console.ReadLine();
        }
    }
}
