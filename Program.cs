using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        public static int classVar = 0;
        static void Main(string[] args)
        {
            // 클래스 변수 호출
            Program.classVar = -1;

            // 인스턴스 변수처럼 클래스 변수 사용 불가에 주의 (자바는 ok)
            //Program p = new Program();

            // 생성자
            // 기본(기정) 생성자 =- 생성자를 하나라도 정의하면 기본 생성자를 따로 작성해줘야 함
            //Product p = new Product();

            // 팩토리 메서드 패턴 (생성자에 private를 사용하는 경우
            Product p = Product.GetInstance("아아", 5000);

            // Property 실습
            Box box1 = new Box(100, 200);
            box1.Width = -3;
            Console.WriteLine(box1.Width); 

            Console.WriteLine(box1.Area);
        }
    }
}
