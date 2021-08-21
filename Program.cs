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
            // Hippo from https://www.asciiart.eu/animals/other-land
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
            // Scorpion from https://www.asciiart.eu/animals/scorpions
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
            // Sonic from https://www.asciiart.eu/video-games/sonic-the-hedgehog
            var part1 = @"         ___------__".Pastel(Color.RoyalBlue);
            var part2 = @"  |\".Pastel(Color.Bisque) + "__--".Pastel(Color.RoyalBlue) + @" /\".Pastel(Color.Bisque) + "       _-".Pastel(Color.RoyalBlue);
            var part3 = @"  |/    __      -".Pastel(Color.RoyalBlue);
            var part4 = @"  //\  /  \    /__".Pastel(Color.RoyalBlue);
            var part5 = @"  |".Pastel(Color.RoyalBlue) + "  o".Pastel(Color.ForestGreen) + "|".Pastel(Color.RoyalBlue) + "  0".Pastel(Color.ForestGreen) + "|".Pastel(Color.RoyalBlue) + "__".Pastel(Color.Bisque) + "     --_".Pastel(Color.RoyalBlue);
            var part6 = @"  \\".Pastel(Color.RoyalBlue) + @"____--".Pastel(Color.Bisque) + @" __".Pastel(Color.DimGray) + @" \".Pastel(Color.Bisque) + "   ___-".Pastel(Color.RoyalBlue);
            var part7 = @"  (".Pastel(Color.Bisque) + "@@".Pastel(Color.DimGray) + @"    __/".Pastel(Color.DimGray) + @"  /".Pastel(Color.Bisque) + " /_".Pastel(Color.RoyalBlue);
            var part8 = @"     -_____---".Pastel(Color.Bisque) + "   --_".Pastel(Color.RoyalBlue);
            var part9 = @"     //".Pastel(Color.RoyalBlue) + @"/  \".Pastel(Color.Bisque) + @" \\   ___-".Pastel(Color.RoyalBlue);
            var part10 = @"    //".Pastel(Color.WhiteSmoke) + "|".Pastel(Color.RoyalBlue) + @"\__/".Pastel(Color.Bisque) + @"  \\  \".Pastel(Color.RoyalBlue);
            var part11 = @"    \_-".Pastel(Color.WhiteSmoke) + @"\_____/  \-\".Pastel(Color.RoyalBlue);
            var part12 = @"         // \\--\|".Pastel(Color.RoyalBlue);
            var part13 = @"    ____".Pastel(Color.Red) + "//  ||".Pastel(Color.RoyalBlue) + "_".Pastel(Color.Red);
            var part14 = @"   /".Pastel(Color.Red) + "_____".Pastel(Color.WhiteSmoke) + @"\ /".Pastel(Color.Red) + "___".Pastel(Color.WhiteSmoke) + @"\".Pastel(Color.Red);
            var part15 = @" ______________________".Pastel(Color.Gold);

            return $"{part1}\n{part2}\n{part3}\n{part4}\n{part5}\n{part6}\n{part7}\n{part8}\n{part9}\n{part10}\n{part11}\n{part12}\n{part13}\n{part14}\n{part15}";
        }

        static string Deer()
        {
            // Buck from https://www.asciiart.eu/animals/deer
            var part1 = @"    /|       |\                         ".Pastel(Color.DarkSlateGray);
            var part2 = @" `__\\       //__'                      ".Pastel(Color.DarkSlateGray);
            var part3 = @"    ||      ||                          ".Pastel(Color.DarkSlateGray);
            var part4 = @"  \__`\     |'__/                       ".Pastel(Color.DarkSlateGray);
            var part5 = @"    `_\\   //_'                         ".Pastel(Color.DarkSlateGray);
            var part6 = @"    _".Pastel(Color.SaddleBrown) + @".,:---;,.".Pastel(Color.SandyBrown) + @"_                         ".Pastel(Color.SaddleBrown);
            var part7 = @"    \_".Pastel(Color.SaddleBrown) + @":".Pastel(Color.SandyBrown) + @"     :".Pastel(Color.SandyBrown) + @"_/                         ".Pastel(Color.SaddleBrown);
            var part8 = @"      |".Pastel(Color.SaddleBrown) + @"0".Pastel(Color.DodgerBlue) + @". .".Pastel(Color.Bisque) + @"0".Pastel(Color.DodgerBlue) + @"|                           ".Pastel(Color.SaddleBrown);
            var part9 = @"      |     |                           ".Pastel(Color.SaddleBrown);
            var part10 = @"      ,".Pastel(Color.SandyBrown) + @"\".Pastel(Color.SaddleBrown) + @".-.".Pastel(Color.Red) + @"/".Pastel(Color.SaddleBrown) + @" \                         ".Pastel(Color.SaddleBrown);
            var part11 = @"      ;;".Pastel(Color.SandyBrown) + @"`-'".Pastel(Color.Red) + @"   `---__________-----".Pastel(Color.SaddleBrown) + @".-.   ".Pastel(Color.WhiteSmoke);
            var part12 = @"      ;;;".Pastel(Color.SandyBrown) + @"                         \_\  ".Pastel(Color.WhiteSmoke);
            var part13 = @"      ';;;".Pastel(Color.SandyBrown) + @"                         |   ".Pastel(Color.SaddleBrown);
            var part14 = @"       ;".Pastel(Color.SandyBrown) + @"    |                      ;   ".Pastel(Color.SaddleBrown);
            var part15 = @"        \   \     \        |      /    ".Pastel(Color.SaddleBrown);
            var part16 = @"         \_".Pastel(Color.SaddleBrown) + @",".Pastel(Color.SandyBrown) + @" \    /        \     |\    ".Pastel(Color.SaddleBrown);
            var part17 = @"           |".Pastel(Color.SaddleBrown) + @"';".Pastel(Color.SandyBrown) + @"|  |".Pastel(Color.SaddleBrown) + @",,,,,,,,".Pastel(Color.SandyBrown) + @"/ \    \ \_  ".Pastel(Color.SaddleBrown);
            var part18 = @"           |  |  |           \   /   | ".Pastel(Color.SaddleBrown);
            var part19 = @"           \  \  |           |  / \  | ".Pastel(Color.SaddleBrown);
            var part20 = @"            | || |           | |   | | ".Pastel(Color.SaddleBrown);
            var part21 = @"            | || |           | |   | | ".Pastel(Color.SaddleBrown);
            var part22 = @"            | || |           | |   | | ".Pastel(Color.SaddleBrown);
            var part23 = @"            |_||_|           |_|   |_| ".Pastel(Color.SaddleBrown);
            var part24 = @"           /".Pastel(Color.DarkSlateGray) + @"_".Pastel(Color.WhiteSmoke) + @"//".Pastel(Color.DarkSlateGray) + @"_".Pastel(Color.WhiteSmoke) + @"/           /".Pastel(Color.DarkSlateGray) + @"_".Pastel(Color.WhiteSmoke) + @"/   /".Pastel(Color.DarkSlateGray) + @"_".Pastel(Color.WhiteSmoke) + @"/  ".Pastel(Color.DarkSlateGray);

            return $"{part1}\n{part2}\n{part3}\n{part4}\n{part5}\n{part6}\n{part7}\n{part8}\n{part9}\n{part10}\n{part11}\n{part12}\n{part13}\n{part14}\n{part15}\n{part16}\n{part17}\n{part18}\n{part19}\n{part20}\n{part21}\n{part22}\n{part23}\n{part24}";
        }

        static string Seagull()
        {
            // Seagull from https://ascii.co.uk/art/seagull 
            var part1 = @"        .:".Pastel(Color.DarkSlateGray) + "~~--__                __--~~".Pastel(Color.WhiteSmoke) + ":.".Pastel(Color.DarkSlateGray);
            var part2 = @"      ,:;".Pastel(Color.DarkSlateGray) + "'~'-,__~~--..,---..--~~__,-`~`".Pastel(Color.WhiteSmoke) + "::.".Pastel(Color.DarkSlateGray);
            var part3 = @"    ,:;'".Pastel(Color.SlateGray) + "        ''-,_".Pastel(Color.WhiteSmoke) + " (".Pastel(Color.DarkSlateGray) + "o".Pastel(Color.ForestGreen) + " o".Pastel(Color.ForestGreen) + ")".Pastel(Color.DarkSlateGray) + "_,-``".Pastel(Color.WhiteSmoke) + "        `::.".Pastel(Color.SlateGray);
            var part4 = @"  ,;'".Pastel(Color.LightSlateGray) + @"                \".Pastel(Color.WhiteSmoke) + @" `\)".Pastel(Color.Orange) + @"/".Pastel(Color.WhiteSmoke) + "                `:.".Pastel(Color.LightSlateGray);
            var part5 = @" '".Pastel(Color.LightSlateGray) + "                    `--'".Pastel(Color.WhiteSmoke) + "                    `".Pastel(Color.LightSlateGray);

            return $"{part1}\n{part2}\n{part3}\n{part4}\n{part5}";
        }

        static string Racoon()
        {

            var part1 = @"                    __        .".Pastel(Color.DimGray) + @"-".Pastel(Color.WhiteSmoke) + @". ".Pastel(Color.DimGray);
            var part2 = @"                .-'`".Pastel(Color.DimGray) + @" .".Pastel(Color.WhiteSmoke) + @"`'.".Pastel(Color.DimGray) + @"    /".Pastel(Color.DimGray) + @"\\".Pastel(Color.WhiteSmoke) + @"| ".Pastel(Color.DimGray);
            var part3 = @"        _(\-/)_'".Pastel(Color.DimGray) + @",  .   ,".Pastel(Color.WhiteSmoke) + @" \".Pastel(Color.DimGray) + @"  /".Pastel(Color.DimGray) + @"\\".Pastel(Color.WhiteSmoke) + @"\".Pastel(Color.DimGray) + @"/ ".Pastel(Color.DimGray);
            var part4 = @"       {(#".Pastel(Color.DimGray) + @"b".Pastel(Color.DarkSlateGray) + @"^".Pastel(Color.PaleVioletRed) + @"d".Pastel(Color.DarkSlateGray) + @"#)}".Pastel(Color.DimGray) + @" .".Pastel(Color.WhiteSmoke) + @"   .".Pastel(Color.WhiteSmoke) + @"/".Pastel(Color.DimGray) + @",".Pastel(Color.WhiteSmoke) + @"  |/".Pastel(Color.DimGray) + @"\\".Pastel(Color.WhiteSmoke) + @"\/  ".Pastel(Color.DimGray);
            var part5 = @"       `-.".Pastel(Color.DimGray) + @"(".Pastel(Color.WhiteSmoke) + @"-".Pastel(Color.Salmon) + @")".Pastel(Color.WhiteSmoke) + @".-`".Pastel(Color.DimGray) + @"  ,".Pastel(Color.WhiteSmoke) + @"  |".Pastel(Color.DimGray) + @"  ,".Pastel(Color.WhiteSmoke) + @" |".Pastel(Color.DimGray) + @"\".Pastel(Color.WhiteSmoke) + @".".Pastel(Color.DimGray) + @"-".Pastel(Color.WhiteSmoke) + @"`   ".Pastel(Color.DimGray);
            var part6 = @"            /~/,_/~~~\,__.-`      ".Pastel(Color.DimGray);
            var part7 = @"           ////~    // ~\\".Pastel(Color.DimGray);
            var part8 = @"         ==".Pastel(Color.DarkSlateGray) + @"`".Pastel(Color.WhiteSmoke) + @"==".Pastel(Color.DarkSlateGray) + @"`".Pastel(Color.WhiteSmoke) + @"   ==".Pastel(Color.DarkSlateGray) + @"`".Pastel(Color.WhiteSmoke) + @"   ==".Pastel(Color.DarkSlateGray) + @"`".Pastel(Color.WhiteSmoke);

            return $"{part1}\n{part2}\n{part3}\n{part4}\n{part5}\n{part6}\n{part7}\n{part8}";
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



            var animals = new List<string>() { Hippo(), Scorpion(), ShinyCharizard(), Sonic(), Deer(), Seagull(), Racoon() };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal}\n");
            }

        }
    }
}
