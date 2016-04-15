using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in code, svc and config file together.
    public class HelloService : IHelloService
    {
        public string SayHello(string Name)
        {
            return "Hello " + Name; 
        }
    }
}
