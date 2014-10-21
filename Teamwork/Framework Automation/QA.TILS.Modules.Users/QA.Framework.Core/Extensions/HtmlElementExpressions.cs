namespace QA.Framework.Core.Extensions
{
    using System;
    using System.Linq;

    public static class HtmlElementExpressions
    {
        public static string ToIdEndsWithExpression(this string expression)
        {
            return string.Concat("id=?", expression);
        }

        public static string ToIdContainsExpression(this string expression)
        {
            return string.Concat("id=~", expression);
        }

        public static string ToForEndsWithExpression(this string expression)
        {
            return string.Concat("for=?", expression);
        }

        public static string ToNameContainsExpression(this string expression)
        {
            return string.Concat("name=~", expression);
        }

        public static string ToNameEndsWithExpression(this string expression)
        {
            return string.Concat("name=?", expression);
        }

        public static string ToClassContainsExpression(this string expression)
        {
            return string.Concat("class=~", expression);
        }

        public static string ToIsClassExpression(this string expression)
        {
            return string.Concat("class=", expression);
        }

        public static string ToClassEndsWithExpression(this string expression)
        {
            return string.Concat("class=?", expression);
        }

        public static string ToInnerTextContainsExpression(this string expression)
        {
            return string.Concat("InnerText=~", expression);
        }

        public static string ToLinkPointsToExpression(this string expression)
        {
            return string.Concat("href=", expression);
        }

        public static string ToLinkContainsExpression(this string expression)
        {
            return string.Concat("href=~", expression);
        }
    }
}
