﻿using System;

namespace WebMVCR1.Models
{
    public class ModelClass
    {
        public static string ModelHello()
        {
            int hour = DateTime.Now.Hour;
            string greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return greeting;
        }
    }
}
