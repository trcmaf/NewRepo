using System;
using System.IO;

namespace praktika_06
{
  class Person
  {
    private string name;
    private string surname;
    private System.DateTime birth;
    Person(string name, string surname, DateTime birth)
    {

    }
    Person()
    {
      name = "a";
      surname = "b";
      birth = DateTime.MinValue;
    }
    public string Name
    {
        get 
        {
            return name;
        }
        set { }
    }
    public string Surname
    {
        get
        {
            return surname;
        }
        set
        {

        }
    }
    public DateTime Birth
    {
        get
        {
            return birth;
        }
        set
        {

        }
    }
    public int Year////////////////////////////////////////////
    {
        get { }
        set { }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      
    }
  }
}
