// namespace consoleNet
// {
//     public class blackJackDebug
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Welcome to BlackJack!");
//             int card1 = getRandomCard();
//             int card2 = getRandomCard();
//             Console.WriteLine("Hand One: " + card1 + "  |  Hand Two: " + card2);
//             int hand = card1 + card2;
//             Console.WriteLine("Hand: " + hand);
//             string message = getMessage(hand);
//             while (message == "Continue")
//             {
//                 hand += getRandomCard();
//                 message = getMessage(hand);
//                 Console.WriteLine(hand +"  |  "+message);
//             }
//         }
//         public static string getMessage(int hand)
//         {
//             if (hand == 21) return "BlackJack";
//             else{
//                 string message =  hand > 21? "Game Over" : "Continue"; //sintaxis de condicional ternario
//                 return message;
//             }
//         }
//         public static int getRandomCard()
//         {
//             Random ran = new Random();
//             int randInt = ran.Next(1, 13);
//             return randInt;
//         }
//     }
// }