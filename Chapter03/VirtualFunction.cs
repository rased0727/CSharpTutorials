using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class Bird
    {
        public void fly()
        {
            Console.WriteLine("날아라");
        }
        public virtual void Sing()
        {
            Console.WriteLine("나는 베이스클래스입니다");
        }

    }
    class Duck : Bird
    {
        public override void Sing()
        {
            base.Sing();
            Console.WriteLine("꽥꽥!");
        }
    }
    class Eagle : Bird
    {
        public override void Sing()
        {
            base.Sing();
            Console.WriteLine("쉭쉭!");
        }
    }
    class Chicken : Bird
    {
        public override void Sing()
        {
            //base.Sing();
            Console.WriteLine("꼬끼오!");
        }
    }

    
    class VirtualFunction : Bird
    {
        static void Main(string[] args)
        {
            Bird b0 = new Bird();
           
            Bird b1 = new Duck();
            b1.Sing(); // Duck 클래스의 Sing 메서드 실행

            Bird b2 = new Eagle();
            b2.Sing();

            Bird b3 = new Chicken();
            b3.Sing();

            /*
            Chicken c = new Chicken();
            b1.fly();
            */

            /*
            Bird a;
            a.flay; // Null 오류 (new 키워드로 객체화 하지 않음)
            */
        }
    }
}
