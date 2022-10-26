using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp09
{
    //일반화 델리게이트
    delegate int Compare<T>(T a, T b);

    internal class Sort

    {
        public void start()
        {
            int[] array = { 10, 18, 5, 7,21 };
                       
            Console.WriteLine($"정렬전 : {string.Join(',',array)}");
            BubbleSort(array, Compare);
            Console.WriteLine($"정렬후 : {string.Join(',',array)}");
                
            string[] array2 = { "AA", "BB", "DD", "CC", "EE" };
            
            Console.WriteLine($"정렬전 : {string.Join(',',array2)}");
            BubbleSort(array2, Compare);            
            Console.WriteLine($"정렬후 : {string.Join(',',array2)}");
           

            
        }
        
        //COMPARE 인트타입을 두개받는 델리게이트
        void BubbleSort<T>(T[] array, Compare<T> compare, bool isAscending = true)
        {
            int count = array.Length - 1;
            int com = isAscending ? -1 : 1;
           
            for(int loop = 0; loop < array.Length-1; loop++)
            {
                for (int i = 0; i < count -loop; i++) 
                {
                    if (compare(array[i],array[i + 1]) == com)
                        Swap(array, i, i + 1);
                }
            }          
        }
         
       void Swap<T>(T[]array, int a ,int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
       int CompareInt(int a , int b) {
            {
                if (a > b)
                    return -1;
                else if (a < b)
                    return 1;

                else
                    return 0;
            } 
        int Compare(string a ,string b)
        {
            int aNum = 0;
            int bNum = 0;

            foreach (char c in a)
                aNum += c; 
                
            foreach (char c in b)
                bNum += c;

            if (aNum > bNum)
                return -1;

            else if (aNum < bNum)
                return 1;
            else
                return 0;
        }
        }
    }
}
