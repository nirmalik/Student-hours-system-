using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THEUSERS;
namespace PROJECT_19.Classes
{
    class AssociationMember:User
    {
        override public Job getJob()
        {
            return Job.Association;
        }
    }
}
