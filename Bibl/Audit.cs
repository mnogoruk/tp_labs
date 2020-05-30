﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyClass
{
    public class Audit
    {
        public static void MetodSubs(Magazine mg, DateTime dt)
        {
            try
            {
                StreamWriter sw = new StreamWriter("infoSubscribe.txt", true);
                sw.WriteLine(mg.ToString());
                sw.WriteLine("Подписка оформлена {0}\n", dt);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void RunAudit()
        {
            Magazine.Subscribe += new ProcessMagazineDelegate(Audit.MetodSubs);
        }
        public static void StopAudit()
        {
            Magazine.Subscribe -= new ProcessMagazineDelegate(Audit.MetodSubs);
        }
    }
}
