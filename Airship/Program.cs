using Airship.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Airship
{
    class Program
    {
        public static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            var applicationKey = "";
            var applicationSecret = "";
            var masterSecret = "";

            var airshipClient = new Airship(applicationKey, masterSecret);

            var newNotification = new Notification()
            {
                Alert = "Is this needed",
                Web = new WebAlert()
                {
                    Alert = "Client wrapper body",
                    Title = "Client wrapper title",
                    Image = new Image()
                    {
                        Url = "https://upload.wikimedia.org/wikipedia/commons/6/6e/Golde33443.jpg"
                    },
                    Buttons = new List<Button>()
                    {
                        new Button()
                        {
                            Label = "Button One",
                            Id ="button-one",
                            Actions = new Actions(){
                                Open = new OpenUrlAction() {
                                    Content = "https://www.google.com",
                                    Type = "url"
                                }
                            }
                        },
                        new Button()
                        {
                            Label = "Button Two",
                            Id ="button-two",
                            Actions = new Actions(){
                                Open = new OpenUrlAction() {
                                    Content = "https://www.yahoo.com",
                                    Type = "url"
                                }
                            }
                        }
                    }
                },
                Actions = new Actions()
                {
                    Open = new OpenUrlAction { Type = "url", Content = "https://www.google.com" }
                }
            };

            var test = await airshipClient.PushNotification("user-id-55", newNotification);

            Console.WriteLine("Program.cs, test: ", test);
        }


    }
}
