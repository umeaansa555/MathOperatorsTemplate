/* 
 * author: Mr. T.
 * purpose: template created to demonstrate math operations
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathOperatorsTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void runButton_Click(object sender, EventArgs e)
        {
            // 1. Declare a string variable, put your name in it, display it
            string myName = "a";
            outputLabel.Text = myName;

            // 2. Declare an integer variable, put your age in it, display it
            int myAge = 99;
            outputLabel.Text +=  "\n" + myAge;

            // 3. Declare a double variable, put a decimal number, display it
            double price = 16.09;
            outputLabel.Text += "\n" + price;

            /// 4. Combine a text with a variable to display: 
            ///   "Hello" followed by your name (e.g. Hello Mr. T)
            outputLabel.Text += "\n" + "hello " + myName;
            outputLabel.Text += "\n Hello {myName}";

            /// 5. Simple arithmetic is done by using the +, -, * and /, 
            /// (plus, minus, times and divide). Results of mathematical
            /// expressions should be stored in a variable. 
            /// 
            /// Uncomment the code below to see what the result is. Notice 
            /// that the output does not show the values of x and y, 
            /// but instead the words x and y. 
            /// 
            /// Change the code to subtract y from x, and output the following:
            /// 
            /// 6 - 4 = 2

            int x = 6;
            int y = 4;
            int answer = x - y;

            outputLabel.Text += $"\n\n{x} - {y} = {answer} \n";


            /// 6. Create a program that calculates how much money an 
            /// employee has made based on their pay rate and the 
            /// number of hours worked.
            /// 
            /// - Create a variable to hold the rate of pay, (payRate), 
            ///   and set it to 15.25
            /// - Create a variable to hold the hours worked, (hoursWorked), 
            ///   and set it to 8
            /// - Create a variable to hold the total pay, (totalPay)
            /// - Calculate the total pay
            /// - Display the results to the screen as per the output below.
            /// 
            /// Rate of Pay: 15.25
            /// Hours Worked: 8
            /// Total Pay: 122
            double payRate = 15.25;
            double hoursWorked = 8;
            double totalPay = payRate * hoursWorked;

            outputLabel.Text += $"\n Rate of Pay: {payRate}" +
                $"\n Hours Worked: {hoursWorked}" +
                $"\n Total Pay: {totalPay}";


            /// 7. Create a program which calculates the tax amount for a
            /// meal at a restaurant.
            /// 
            /// - Create a variable to hold the bill amount, (billAmount), 
            ///   of 22.50
            /// - Create a variable to hold the tax rate, (taxRate), of 0.13
            /// - Create a variable to hold the tax amount, (taxAmount)
            /// - Calculate the tax, (billAmount * taxRate) and store it 
            ///   in taxAmount 
            ///   
            /// Bill Amount: 22.5
            /// 13% Tax: 2.925             

            double billAmount = 22.50;
            double taxRate = 0.13;
            double taxAmount = billAmount * taxRate;
            outputLabel.Text += $"\n\n BillAmount: {billAmount.ToString("$0.00")}"; //manual method
            outputLabel.Text += $"\n Tax: {taxRate.ToString("C")}"; //shortcut method. C means currency
            outputLabel.Text += $"\n {taxAmount}";


            // 8. Increment your age variable by 1 using ++ and display it
            myAge++;
            outputLabel.Text += $"\n{myAge}"; 

            // 9. Decrement your age variable by 1 using -- and display it          


        }
    }
}
