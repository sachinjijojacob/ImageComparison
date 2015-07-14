using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cmpimg());
          
            //To delete the downloaded image
            
            if (System.IO.File.Exists("Image1.jpg"))
            {
                try
                {
                    System.IO.File.Delete("Image1.jpg");
                }
                catch(Exception excep)
                {
                   Console.WriteLine(excep.Message);
                }
            }

            if (System.IO.File.Exists("Image2.jpg"))
            {
                try
                {
                   System.IO.File.Delete("Image2.jpg");
                }
                catch (Exception excep)
                {
                    Console.WriteLine(excep.Message);
                }
            }
        }
    }
}
