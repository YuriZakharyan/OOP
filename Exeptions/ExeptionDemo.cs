
using System;
using System.Collections.Generic;
using System.Text;

namespace Exeptions
{
    class ExeptionDemo
    {
        public int GrandParentGetNumber(int position)
        {
            int output = 0;
            Console.WriteLine("Method start");
            try
            {
                output = ParentGetNumber(position);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            return output;
        }
        public int ParentGetNumber(int position)
        {
            return GetNumber(position);
        }
        public int GetNumber(int position)
        {
            int output = 0;
            //try
            //{
                int[] arr = new int[] { 1, 2, 3, 4 };
                output = arr[position];
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            return output;
        }
    }
}
