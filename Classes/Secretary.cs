using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THEUSERS;
namespace SecretarySpace
{
    class Secretary:User
    {
        

        override public Job getJob()
        {
            return Job.Scaretary;
        }
        override public string getJobString()
        {
            return "Secretary";
        }
    }
}
