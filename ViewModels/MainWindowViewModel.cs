using System.Reactive;
using Laba_4avl;
using Laba_4avl.ViewModels;
using Laba_4avl.ViewModels;
using ReactiveUI;

namespace Laba_4avl.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string text;
        string prevtext;
        string commandtext;
        bool secnum = false;

        public MainWindowViewModel()
        {
            OnclickCommand = ReactiveCommand.Create<string>((str) =>
            {
                if (str != "+" && str != "-" && str != "*" && str != "/" && str != "=") 
                    Greeting = text + str;

                else if (secnum == false)
                {
                    secnum = true;
                    commandtext = str;
                    prevtext = text;
                    text = "";
                }
                else
                {
                   if (text == "") commandtext = str;
                   else 
                   {
                        try
                        {
                            Greeting = Calculator.Calc(prevtext, text, commandtext);
                        }
                        catch(RomanNumberException e)
                        {
                            Greeting = "Hello";
                            text = ""; 
                        }
                        finally
                        {
                            prevtext = "";
                            if(str == "=") secnum = false;
                            else
                            {
                                prevtext = text;
                                text = "";
                                commandtext = str;
                            }
                        }
                   }
                   
                }
            });
        }
        public string Greeting
        {
            set
            {
                this.RaiseAndSetIfChanged(ref text, value);
            }
            get
            {
                return text;
            }
        }

        public ReactiveCommand<string, Unit> OnclickCommand { get; } 

    }
    

}