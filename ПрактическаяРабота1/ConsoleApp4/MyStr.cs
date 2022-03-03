using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MyClass
{
    class MyStr
    {
        private StringBuilder line;
        private int n;

        public int Length
        {
            get { return line.Length; }
        }
        public MyStr(int n)
        {
            line = new StringBuilder(n);
        }

        public String Line
        {
            get { return line.ToString(); }
            set 
            {
                line.Clear();
                line.Append(value);
            }
        }

        public void Prop() 
        {
            line.ToString().ToLower();
        }

        public void del()
        {
            String str = line.ToString() ;
            line.Clear();
            line.Append(Regex.Replace(str, "[,.:?!]", " "));
        }
       
    }
}
