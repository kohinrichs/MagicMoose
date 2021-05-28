using System;
using System.Collections.Generic;

namespace MagicMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Magic Moose!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            List<string> PossibleResponses = new List<string>()
            {
                "As I see it, yes.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don’t count on it.",
                "It is certain.",
                "It is decidedly so.",
                "Most likely.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Outlook good.",
                "Reply hazy, try again.",
                "Signs point to yes.",
                "Very doubtful.",
                "Without a doubt.",
                "Yes.",
                "Yes – definitely.",
                "You may rely on it."
            };

        
             // Let the moose speak!
            MooseSays("H E L L O! Ask me a question!");
           
            string question = Console.ReadLine(); 
        
            while (true) 
            {
                // One way to do it
                // if (question.Equals(""))
                // {
                //     break;
                // }
                
                // Second way to do it
                if (string.IsNullOrWhiteSpace(question))
                {
                    break;
                }
                else 
                {
                    Random r = new Random();
                    int magicNumber = r.Next(0, 19);

                    MooseSays(PossibleResponses[magicNumber]);
                }

                Console.WriteLine("   --------------------------------------------");
                Console.WriteLine();
                MooseSays("Ask me another question!");
                question = Console.ReadLine();
            }


            void MooseSays(string message)
            {
                Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
            }
        }
    }
}
