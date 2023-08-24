using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Parsers
{
    /// <summary>
    /// Описание объекта класса
    /// Для создания команд парсера
    /// </summary>
    public class SeleniumCommands
    {
        public string Hash { get; set; }
        public string Platform { get; set; }
        public List<BodyCommand> BodyCommands { get; set; }

    }

    /// <summary>
    /// Описание объекта класса
    /// Для создания команд парсера
    /// </summary>
    public class BodyCommand
    {
        public string Action { get; set; }
        public string Value { get; set; }
    }
    
}
