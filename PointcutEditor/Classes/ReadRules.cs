using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;

namespace PointcutEditor
{
    class ReadRules
    {
        public static string fileName = "C:\\Java\\aspect\\rules\\aobpm_goal.xml";

        public static List<Aspect> readAspects()
        {
            string xpath = "//aspect";

            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();

            // Compile a standard XPath expression
            XPathExpression expr;
            expr = nav.Compile(xpath);
            XPathNodeIterator iterator = nav.Select(expr);

            // Iterate on the node set
            List<Aspect> aspects = new List<Aspect>();
            try
            {
                while (iterator.MoveNext())
                {
                    XPathNavigator nav2 = iterator.Current.Clone();
                    Aspect currentAspect = new Aspect(nav2.GetAttribute("name", ""));
                    currentAspect.Advices = readAdvices("//aspect[@name='" + currentAspect.Name + "']//advice", currentAspect);
                    aspects.Add(currentAspect);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return aspects;
        }

        private static List<Advice> readAdvices(string xpath, Aspect aspect)
        {
            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();

            // Compile a standard XPath expression
            XPathExpression expr;
            expr = nav.Compile(xpath);
            XPathNodeIterator iterator = nav.Select(expr);

            List<Advice> result = new List<Advice>();
            // Iterate on the node set
            try
            {
                while (iterator.MoveNext())
                {
                    XPathNavigator nav2 = iterator.Current.Clone();
                    Advice currentAdvice = new Advice(
                        nav2.GetAttribute("name", ""),
                        nav2.GetAttribute("process", ""),
                        nav2.GetAttribute("goal", "")
                        );
                    currentAdvice.Pointcuts = readPointcuts(
                        "//aspect[@name='" + aspect.Name + "']//advice[@name='" + currentAdvice.Name + "']//pointcut", 
                        currentAdvice);
                    result.Add(currentAdvice);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        private static List<Pointcut> readPointcuts(string xpath, Advice advice)
        {
            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();

            // Compile a standard XPath expression
            XPathExpression expr;
            expr = nav.Compile(xpath);
            XPathNodeIterator iterator = nav.Select(expr);

            List<Pointcut> result = new List<Pointcut>();
            // Iterate on the node set
            try
            {
                while (iterator.MoveNext())
                {
                    XPathNavigator nav2 = iterator.Current.Clone();
                    Pointcut currentPointcut = new Pointcut(
                        nav2.GetAttribute("process", ""),
                        nav2.GetAttribute("task", ""),
                        nav2.GetAttribute("condition", "")
                        );
                    result.Add(currentPointcut);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

    }
}