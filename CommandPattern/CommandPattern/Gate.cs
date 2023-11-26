﻿using System;

namespace CommandPattern
{
    /// <summary>
    /// Класс, описывающий поведение ворот
    /// </summary>
    public class Gate
    {
        public void Open()
        {
            Console.WriteLine("Открываем ворота");
        }

        public void Close()
        {
            Console.WriteLine("Закрываем ворота");
        }
    }

}
