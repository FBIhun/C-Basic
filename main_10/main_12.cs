// using System;

// // 사람이 할 수 있는 영역을 그 안에서 필요한 것만 구현한 것.
// class Person {
//   // 속성(Property)
//   public string Name;
//   // public string Birthday;
//   // public string Gender;
// // 메소드(Method)
//   public void Eat()
// {
//   // 먹는 행위
//   Console.WriteLine(Name + "이(가) 아침을 먹습니다.");
//   }
// }
// // public void Walk()
// // {
//   // 걷는 행위
// //   Console.WriteLine(Name + "이(가) 걷습니다." )
// // }
// // public void Run()
// // {
// // 뛰는 행위
// //   Console.WriteLine(Name + "이(가) 뛰습니다.")
// // }

// class Program {
//   public static void Main (string[] args) {
//   // 인스턴스변수명 = 클래스이름() -> 초기화도 가능 (메모리할당) 
//   Person p1 = new Person();
//   // p1인스턴스 변수 안에 name이 서준이라는 변수
//   p1.Name = "서준";
//   // Eat이라는 메소드 실행.
//   p1.Eat();
//   }
// }

// // 클래스 : 코드를 묶어서 관리하기 위한 기능을 제공하는 것(클래스가 가져야할 성질들을 정리)
// // 인스턴스 : 클래스를 사용하여 만들어진 객체 (클래스를 정리하여 메모리에 올린것)