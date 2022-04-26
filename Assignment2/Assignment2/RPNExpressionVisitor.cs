using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Assignment2
{
    /// <summary>
    /// RPN Expression Visitor Class
    /// </summary>
    public class RPNExpressionVisitor : ExpressionVisitor
    {
        /// <summary>
        /// Visit Method
        /// </summary>
        /// <param name="node">A Node</param>
        /// <returns></returns>
        public override Expression Visit(Expression node)
        {
            if (node == null)
            {
                return null;
            }

            switch (node.NodeType)
            {
                case ExpressionType.Add:
                    return this.VisitBinary((BinaryExpression)node);
                case ExpressionType.Subtract:
                    return this.VisitBinary((BinaryExpression)node);
                case ExpressionType.Multiply:
                    return this.VisitBinary((BinaryExpression)node);
                case ExpressionType.Divide:
                    return this.VisitBinary((BinaryExpression)node);
                case ExpressionType.Modulo:
                    return this.VisitBinary((BinaryExpression)node);

                // add the default case so that we can safely
                // ignore any expressions that do not have the above expression types
                default:
                    // always call base.methodname, in our case we are calling base.Visit(node);
                    // otherwise we will enter Infinite Recursion(Loop) 
                    return base.Visit(node);
            }
        }

        /// <summary>
        /// Visit Binary Node
        /// </summary>
        /// <param name="node">A Node</param>
        /// <returns></returns>
        protected override Expression VisitBinary(BinaryExpression node)
        {
            // visit the right side of the binary expression
            var right = this.Visit(node.Right);

            // visit the left side of the binary expression
            var left = this.Visit(node.Left);

            if (left == null || right == null)
            {
                throw new InvalidOperationException();
            }

            switch (node.NodeType)
            {
                case ExpressionType.Add:
                    return Expression.MakeBinary(ExpressionType.Add, left, right);
                case ExpressionType.Subtract:
                    return Expression.MakeBinary(ExpressionType.Subtract, left, right);
                case ExpressionType.Multiply:
                    return Expression.MakeBinary(ExpressionType.Multiply, left, right);
                case ExpressionType.Divide:
                    return Expression.MakeBinary(ExpressionType.Divide, left, right);
                case ExpressionType.Power:
                    return Expression.MakeBinary(ExpressionType.Power, left, right);

                default:
                    return base.VisitBinary(node);
            }
        }

        /// <summary>
        /// Visit Constant
        /// </summary>
        /// <param name="node">A node</param>
        /// <returns></returns>
        protected override Expression VisitConstant(ConstantExpression node)
        {
            return Expression.Constant(node);
        }
    }
}
