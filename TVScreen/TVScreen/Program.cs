using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TVScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();
            Timer timer = new Timer();
            bool run = true;
            while (run)
            {
                Thread timerth = new Thread(timer.TimeToShutdown);

                while (television.mode == false)
                {
                    Console.Clear();
                    Console.WriteLine("The tv is turned off, you can turn it on by typing on");
                    string Uinput = Console.ReadLine().ToLower();

                    if (Uinput == "on")
                    {
                        television.TurnOn();
                        timerth.Start();
                    }
                    else
                    {
                        continue;
                    }
                }

                while (television.mode == true)
                {
                    Console.Clear();
                    if (television.GetInputName() == "TV")
                    {
                        Console.WriteLine("The TV is on \nYou're on channel {0} watcing {1}", television.GetChannelName(), television.GetChannelCurrentProgram());
                        Console.WriteLine("\nTo change channel type, change channel dr1 or the others. \nTo change input type, change input HDMI or the others \nTo see the channels and inputs to choose from type, overview ");
                        Console.WriteLine("Else use help");
                    }
                    else
                    {
                        Console.WriteLine("The TV is on \nYou're on inputType {0} portNumber {1}", television.GetInputName(), television.GetInputPortNumber());
                        Console.WriteLine("\nTo change channel type, change channel dr1 or the others. \nTo change input type, change input HDMI or the others\nTo see the channels and inputs to choose from type, overview ");
                        Console.WriteLine("Else use help");
                    }
                    string userInput = Console.ReadLine().ToLower();

                    switch (userInput)
                    {
                        case "help":
                            Console.WriteLine("Get product info -- The tv's brand, inches and serialnumber");
                            Console.WriteLine("Get Channel info  -- more about the channel");
                            Console.WriteLine("Overview -- list of channels and inputs");
                            Console.WriteLine("Off -- turns off");
                            Console.WriteLine("Press a button when you're ready");
                            Console.ReadKey();
                            break;

                        case "change channel dr1":
                            television.ChangeChannel(Television.program.DR1);
                            break;

                        case "change channel tv2":
                            television.ChangeChannel(Television.program.TV2);
                            break;

                        case "change channel tv3":
                            television.ChangeChannel(Television.program.TV3);
                            break;

                        case "change input tv":
                            television.ChangeInput(Television.inputType.TV);
                            break;

                        case "change input hdmi":
                            television.ChangeInput(Television.inputType.HDMI);
                            break;

                        case "change input line":
                            television.ChangeInput(Television.inputType.Line);
                            break;

                        case "change input usb":
                            television.ChangeInput(Television.inputType.USB);
                            break;

                        case "off":
                            television.TurnOff();
                            timerth.Abort();
                            break;

                        case "get product info":
                            Console.WriteLine("Brand: {0} \nInches: {1} \nSerialnumber: {2}", television.GetProductBrand(), television.GetProductInches(), television.GetProductSerialNumber());
                            Console.WriteLine("Press a button when you're ready");
                            Console.ReadKey();
                            break;

                        case "get channel info":
                            Console.WriteLine("Channel: {0} \nFrequency: {1} \nCurrent Program: {2} \nProgram content: {3}", television.GetChannelDesciption(), television.GetChannelFrequency(), television.GetChannelCurrentProgram(), television.GetChannelContent());
                            Console.WriteLine("Press a button when you're ready");
                            Console.ReadKey();
                            break;

                        case "overview":
                            Console.WriteLine("Channels: \nDr1 (default)\nTv2 \nTv3 \n\nInputs: \nTV (default)\nHDMI \nLine \nUSB");
                            Console.WriteLine("press a button when you're ready");
                            Console.ReadKey();
                            break;


                        default:

                            break;
                    }
                }
            }

                   


        }
    }


}
