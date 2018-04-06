using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsToArabicConversion
{
    class NumberConversion
    {
        public static string ConvertFromArabicToRoman(int arabicNumerals)
        {
            //Checking boolean condition, if it is true then return empty.
            if (arabicNumerals < 1)
               return String.Empty;
        

            //Checking the boolean condition if it is true, then throw an exception.
            if (arabicNumerals > 3999)
                throw new ArgumentException("Integer number Should be less than 3999");

            //Declare a constant field.
            const string ROMAN_SYMBOLS = "IVXLCDM";

            //Declare a variable.
            int orderOfNumber = (int)Math.Truncate(Math.Log10(arabicNumerals));

            int currentNumber = arabicNumerals;

            // Declare a string builder variable
            var sbRomanNumber = new StringBuilder();

            //Declare the i variable and initialize with the value.
            //Checking the condition if is true then start decrementing.
            for (int i = orderOfNumber; i >= 0; i--)
            {
                //
                int j = i * 2;
                int devisor = GetCurrentDevisor(i);
                int valueOfCurrentPower = (int)Math.Truncate((double)(currentNumber / devisor));

                //Using a switch statement to compare the value of the variable and the value of
                //each of the case statements. If the value are match then the statement that follow the case
                //statement are executed.
                switch (valueOfCurrentPower)
                {
                    case 1:
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j]);
                        break;
                    case 2:
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j], 2);
                        break;
                    case 3:
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j], 3);
                        break;
                    case 4:
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j]);
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j + 1]);
                        break;
                    case 5:
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j + 1]);
                        break;
                    case 6:
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j + 1]);
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j]);
                        break;
                    case 7:
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j + 1]);
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j], 2);
                        break;
                    case 8:
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j + 1]);
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j], 3);
                        break;
                    case 9:
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j]);
                        sbRomanNumber.Append(ROMAN_SYMBOLS[j + 2]);
                        break;
                        
                }
                currentNumber -= valueOfCurrentPower * devisor;
            }
            return sbRomanNumber.ToString();
        }

        
        public static int ConvertFromRomanToArabic(string RomanNumerals)
        {
           
           
            //if (RomanNumerals == null)
               // throw new ArgumentNullException("RomanNumerals");
            
            //Declare a varible and initialize with 0.
            int resultInteger = 0;

            RomanNumerals = RomanNumerals.ToUpperInvariant();

            // //Declare the i variable and initialize with the value.
            //Checking the condition if is true then start incrementing.
            for (int i = 0; i < RomanNumerals.Length; i++)
            {
                // //Using a switch statement to compare the value of the variable and the value of
                //each of the case statements. If the value are match then the statement that follow the case
                //statement are executed.
                switch (RomanNumerals[i])
                {
                    case 'I':
                        if (i < RomanNumerals.Length - 1
                            && RomanNumerals[i + 1] != 'I')
                            resultInteger--;
                        else resultInteger++;

                        //If statement to check if a condition is true, then display an error message.
                        if (RomanNumerals.Contains("IIII"))
                            throw new ArgumentException("Roman numerals 'I' cannot be enter four times.");

                        break;
                    case 'V':
                        resultInteger += 5;

                        //If statement to check if a condition is true, then display an error message.
                        if (RomanNumerals.Contains("VV"))
                            throw new ArgumentException("Roman numeral 'V' cannot be repeated");
                        break;
                    case 'X':
                        if (i < RomanNumerals.Length - 1
                            && (RomanNumerals[i + 1] == 'L'
                            || RomanNumerals[i + 1] == 'C'))
                            resultInteger -= 10;
                        else resultInteger += 10;

                        //If statement to check if a condition is true, then display an error message.
                        if (RomanNumerals.Contains("XXXX"))
                            throw new ArgumentException("Roman numerals 'X' cannot be enter four times");
                        break;

                    case 'L':
                        resultInteger += 50;

                        //If statement to check if a condition is true, then display an error message.
                        if (RomanNumerals.Contains("LL"))
                            throw new ArgumentException("Roman numeral 'L' cannot be repeated");
                        break;

                    case 'C':
                        if (i < RomanNumerals.Length - 1
                            && (RomanNumerals[i + 1] == 'D'
                            || RomanNumerals[i + 1] == 'M'))
                            resultInteger -= 100;
                        else
                            resultInteger += 100;

                        //If statement to check if a condition is true, then display an error message.
                        if (RomanNumerals.Contains("CCCC"))
                            throw new ArgumentException("Roman numerals cannot be enter four times.");
                        break;

                    case 'D':
                        resultInteger += 500;

                        //If statement to check if a condition is true, then display an error message.
                        if (RomanNumerals.Contains("DD"))
                            throw new ArgumentException("Roman numeral 'D' cannot be repeated");
                        break;

                    case 'M':
                        resultInteger += 1000;
                        break;

                        //Display the default message, if the expression does'nt match.
                    default:
                        throw new ArgumentException("Wrong Roman number format.");

                }
            }
            return resultInteger;
        }
        
        private static int GetCurrentDevisor(int i)
        {
            return (int)Math.Pow(10, i);
        }
        
    }
    
    }
