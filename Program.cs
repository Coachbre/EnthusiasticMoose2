using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Let the moose speak!
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");


//call MooseAsks function
bool isTrue = MooseAsks("Is Canada Real?");
Console.WriteLine(isTrue);



//ask a yes or no question and take answer (Y or N) and turn it to lowercase.
//if answer is outside parameters, ask question again. Y= true and N=false
bool MooseAsks(string question)
{
  Console.Write($"{question} (Y/N): ");
  string answer = Console.ReadLine().ToLower();

  while (answer != "y" && answer != "n")
  {
    Console.Write($"{question} (Y/N):");
    answer = Console.ReadLine().ToLower();
  }

  if (answer == "y")
  { return true;} else
  { return false;}
}





// @ allows for a multiline string
// $ allows for string interpolation
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
