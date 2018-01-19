using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TVScreen.Channels;
using TVScreen.Inputs;

namespace TVScreen
{
    class Television
    {
        // setting dr1 to default channel
        Channel channel = new Dr1();

        // setting tv to default input
        Input input = new TV();
        
        ProductDescription product = new ProductDescription();

        public bool mode = false;

        public void TurnOn()
        {
            mode = true;
        }

        public void TurnOff()
        {
            mode = false;
            
        }

        public bool GetMode()
        {
            return mode;
        }

        
        public void ChangeChannel(program kanal)
        {
            if(kanal == program.DR1)
            {
                channel = new Dr1();
            }
            else if(kanal == program.TV2)
            {
                channel = new Tv2();
            }
            else if(kanal == program.TV3)
            {
                channel = new Tv3();
            }
            else
            {
                throw new Exception("Something went wrong, ikke gyldig kanal");
            }

        }

        public void ChangeInput(inputType type)
        {
            if(type == inputType.TV)
            {
                input = new TV();
            }
            else if(type == inputType.HDMI)
            {
                input = new HDMI();
            }
            else if(type == inputType.Line)
            {
                input = new Line();
            }
            else if(type == inputType.USB)
            {
                input = new USB();
            }
            else
            {
                throw new Exception("Invalid input type");
            }
        }

        //Get variables from ProductDescription
        public string GetProductBrand()
        {
            return product.GetBrand();
        }

        public int GetProductInches()
        {
            return product.GetInches();
        }

        public string GetProductSerialNumber()
        {
            return product.GetSerialNumber();
        }

        // Channels variabler
        public string GetChannelName()
        {
            return channel.GetName();
        }

        public string GetChannelDesciption()
        {
            return channel.GetDescriptoin();
        }

        public string GetChannelFrequency()
        {
            return channel.GetFrequency();
        }

        public string GetChannelContent()
        {
            return channel.ChannelContent();
        }

        public string GetChannelCurrentProgram()
        {
            return channel.CurrentProgram();
        }

        //InputType variabler
        public string GetInputName()
        {
            return input.GetName();
        }

        public int GetInputPortNumber()
        {
            return input.GetPortNumber();
        }


        
        public enum program
        {
            DR1,
            TV2,
            TV3
        }

        public enum inputType
        {
            TV,
            HDMI,
            Line,
            USB
        }


    }
}
