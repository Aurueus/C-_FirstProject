using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Nine
{
    public class Document : IReadable, IWritable
    {
        private string Text;
        public void Read()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                Console.WriteLine("There is nothing to read!!!");
            }
            else
            {
                Console.WriteLine(Text);
            }
        }

        public void Write(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Text shouldn't be null or white space");
            }
            else
            {
                Text += text;
            }
        }
    }
}