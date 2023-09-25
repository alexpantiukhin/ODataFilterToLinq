﻿using System.Linq.Expressions;

namespace ODataStringToExpression
{
    internal static class Extensions
    {
        internal static bool IsBinaryExpression(this string @operator)
        {
            switch (@operator)
            {
                case "gt":
                case "eq":
                case "lt":
                case "ge":
                case "le":
                case "ne":
                    return true;
                default: return false;
            }
        }

        internal static bool IsMethodCallExpression(this string @operator) => @operator == "in";
    }
}
