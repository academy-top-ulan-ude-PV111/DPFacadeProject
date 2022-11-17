using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DPFacadeProject
{
    class TextBoxForm
    {
        public void Show()
        {
            Console.WriteLine($"Text box show");
        }
        public void InputText(string text)
        {
            Console.WriteLine($"Text box input text {text}");
        }
        public void ClearText()
        {
            Console.WriteLine($"Text box clear text");
        }
    }

    class ButtonForm
    {
        public void Show()
        {
            Console.WriteLine($"Button show");
        }
        public void Active() 
        {
            Console.WriteLine("Button is active");
        }
        public void NonActive()
        {
            Console.WriteLine("Button is deactive");
        }

        public void Press()
        {
            Console.WriteLine("Button press");
        }
    }

    class ListForm
    {
        public void Show()
        {
            Console.WriteLine($"List show");
        }
        public void AddItem(string text)
        {
            Console.WriteLine($"List box add text {text} from Text Box");
        }
    }
    internal class VisualForm
    {
        TextBoxForm textbox;
        ButtonForm button;
        ListForm list;
        public VisualForm(TextBoxForm textbox, ButtonForm button, ListForm list)
        {
            this.textbox = textbox;
            this.button = button;
            this.list = list;
        }

        public void Show()
        {
            Console.WriteLine("Form show");
            textbox.Show();
            button.Show();
            list.Show();
            button.NonActive();
        }

        public void Insert(string item)
        {
            textbox.InputText(item);
            button.Active();
            button.Press();
            list.AddItem(item);
            textbox.ClearText();
            button.NonActive();
        }
    }


}
