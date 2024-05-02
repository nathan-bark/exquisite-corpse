static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }

   static void BuildACreature(string head, string body, string feet){
    int headNum = TranslateToNumber(head);
    int bodyNum = TranslateToNumber(body);
    int feetNum = TranslateToNumber(feet);

    SwitchCase(headNum, bodyNum, feetNum);
   }

   static void RandomMode(){
    Random randomNumber = new();
    int head = randomNumber.Next(1, 4);
    int body = randomNumber.Next(1, 4);
    int feet = randomNumber.Next(1, 4);

    SwitchCase(head, body, feet);
   }

   static void SwitchCase(int head, int body, int feet){
        switch (head){
            case 1:
                GhostHead();
                break;
            case 2:
                BugHead();
                break;
            case 3:
                MonsterHead();
                break;
            default:
                Console.WriteLine("Invalid Creature");
                break;
        }

        switch (body){
            case 1:
                GhostBody();
                break;
            case 2:
                BugBody();
                break;
            case 3:
                MonsterBody();
                break;
            default:
                Console.WriteLine("Invalid Creature");
                break;
        }

        switch (feet){
            case 1:
                GhostFeet();
                break;
            case 2:
                BugFeet();
                break;
            case 3:
                MonsterFeet();
                break;
            default:
                Console.WriteLine("Invalid Creature");
                break;
        }
   }

   static int TranslateToNumber(string creature){
        switch (creature){
            case "ghost":
                return 1;
            case "bug":
                return 2;
            case "monster":
                return 3;
            default:
                return 1;
        }
   }

Console.WriteLine("Creature Creator!");
Console.WriteLine("Would you like to create your own creature or have a random one generated?");
Console.WriteLine("Enter 'build' for your own creature or 'random' for a random creature.");
string response = Console.ReadLine();

if (response == "build"){
    Console.WriteLine("What head would you like your creature to have? (ghost, bug, monster)");
    string head = Console.ReadLine();
    Console.WriteLine("What body would you like your creature to have? (ghost, bug, monster)");
    string body = Console.ReadLine();
    Console.WriteLine("What feet would you like your creature to have? (ghost, bug, monster)");
    string feet = Console.ReadLine();

    BuildACreature(head, body, feet);
} else if (response == "random"){
    RandomMode();
} else {
    Console.WriteLine("Invalid response. Please try again.");
}