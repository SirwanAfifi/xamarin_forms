using System;
namespace TelerikTest.Vms
{
    public class MainViewModel
    {
        public Person Person { get; set; }

        public MainViewModel()
        {
            Person = new Person();
        }
    }
}
