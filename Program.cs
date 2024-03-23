using System;
using OOPLesson002Example.Concrete;

namespace OOPLesson002Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pyramid pyramid = new Pyramid(7);
            pyramid.ConsoleWrite();
        }
    }
}