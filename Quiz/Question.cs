using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public string TheQ { get; set; }
        public string TheAns { get; set; }
        public int Solution { get; set; }

        public Question(string theQ, string theA, int sol)
        {
            TheQ = theQ;
            TheAns = theA;
            Solution = sol;
        }

        public override string ToString()
        {
            return string.Format(@"
╦ ╦┬─┐┬┌┬┐┌─┐  ┌┬┐┬ ┬┌─┐  ┌┐┌┬ ┬┌┬┐┌┐ ┌─┐┬─┐  ┌─┐┌─┐  
║║║├┬┘│ │ ├┤    │ ├─┤├┤   ││││ ││││├┴┐├┤ ├┬┘  │ │├┤   
╚╩╝┴└─┴ ┴ └─┘   ┴ ┴ ┴└─┘  ┘└┘└─┘┴ ┴└─┘└─┘┴└─  └─┘└    
┌┬┐┬ ┬┌─┐  ┌─┐┌─┐┬─┐┬─┐┌─┐┌─┐┌┬┐  ┌─┐┌┐┌┌─┐┬ ┬┌─┐┬─┐  
 │ ├─┤├┤   │  │ │├┬┘├┬┘├┤ │   │   ├─┤│││└─┐│││├┤ ├┬┘  
 ┴ ┴ ┴└─┘  └─┘└─┘┴└─┴└─└─┘└─┘ ┴   ┴ ┴┘└┘└─┘└┴┘└─┘┴└─o" + $"\n\n{TheQ}\n{TheAns}");
        }
    }
}
