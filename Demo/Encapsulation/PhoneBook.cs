using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attributes
        int[] Numbers;
        string[] Names;
        public int Size { get; set; }
        #endregion

        #region Property
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < Names.Length; i++)
                    if (Names[i] == name)
                        return Numbers[i];
                return -1;
            }
            set
            {
                for (int i = 0; i < Names.Length; i++)
                    if (Names[i] == name)
                    {
                        Numbers[i] = value;
                        Console.WriteLine($"New Number of {name} is {value}");
                        break;
                    }
            }
        }

        public string this[int Index]
        {
            get
            {
                return $"Name is {Names[Index]} and Number is {Numbers[Index]}";
            }
        }
        #endregion
        #region Constractors
        public PhoneBook(int size)
        {
            Numbers = new int[size];
            Names = new string[size];
            Size = size;
        }
        #endregion

        #region Methods
        public void AddPerson(int Position, int Number, string Name)
        {
            if (Numbers is not null && Names is not null)
            {
                Numbers[Position] = Number;
                Names[Position] = Name;
            }
        }
        public int GetNumber(string name)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == name)
                {
                    return Numbers[i];
                }
            }
            return -1;
        }

        public void SetNumber(string name, int newNumber)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == name)
                {
                    Numbers[i] = newNumber;
                    Console.WriteLine($"New Number of {name} is {newNumber}");
                    break;
                }
            }
        }
        #endregion
    }
}
