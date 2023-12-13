﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class OperationButtonHelpHandler : HelpHandler
    {
        public OperationButtonHelpHandler(HelpHandler helpHandler) : base(helpHandler) { }
        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }
            return helpRequest.Symbol == '+' || helpRequest.Symbol == '-' || helpRequest.Symbol == '*' || helpRequest.Symbol == '/';
        }
        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }
            return $"Это кнопка операции '{helpRequest.Symbol}'";
        }
        protected override string BuildDefaultHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }
            return $"Вы активируете операционную кнопку.";
        }
    }
}
