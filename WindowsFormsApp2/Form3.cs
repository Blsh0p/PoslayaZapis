using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.Entity;
namespace WindowsFormsApp2
{
    public partial class Perevod : Form
    {
        private bool isTranslated = false;
        public Perevod()
        {
            InitializeComponent();
            Trans.Click += Trans_Click;
            Save.Click += SaveButton_Click;

            Save.Enabled = false;
        }

        private void Trans_Click(object sender, EventArgs e)
        {
            string infixExp = Infix.Text;

            
            if ((Regex.IsMatch(infixExp, @"[\+\-\*\/\^\(\)]")) && IsOperand(infixExp))
            {
                string polishNotation = PolNot(infixExp);
                Polsk.Text = polishNotation;
                isTranslated = true;
                Save.Enabled = true;
            }
            else
            {
                MessageBox.Show("Введите математическое выражение для перевода.", "Ошибка");
            }
        }
        private bool IsOperand(string input)
        {
            char firstChar = input[0];
            char lastChar = input[input.Length - 1];
            return (char.IsLetterOrDigit(firstChar) || firstChar == '(') && (char.IsLetterOrDigit(lastChar) || lastChar == ')');
        }

        public static int Prior(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        public string PolNot(string infix)
        {
            Stack<char> operators = new Stack<char>();
            List<char> output = new List<char>();

            for (int i = infix.Length - 1; i >= 0; i--)
            {
                char currentChar = infix[i];

                if (char.IsLetterOrDigit(currentChar))
                {
                    output.Add(currentChar);
                }
                else if (currentChar == ')')
                {
                    operators.Push(currentChar);
                }
                else if (currentChar == '(')
                {
                    while (operators.Count > 0 && operators.Peek() != ')')
                    {
                        output.Add(operators.Pop());
                    }
                    operators.Pop(); 
                }
                else
                {
                    while (operators.Count > 0 && Prior(operators.Peek()) > Prior(currentChar))
                    {
                        output.Add(operators.Pop());
                    }
                    operators.Push(currentChar);
                }
            }

            while (operators.Count > 0)
            {
                output.Add(operators.Pop());
            }

            output.Reverse();
            return new string(output.ToArray());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isTranslated)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы|*.txt";
                saveFileDialog.Title = "Сохранить переведенное выражение";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    File.WriteAllText(saveFileDialog.FileName, Polsk.Text);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            Авторизация LoginForm = new Авторизация();        
            LoginForm.Show();
            this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

