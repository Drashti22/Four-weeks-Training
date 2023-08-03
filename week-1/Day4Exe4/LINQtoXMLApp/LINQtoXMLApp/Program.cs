
using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqToXmlApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assume there is an XML document with the following structure:
            // <Books>
            //     <Book>
            //         <Title>Book Title 1</Title>
            //         <Author>Author 1</Author>
            //         <Genre>Genre 1</Genre>
            //     </Book>
            //     ...
            // </Books>
            // Write above book structure as a c# string
            string xmlString = @"<Books>
                                    <Book>
                                        <Title>Book Title 1</Title>
                                        <Author>Author 1</Author>
                                        <Genre>Fiction</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Book Title 2</Title>
                                        <Author>Author 2</Author>
                                        <Genre>Drama</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Book Title 3</Title>
                                        <Author>Author 3</Author>
                                        <Genre>Romantic</Genre>
                                    </Book>
                                </Books>";

            // Create an XDocument object from the XML string
            XDocument xmlDocument = XDocument.Parse(xmlString);
            // Write the title of all books to the console
            string targetGenre = "Fiction";
            var books = xmlDocument.Root.Elements("Book")
                            .Where(b => b.Element("Title").Value == targetGenre)
                            .Select(b => new
                            {
                                Title = b.Element("Title").Value,
                            });
            // Write the title of all books with genre "Genre 1" to the console
            foreach (var titles in books)
            {
                Console.WriteLine(titles);
            }

        }
    }
}
