using FBHR.DataAccess;
using FBHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookHistroyReport
{
    public class Program
    {
        static void Main(string[] args)
        {
            ScreenLookup screenLookup = new ScreenLookup();

            LookupTypeModel model = new LookupTypeModel();
            model.MyProperty = 1;
            screenLookup.insertLookup(model);
            screenLookup.insertLookup(new LookupTypeModel
                ()
            { MyProperty = 1 });
            screenLookup.insertLookup3();
        }
    }
}
