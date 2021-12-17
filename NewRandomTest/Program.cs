using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;


namespace NewRandomTest
{
    class Program
    {
        private static string Token = "";
        private static TelegramBotClient Client;
        
        
        static void Main(string[] args)
        {
            
            Client = new TelegramBotClient(Token);
            Client.StartReceiving();
            Client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            Client.StopReceiving();

            Console.WriteLine("Hello World!");

            1234241412




        }
        
        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            
            var msg = e.Message;    
            if (msg.Text != null)
            {
                switch (msg.Text)
                {
                    case "Привет":
                        await Client.SendTextMessageAsync(msg.Chat.Id, text: "Приветю Выбери команду:", replyMarkup: GetButtons());
                        break;
                    case "биток":
                        await Client.SendTextMessageAsync(msg.Chat.Id, text:"Bitcoin: " + BTCParser.Btc(), replyMarkup: GetButtons());
                        break;
                    case "Биток":
                        await Client.SendTextMessageAsync(msg.Chat.Id, text:"Bitcoin: " + BTCParser.Btc(), replyMarkup: GetButtons());
                        break;
                    case "Курс":
                        await Client.SendTextMessageAsync(msg.Chat.Id, text:"Bitcoin: " + BTCParser.Btc() + "\nXRP: " + XRPParser.Xrp() +"\nETH: " + ETHParser.Eth(), replyMarkup: GetButtons());
                        break;
                    case "курс":
                        await Client.SendTextMessageAsync(msg.Chat.Id, text:"Привет! Выбери!", replyMarkup: GetButtons());
                        break;
                    case "Погода":
                        await Client.SendTextMessageAsync(msg.Chat.Id, text:"Москва: " + WeatherParser.Weather() + " грудусов", replyMarkup: GetButtons());
                        break;
                    case "погода":
                        await Client.SendTextMessageAsync(msg.Chat.Id, text:"Москва: " + WeatherParser.Weather() + " грудусов", replyMarkup: GetButtons());
                        break;

                    default:
                        await Client.SendTextMessageAsync(msg.Chat.Id, text: "Выбери команду", replyMarkup: GetButtons());
                        break;
                }
                
                //await Client.SendTextMessageAsync(chatId: msg.Chat.Id, text:"og");
                //await Client.SendStickerAsync(chatId: msg.Chat.Id, sticker: "https://github.com/TelegramBots/book/raw/master/src/docs/sticker-dali.webp", replyToMessageId: msg.MessageId);
                
            }
        }

        private static IReplyMarkup GetButtons()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>
                    {
                        new KeyboardButton {Text = "Биток"},new  KeyboardButton {Text = "Погода"},
                        new KeyboardButton {Text = "..."},new KeyboardButton {Text = "Курс"}
                    }
                }

            };
        }
    }
}
