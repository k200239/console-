using System;
//筆記
//字串 string  "" 雙引號內
// 字元 char '' 引號內 only for 單一文字 
// 整數 int
//浮點數 double
//布林直 bool true or false 

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string playerName;
                string languageChoice;

                Console.Write("Choose your language (en/zh): / 選擇你的語言 (en/zh): ");
                languageChoice = Console.ReadLine().ToLower();




                string setnameintro = languageChoice == "zh" ? "你好：" : "Hello stranger: ";
                string setnameintro2 = languageChoice == "zh" ? "請問您叫做什麼名字?" : "What's your name? ";
                string hithere =  languageChoice == "zh" ? "" : "Hi there ";
                string hitherezh = languageChoice == "zh" ? "，你好" : "";         
                string enterGuessMessage = languageChoice == "zh" ? "請猜：" : "Enter your guess: ";
                string tooLowMessage = languageChoice == "zh" ? "太低了！再試一次。" : "Too low, try it higher.";
                string tooHighMessage = languageChoice == "zh" ? "太高了！再試一次。" : "too high, try it lower.";
                string congratsMessage = languageChoice == "zh" ? "恭喜你，猜中了！你一共猜了 " : "Congratulations, you've got it！It took you ";
                string validNumberMessage = languageChoice == "zh" ? "請輸入一個有效的數字。" : "only number.";
                string gameOverMessage = languageChoice == "zh" ? "測試結束。" : "Test over, thanks a lot ";
                string gameovermessage2 = languageChoice == "zh" ? "辛苦了~" : "";

                Console.WriteLine(setnameintro);
                Console.WriteLine(setnameintro2);
                playerName = Console.ReadLine();

                Console.WriteLine($"{hithere}{playerName}{hitherezh}！");



                Random random = new Random();
                int numberToGuess = random.Next(1, 100);
                int userGuess = 0;
                int numberOfGuesses = 0;
                string caption = languageChoice == "zh" ? "這只是個簡單的測試小程式遊戲" : "this is a test program";
                string caption2 = languageChoice == "zh" ? "" : "that i try to make a simple interact game";
                string caption3 = languageChoice == "zh" ? "我會從1到100之間挑一個數字。" : "A number is chosen between 1 to 100(including 1 and 100).";
                string caption4 = languageChoice == "zh" ? "再麻煩你幫我猜一下是哪個數字" : "All you have to do is to guess it";
                Console.WriteLine(caption);
                Console.WriteLine(caption2);
                Console.WriteLine(caption3);
                Console.WriteLine(caption4);


                while (userGuess != numberToGuess)
                {
                    Console.Write(enterGuessMessage);
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out userGuess))
                    {
                        numberOfGuesses++;
                        if (userGuess < numberToGuess)
                        {
                            Console.WriteLine(tooLowMessage);
                        }
                        else if (userGuess > numberToGuess)
                        {
                            Console.WriteLine(tooHighMessage);
                        }
                        else
                        {
                            Console.WriteLine($"{congratsMessage}{numberOfGuesses}{(languageChoice == "zh" ? "回。" :" guesses.")}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine(validNumberMessage);
                    }
                }

                Console.WriteLine($"{gameOverMessage}{playerName}{gameovermessage2}!");
            }
        }
    }
}
