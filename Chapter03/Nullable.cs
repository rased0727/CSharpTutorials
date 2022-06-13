using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class QuestInfo // 퀘스트 정보를 담고 있는 클래스
    {
        public string _name;
        public int _reward;
        public int _reqLevel;
        public string _desc;

    }



    class Nullable
    {

        static void Main(string[] args)
        {
            int? nowQuest = null; // 현재 진행중인 퀘스트

            QuestInfo[] questList;

            QuestInfo q0 = questList[0];
            QuestInfo q1 = questList[1];


            Console.WriteLine(q0.name);

            Console.WriteLine(questList[nowQuest]._name);


            // if (nowQuest == -1 ) 옛날 프로그래머들이 아무런 퀘스트가 진행되지 않았을 때 사용한 구형 방식
            if(nowQuest.HasValue == false)
            {
                // 아무런 퀘스트가 진행되지 않았을때
            }




            bool? b = null; // 원래 bool은 True or False만 가능하지만 이렇게 Null값을 넣어서 초기화해줄 수 있다.
            Console.WriteLine(b);

            int? a = null;
            Console.WriteLine(a.HasValue); // a가 값을 갖고 있는가? 출력값 = false
            Console.WriteLine(a != null); // a가 값을 갖고 있는가? 위의 문제랑 같은 문제임. 출력값 = false

            a = 3;

            Console.WriteLine(a.HasValue); // True
            Console.WriteLine(a != null); // True
            Console.WriteLine(a.Value); // 값이 있을때만 사용할 수 있는 Value 속성. 결과값 = 3


        }
    }
}
