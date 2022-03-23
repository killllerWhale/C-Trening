using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MyClass
{
    class MyStr
    {
        public StringBuilder line;
        public String n;

        public MyStr(String n)
        {
            line = new StringBuilder(n);
        }
        public int Length
        {
            get { return line.Length; }
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
            String a = line.ToString().ToLower();
            line.Clear();
            line.Append(a);
            
        }

        public void del()
        {
            String str = line.ToString() ;
            line.Clear();
            line.Append(Regex.Replace(str, "[,.:?!]", " "));
        }
       
    }
}
