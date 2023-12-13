using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var applicationHelpHandler = new ApplicationHelpHandler(null);
            var buttonHelpHandler = new ButtonHelpHandler(applicationHelpHandler);
            var intButtonHelpHandler = new IntButtonHelpHandler(buttonHelpHandler);
            var operationHelpHandler = new OperationButtonHelpHandler(buttonHelpHandler);

            Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('1')));
            Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('2')));
            Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('+')));
            Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('a')));
            Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('o')));
            Console.WriteLine(operationHelpHandler.HandleHelp(new HelpRequest('+')));
            Console.WriteLine(operationHelpHandler.HandleHelp(new HelpRequest('7')));

            Console.ReadLine();
        }
    }
}
