using System;
using System.ComponentModel;

namespace AdoSQLite.DAL
{
    internal class User
    {
        [DisplayName("ID")] // так будет оторажаться в талице
        [Browsable(false)] // скроет значение ID в таблице
        public int id { get; internal set; }
        [DisplayName("User Name")]
        public string UserName { get; internal set; }
        [DisplayName("Name")]
        public string Name { get; internal set; }
        [DisplayName("Date created")]
        public DateTime Date { get; internal set; }
    }
}