using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibary
{
    public class Record
    {
        public int Account { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }

        //el constructor sin parametors establece los miembros a los valores predeterminados

        public Record() : this(0, string.Empty, string.Empty, 0M) { }

        //el constructor sobrecargado, establece los miembros a los valores de los parámetros

        public Record(int account, string firstName, string lastName, decimal balance) 
        {
            Account = account;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }                                                                                                                                      
    }
}
