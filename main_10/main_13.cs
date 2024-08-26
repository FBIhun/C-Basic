// // 13강
// // 매서드 오버로딩(Overloading) - 객체지향 특정
// // 하나의 이름으로 여러가지 역할을 하는 매서드를 의미 - 같은 이름으로 여러가지 역할을 하는 매서드
// using System;

// class Cat {
//   public string Name;
//   public int Weight;
  
//   public Cat(string name) {
//     // 맴버변수(Name)에 입력받은 문자열(name)을 넣어줘야 반영됨
//     Name = name;
//     Console.WriteLine("고양이의 이름은" +Name+ "입니다.");
//   }

//   public Cat(string name, int weight) {
//     Name = name;
//     Weight = weight;
//     Console.WriteLine("고양이의 이름은 "+Name+" 몸무게는 " + Weight + "입니다.");
//   }
// // 소멸자 생성
//   // 소멸자는 인스턴스변수가 사라질 때 호출되기 때문에 강제로 볼 수 없음. 
//   // 닷넷프레임워크에서 더이상 사용하지 않을 때 만들어짐.
//   // mycat1, mycat2 중 순서는 임의로 나오기 때문에 가정하면 안됨
//   ~Cat() {
//     Console.WriteLine(Name + "이(가) 사라집니다.");
//   }
// }

// class Program {
//   public static void Main (string[] args) {
//     // 별도로 매서드를 호출하지 않아도 생성자가 호출됨
//     // 생성자는 초기값 선언 시 사용함.
//     Cat mycat1 = new Cat("코코");
//     Cat mycat2 = new Cat("몰리");
//   }
// }



// // * 13강  6:30
// // 생성자 : 클래스가 인스턴스가 될 때 가장 먼저 호출되는 매서드 (초기화할 수 있는 값 설정)
// // 소멸자 : 객체가 사라질떄 호출되는 매서도 (클래스가 종료될 때 마무리하는 작업 넣어둠)

// // using System;

// // class Cat {
// //   public string Name;

// //   public Cat(string name) {
// //     // 맴버변수(Name)에 입력받은 문자열(name)을 넣어줘야 반영됨
// //     Name = name;
// //     Console.WriteLine("고양이의 이름은" +Name+ "입니다.");
// //   }
// // }

// // class Program {
// //   public static void Main (string[] args) {
// //     // 별도로 매서드를 호출하지 않아도 생성자가 호출됨
// //     // 생성자는 초기값 선언 시 사용함.
// //     Cat mycat1 = new Cat("코코");
// //     Cat mycat2 = new Cat("몰리");
// //   }
// // }