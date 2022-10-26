using System;

namespace CSharp09
{
    internal class Program
    {

        // 델리케이트
        //=> 함수를 담을수 있는 형식(=자료형)이다.


        delegate void CallEvent();                      //반환형이 없고 매개변수가 없는 함수를 담는 델리게이트 자료형.
        delegate int CallEvent2(int a , int b);        //int를 반환하고  int를 2개 받는 함수를 담는 델리게이트 자료형.
        static void Main(string[] args)
        {
            Sort sort = new Sort();
                sort.start();

            return;

            CallEvent onCall = Temp;        //onCall 델리게이트에 Temp함수 대입.
            //onCall = Sum                  //다른 형태의 함수는 대입할 수 없다
            onCall();                       //델리게이트를 이용하여 함수를 호출함 

            CallEvent2 onCall2 = Sum;          //형식이 맞는 sum을 대입한다     
            int value = onCall2(10, 20);       // 대리자(deletgate)를 통하여 함수 호출
            Console.WriteLine($"결과는 : {value}");
            
            onCall2 = Minus;
            value = onCall2(10, 20);
            Console.WriteLine($"결과는 : {value}");
            
            onCall2 = Multiple;
            value = onCall2(10, 20);
            Console.WriteLine($"결과는 : {value}");

            Calculate(20, 40, Sum);
            Calculate(20, 40, Minus);
            Calculate(20, 40, Multiple);
        
        }

        //계산 함수
        delegate int CalculateEvent(int a, int b);
        static void Calculate(int a , int b , CalculateEvent onEvent)
        {
            int value = onEvent(a, b);
            Console.WriteLine($"계산 결과는  : {value}다");
        }

        //void :반환형이 없다.
        //Temp함수는 반환형이 없고 매개변수를 받지 않는 함수다.
        static void Temp()
        {
            Console.WriteLine("함수 1");
        }

        //Sum 함수는  int를 반환하고 매개변수  int를 2개 받는다.
        static int Sum(int a , int b)
        {
            return a + b;
        }
        
        static int Minus(int a , int b)
        {
            return a - b;
        }

        static int Multiple(int num1, int num2)
        {
            return (num1 * num2)+(num1 * num2);
        }
    }
}
