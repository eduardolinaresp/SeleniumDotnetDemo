﻿using SeleniumPhanthomjs;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPhanthomjs
{
    class Program
    {
        static int Main(string[] args)
        {

            int flag1, flag2, flag3;

            flag1 = flag2 = flag3 = 0;

            //flag1 = Ejemplo1.main();

            //flag2 = Ejemplo2.main();  

            //flag3 = datosGov.main();

            //flag3 =  Transponer.main();

            //flag3 =  final.main();

            //flag3 =  directo.main();

            //flag2 = directov3.main();

            //flag3 = directov4.main();

            //flag2 = nuevo.main();

            //flag3 = nuevo2.main();

            Internet inter = new Internet();

            flag3 = inter.main();


          if (flag1 + flag2  == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }

            
        }
    }
}