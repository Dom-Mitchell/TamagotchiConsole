using System;
using System.Collections.Generic;
using System.Drawing;
using Pastel;

namespace TamagotchiConsole
{
    class Program
    {
        // static void PokeTop(string s)
        // {
        //     Console.BackgroundColor = ConsoleColor.DarkRed;
        //     Console.ForegroundColor = ConsoleColor.Black;
        //     Console.WriteLine(s);
        //     Console.ResetColor();
        // }

        // static void PokeBot(string s)
        // {
        //     Console.BackgroundColor = ConsoleColor.White;
        //     Console.ForegroundColor = ConsoleColor.Black;
        //     Console.WriteLine(s);
        //     Console.ResetColor();
        // }

        static string Hippo()
        {
            var part1 = @"      c~~p ,---------.    ".Pastel(Color.SteelBlue);
            var part2 = @" ,---'".Pastel(Color.SteelBlue) + "oo".Pastel(Color.ForestGreen) + @"  )           \".Pastel(Color.SteelBlue);
            var part3 = @"(".Pastel(Color.SteelBlue) + " O O".Pastel(Color.DimGray) + "                  )/ ".Pastel(Color.SteelBlue);
            var part4 = @" `".Pastel(Color.SteelBlue) + "=".Pastel(Color.WhiteSmoke) + "^".Pastel(Color.LightPink) + "=".Pastel(Color.WhiteSmoke) + "'                 /".Pastel(Color.SteelBlue);
            var part5 = @"       \    ,     .   /   ".Pastel(Color.SteelBlue);
            var part6 = @"       \".Pastel(Color.DimGray) + @"\".Pastel(Color.SteelBlue) + "  |-----'|  /    ".Pastel(Color.SteelBlue);
            var part7 = @"       |".Pastel(Color.DimGray) + "|__|".Pastel(Color.SteelBlue) + "    |_".Pastel(Color.DimGray) + "|__|".Pastel(Color.SteelBlue);

            return $"{part1}\n{part2}\n{part3}\n{part4}\n{part5}\n{part6}\n{part7}";
        }

        static string Scorpion()
        {
            var part1 = @"  ___    ___   ".Pastel(Color.RoyalBlue);
            var part2 = @" ( _<    >_ )  ".Pastel(Color.RoyalBlue);
            var part3 = @" //        \\  ".Pastel(Color.RoyalBlue);
            var part4 = @" \\___".Pastel(Color.RoyalBlue) + "..".Pastel(Color.OrangeRed) + "___//  ".Pastel(Color.RoyalBlue);
            var part5 = @"  `-(    )-'   ".Pastel(Color.RoyalBlue);
            var part6 = @"    _|__|_     ".Pastel(Color.RoyalBlue);
            var part7 = @"   /_|__|_\    ".Pastel(Color.RoyalBlue);
            var part8 = @"   /_|__|_\    ".Pastel(Color.RoyalBlue);
            var part9 = @"   /_\__/_\    ".Pastel(Color.RoyalBlue);
            var part10 = @"    \ || /  _".Pastel(Color.RoyalBlue) + ") ".Pastel(Color.WhiteSmoke);
            var part11 = @"      ||   ( ) ".Pastel(Color.RoyalBlue);
            var part12 = @"      \\___//  ".Pastel(Color.RoyalBlue);
            var part13 = @"       `---'   ".Pastel(Color.RoyalBlue);

            return $"{part1}\n{part2}\n{part3}\n{part4}\n{part5}\n{part6}\n{part7}\n{part8}\n{part9}\n{part10}\n{part11}\n{part12}\n{part13}";
        }

        static string ShinyCharizard()
        {
            var part1 = @"                 .' -,.__                                                  ".Pastel(Color.RoyalBlue);
            var part2 = @"                  `.     `.__,                                             ".Pastel(Color.RoyalBlue);
            var part3 = @"               .--'".Pastel(Color.RoyalBlue) + "  .._,''".Pastel(Color.OrangeRed) + "- '".Pastel(Color.OrangeRed) + "`.                                          ".Pastel(Color.RoyalBlue);
            var part4 = @"              .".Pastel(Color.RoyalBlue) + "    .'         `'                                           ".Pastel(Color.OrangeRed);
            var part5 = @"              `.".Pastel(Color.RoyalBlue) + @"   /          ,'                                           ".Pastel(Color.OrangeRed);
            var part6 = @"                `".Pastel(Color.RoyalBlue) + "  '--.   ,-''                                             ".Pastel(Color.OrangeRed);
            var part7 = @"                 `'".Pastel(Color.RoyalBlue) + @"`".Pastel(Color.Gold) + @"   |  \                                                ".Pastel(Color.OrangeRed);
            var part8 = @"                    -.".Pastel(Color.Gold) + @" \, |                                                ".Pastel(Color.OrangeRed);
            var part9 = @"                     `--Y.'".Pastel(Color.Gold) + @"      ___.                                      ".Pastel(Color.LightSlateGray);
            var part10 = @"                          \".Pastel(Color.Gold) + @"     |._, \                                    ".Pastel(Color.LightSlateGray);
            var part11 = @"                _.,".Pastel(Color.LightSlateGray) + "        `.".Pastel(Color.Gold) + "   <".Pastel(Color.WhiteSmoke) + "  <".Pastel(Color.WhiteSmoke) + @"\ \              _                    ".Pastel(Color.LightSlateGray);
            var part12 = @"              ,' '".Pastel(Color.LightSlateGray) + "           `,".Pastel(Color.Gold) + @" `.   | \            ( `                   ".Pastel(Color.LightSlateGray);
            var part13 = @"           ../, `.".Pastel(Color.LightSlateGray) + "            `".Pastel(Color.Gold) + "  |    .".Pastel(Color.LightSlateGray) + @"\`.".Pastel(Color.DarkRed) + @"           \ \_                 ".Pastel(Color.LightSlateGray);
            var part14 = @"          ,'".Pastel(Color.LightSlateGray) + " ,..".Pastel(Color.DarkRed) + @"  .".Pastel(Color.LightSlateGray) + "           _.,".Pastel(Color.Salmon) + "'    ||".Pastel(Color.LightSlateGray) + @"\|".Pastel(Color.DarkRed) + "            )  ''.              ".Pastel(Color.LightSlateGray);
            var part15 = @"         ,".Pastel(Color.LightSlateGray) + @" ,'   \".Pastel(Color.DarkRed) + @" \".Pastel(Color.LightSlateGray) + "         ,'".Pastel(Color.Salmon) + ".-.".Pastel(Color.PaleVioletRed) + "`-._,".Pastel(Color.Salmon) + "'  |           .".Pastel(Color.LightSlateGray) + "  _._".Pastel(Color.DarkRed) + "`.             ".Pastel(Color.LightSlateGray);
            var part16 = @"       ,'".Pastel(Color.LightSlateGray) + @" /      \".Pastel(Color.DarkRed) + @" \".Pastel(Color.LightSlateGray) + "        `' ' `--".Pastel(Color.Salmon) + @"/   | \          /".Pastel(Color.LightSlateGray) + @" /   \ ".Pastel(Color.DarkRed) + @"\            ".Pastel(Color.LightSlateGray);
            var part17 = @"     .'".Pastel(Color.LightSlateGray) + @"  /        \".Pastel(Color.DarkRed) + @" .         |\__ - _ ,'` `        /".Pastel(Color.LightSlateGray) + @" /     `.".Pastel(Color.DarkRed) + "`.          ".Pastel(Color.LightSlateGray);
            var part18 = @"     |".Pastel(Color.LightSlateGray) + @"  '          .".Pastel(Color.DarkRed) + ".         `-...-'  |  `-'      /".Pastel(Color.LightSlateGray) + @" /        .".Pastel(Color.DarkRed) + " `.        ".Pastel(Color.LightSlateGray);
            var part19 = @"     |".Pastel(Color.LightSlateGray) + @" /           |".Pastel(Color.DarkRed) + "|__           |    |          /".Pastel(Color.LightSlateGray) + @" /          `.".Pastel(Color.DarkRed) + " `.      ".Pastel(Color.LightSlateGray);
            var part20 = @"    ,".Pastel(Color.LightSlateGray) + @" /            .".Pastel(Color.DarkRed) + @"   .          |    |         /".Pastel(Color.LightSlateGray) + @" /             `".Pastel(Color.DarkRed) + " `      ".Pastel(Color.LightSlateGray);
            var part21 = @"   /".Pastel(Color.LightSlateGray) + @" /".Pastel(Color.DarkRed) + "          ,. ".Pastel(Color.WhiteSmoke) + "` ".Pastel(Color.DarkRed) + @"._".Pastel(Color.DarkRed) + @" `-_       |    |  _   ,-'".Pastel(Color.LightSlateGray) + @" /               `".Pastel(Color.DarkRed) + @" \     ".Pastel(Color.LightSlateGray);
            var part22 = @"  /".Pastel(Color.LightSlateGray) + @" .".Pastel(Color.DarkRed) + "           \'`_".Pastel(Color.WhiteSmoke) + @" /.".Pastel(Color.WhiteSmoke) + " `-_".Pastel(Color.DarkRed) + @" \_,.  ,'    +-' `-'".Pastel(Color.LightSlateGray) + @"   /".Pastel(Color.DarkRed) + @"          .,-.".Pastel(Color.RoyalBlue) + @"   \".Pastel(Color.DarkRed) + @"`.    ".Pastel(Color.LightSlateGray);
            var part23 = @" .".Pastel(Color.LightSlateGray) + @"  '".Pastel(Color.DarkRed) + "         .-f".Pastel(Color.WhiteSmoke) + "    ,'".Pastel(Color.WhiteSmoke) + "   `".Pastel(Color.DarkRed) + @"  ,/'        \".Pastel(Color.LightSlateGray) + " ,.-- -` ".Pastel(Color.DarkRed) + @",.    ".Pastel(Color.WhiteSmoke) + "   .'   '".Pastel(Color.RoyalBlue) + @"   \".Pastel(Color.DarkRed) + @" \   ".Pastel(Color.LightSlateGray);
            var part24 = @" '".Pastel(Color.LightSlateGray) + @" /".Pastel(Color.DarkRed) + "          `.'".Pastel(Color.WhiteSmoke) + @"    |     .' /".Pastel(Color.LightSlateGray) + @"          \  ".Pastel(Color.LightSlateGray) + @"      '`_ /.".Pastel(Color.WhiteSmoke) + "   /".Pastel(Color.RoyalBlue) + " .,'`".Pastel(Color.OrangeRed) + @"    \`".Pastel(Color.DarkRed) + @"\  ".Pastel(Color.LightSlateGray);
            var part25 = @" |".Pastel(Color.LightSlateGray) + @"'      _.-""`\".Pastel(Color.DarkRed) + @" `.    \ _,'_/`            \-, ".Pastel(Color.LightSlateGray) + " .-f".Pastel(Color.WhiteSmoke) + @"     ".Pastel(Color.LightSlateGray) + ",'".Pastel(Color.WhiteSmoke) + " ,".Pastel(Color.RoyalBlue) + " |   |".Pastel(Color.OrangeRed) + @"     |".Pastel(Color.DarkRed) + @"| ".Pastel(Color.LightSlateGray);
            var part26 = @" |".Pastel(Color.LightSlateGray) + @"|    ,'      `.".Pastel(Color.DarkRed) + @" `.   '".Pastel(Color.LightSlateGray) + "       _,...._".Pastel(Color.Bisque) + @"      ".Pastel(Color.LightSlateGray) + " `.".Pastel(Color.LightSlateGray) + " '".Pastel(Color.WhiteSmoke) + "     /".Pastel(Color.LightSlateGray) + "  '".Pastel(Color.RoyalBlue) + "  |   '".Pastel(Color.OrangeRed) + @"     .".Pastel(Color.DarkRed) + @"|  ".Pastel(Color.LightSlateGray);
            var part27 = @" |".Pastel(Color.LightSlateGray) + "|  ,'          `.".Pastel(Color.DarkRed) + " ;.,.---'".Pastel(Color.LightSlateGray) + " ,'        `.".Pastel(Color.Bisque) + @"   .  `-'  .-  ".Pastel(Color.LightSlateGray) + @"/".Pastel(Color.RoyalBlue) + "_ .'    ;".Pastel(Color.OrangeRed) + @"__".Pastel(Color.DarkRed) + @"  |".Pastel(Color.DarkRed) + @"|  ".Pastel(Color.LightSlateGray);
            var part28 = @" |".Pastel(Color.LightSlateGray) + "| '              V".Pastel(Color.DarkRed) + "      /".Pastel(Color.LightSlateGray) + @" /            \".Pastel(Color.Bisque) + @" \ `\   ,'".Pastel(Color.LightSlateGray) + @"  ,' '.".Pastel(Color.Gold) + "    !".Pastel(Color.WhiteSmoke) + " | ".Pastel(Color.Gold) + @" \ |".Pastel(Color.DarkRed) + @"|  ".Pastel(Color.LightSlateGray);
            var part29 = @" |".Pastel(Color.LightSlateGray) + "|/".Pastel(Color.DarkRed) + "            _,-------/".Pastel(Color.LightSlateGray) + @" '              \".Pastel(Color.Bisque) + @" |  `-'".Pastel(Color.LightSlateGray) + @"    (          /   ".Pastel(Color.Gold) + @"\|".Pastel(Color.DarkRed) + @"|  ".Pastel(Color.LightSlateGray);
            var part30 = @" .".Pastel(Color.LightSlateGray) + " |          ,'".Pastel(Color.LightSlateGray) + " .-".Pastel(Color.Silver) + "   ,' |".Pastel(Color.LightSlateGray) + @"|               |".Pastel(Color.Bisque) + @" .-.".Pastel(Color.LightSlateGray) + "        `.      .'".Pastel(Color.Gold) + "     ||  ".Pastel(Color.LightSlateGray);
            var part31 = @"  `".Pastel(Color.LightSlateGray) + "'        ,'".Pastel(Color.LightSlateGray) + "    `'".Pastel(Color.Silver) + ".'".Pastel(Color.LightSlateGray) + @"    |               |".Pastel(Color.Bisque) + @"/   `.        ".Pastel(Color.LightSlateGray) + "'. -.'".Pastel(Color.Gold) + "       `'  ".Pastel(Color.LightSlateGray);
            var part32 = @"           /      ,'".Pastel(Color.LightSlateGray) + @"      |               |".Pastel(Color.Bisque) + @",'".Pastel(Color.Silver) + @"    \-.._,.'".Pastel(Color.LightSlateGray) + "/'               ".Pastel(Color.Bisque);
            var part33 = @"          /.".Pastel(Color.Bisque) + "     /".Pastel(Color.LightSlateGray) + @"        .               .".Pastel(Color.Bisque) + @"       \".Pastel(Color.LightSlateGray) + "    .''                ".Pastel(Color.Bisque);
            var part35 = @"           \ `...".Pastel(Color.Bisque) + @"\".Pastel(Color.LightSlateGray) + "   _     ,".Pastel(Color.Silver) + @"'-.        .'".Pastel(Color.Bisque) + @"__".Pastel(Color.Silver) + "        /".Pastel(Color.LightSlateGray) + "_.-'                   ".Pastel(Color.Bisque);
            var part34 = @"          .`.".Pastel(Color.Bisque) + "   |".Pastel(Color.LightSlateGray) + @"         `.             /".Pastel(Color.Bisque) + @"         :".Pastel(Color.LightSlateGray) + "_,'.'                 ".Pastel(Color.Bisque);
            var part36 = @"            `-.__ ".Pastel(Color.Bisque) + "`".Pastel(Color.LightSlateGray) + ",  `'___.    ".Pastel(Color.Silver) + @">----''".Pastel(Color.Bisque) + @" |".Pastel(Color.LightSlateGray) + "   `'___.".Pastel(Color.Silver) + @"/                        ".Pastel(Color.LightSlateGray);
            var part37 = @"                 .".Pastel(Color.WhiteSmoke) + "'        /           _.".Pastel(Color.LightSlateGray) + "'      /                        ".Pastel(Color.LightSlateGray);
            var part38 = @"                /_|.-'\ ,'.           /_|.-'\ ,'.                       ".Pastel(Color.WhiteSmoke);
            var part39 = @"                  /_,'''\,'             /_,''".Pastel(Color.WhiteSmoke) + @"'\,'                      ".Pastel(Color.WhiteSmoke);

            return $"{part1}\n{part2}\n{part3}\n{part4}\n{part5}\n{part6}\n{part7}\n{part8}\n{part9}\n{part10}\n{part11}\n{part12}\n{part13}\n{part14}\n{part15}\n{part16}\n{part17}\n{part18}\n{part19}\n{part20}\n{part21}\n{part22}\n{part23}\n{part24}\n{part25}\n{part26}\n{part27}\n{part28}\n{part29}\n{part30}\n{part31}\n{part32}\n{part33}\n{part34}\n{part35}\n{part36}\n{part37}\n{part38}\n{part39}";
        }

        static string Sonic()
        {
            var part1 = @"         ___------__     ";
            var part2 = @"  |\__-- /\       _-     ";
            var part3 = @"  |/    __      -        ";
            var part4 = @"  //\  /  \    /__       ";
            var part5 = @"  |  o|  0|__     --_    ";
            var part6 = @"  \\____-- __ \   ___-   ";
            var part7 = @"  (@@    __/  / /_       ";
            var part8 = @"     -_____---   --_     ";
            var part9 = @"      //  \ \\   ___-    ";
            var part10 = @"    //|\__/  \\  \      ";
            var part11 = @"    \_-\_____/  \-\     ";
            var part12 = @"         // \\--\|      ";
            var part13 = @"    ____//  ||_         ";
            var part14 = @"   /_____\ /___\        ";
            var part15 = @" ______________________ ";

            return $"{part1}\n{part2}\n{part3}\n{part4}\n{part5}\n{part6}\n{part7}\n{part8}\n{part9}\n{part10}\n{part11}\n{part12}\n{part13}\n{part14}\n{part15}";
        }

        static void Main(string[] args)
        {
            // PokeTop(@"  _____                                 _       _     _        ____           _             ");
            // PokeTop(@" |_   _|_ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__ (_)      / ___|___ _ __ | |_ ___ _ __  ");
            // PokeTop(@"   | |/ _` | '_ ` _ \ / _` |/ _` |/ _ \| __/ __| '_ \| |_____| |   / _ \ '_ \| __/ _ \ '__| ");
            // PokeBot(@"   | | (_| | | | | | | (_| | (_| | (_) | || (__| | | | |_____| |__|  __/ | | | ||  __/ |    ");
            // PokeBot(@"   |_|\__,_|_| |_| |_|\__,_|\__, |\___/ \__\___|_| |_|_|      \____\___|_| |_|\__\___|_|    ");
            // PokeBot(@"                            |___/                                                           ");
            // Console.ResetColor();

            //{"  ___    ___   ".Pastel(Color.Black)}
            //{" ( _<    >_ )  ".Pastel(Color.Black)}
            //{" //        \\  ".Pastel(Color.Black)}
            //{" \\___".Pastel(Color.Black)}{"..".Pastel(Color.OrangeRed)}{"___//  ".Pastel(Color.Black)}
            //{"  `-(    )-'   ".Pastel(Color.Black)}
            //{"    _|__|_     ".Pastel(Color.Black)}
            //{"   /_|__|_\    ".Pastel(Color.Black)}
            //{"   /_|__|_\    ".Pastel(Color.Black)}
            //{"   /_\__/_\    ".Pastel(Color.Black)}
            //{"    \ || /  _) ".Pastel(Color.Black)}
            //{"      ||   ( ) ".Pastel(Color.Black)}
            //{"      \\___//  ".Pastel(Color.Black)}
            //{"       `---'   ".Pastel(Color.Black)}



            var animals = new List<string>() { Hippo(), Scorpion(), ShinyCharizard(), Sonic() };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal}\n");
            }

        }
    }
}
