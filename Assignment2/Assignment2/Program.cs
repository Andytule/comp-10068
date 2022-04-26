using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Assignment2
{
    public class Program
    {
        /// <summary>
        /// Main method with Expression tree and user input
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var example = "15 7 1 1 + - / 3 * 2 1 1 + + -";

            bool valid = true;
            Stack<Expression> myExpr = new Stack<Expression>();

            Expression result;

            do
            {
                myExpr.Clear();
                Console.WriteLine("Enter an RPN Math Expression: ");

                string userInput = Console.ReadLine();
                string[] rpnList = userInput.Split(' ');

                foreach (var item in rpnList)
                {
                    double myNum;
                    if (double.TryParse(item, out myNum))
                    {
                        myExpr.Push(Expression.Constant(myNum));
                    }
                    else if (myExpr.Count >= 2)
                    {
                        Expression b = myExpr.Pop();
                        Expression a = myExpr.Pop();
                        if ((item == "+"))
                        {
                            myExpr.Push(Expression.MakeBinary(ExpressionType.Add, a, b));
                        }
                        else if ((item == "-"))
                        {
                            myExpr.Push(Expression.MakeBinary(ExpressionType.Subtract, a, b));
                        }
                        else if ((item == "*"))
                        {
                            myExpr.Push(Expression.MakeBinary(ExpressionType.Multiply, a, b));
                        }
                        else if ((item == "/"))
                        {
                            myExpr.Push(Expression.MakeBinary(ExpressionType.Divide, a, b));
                        }
                        else if ((item == "^"))
                        {
                            myExpr.Push(Expression.MakeBinary(ExpressionType.Power, a, b));
                        }
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }
            } while (!valid);

            result = myExpr.Pop();

            var lambda = Expression.Lambda(result);

            Console.WriteLine("Result is: " + lambda.Compile().DynamicInvoke());
        }

        public double calculate(string userInput)
        {

            Stack<Expression> myExpr = new Stack<Expression>();

            string[] rpnList = userInput.Split(' ');

            foreach (var item in rpnList)
            {
                double myNum;
                if (double.TryParse(item, out myNum))
                {
                    myExpr.Push(Expression.Constant(myNum));
                }
                else if (myExpr.Count >= 2)
                {
                    Expression b = myExpr.Pop();
                    Expression a = myExpr.Pop();
                    if ((item == "+"))
                    {
                        myExpr.Push(Expression.MakeBinary(ExpressionType.Add, a, b));
                    }
                    else if ((item == "-"))
                    {
                        myExpr.Push(Expression.MakeBinary(ExpressionType.Subtract, a, b));
                    }
                    else if ((item == "*"))
                    {
                        myExpr.Push(Expression.MakeBinary(ExpressionType.Multiply, a, b));
                    }
                    else if ((item == "/"))
                    {
                        myExpr.Push(Expression.MakeBinary(ExpressionType.Divide, a, b));
                    }
                    else if ((item == "^"))
                    {
                        myExpr.Push(Expression.MakeBinary(ExpressionType.Power, a, b));
                    }
                }
                else
                {
                    break;
                }
            }

            Expression result = myExpr.Pop();

            var lambda = Expression.Lambda(result);

            return (double)lambda.Compile().DynamicInvoke();
        }
    }
}
