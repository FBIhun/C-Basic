// 클래스의 데이터 전달 ->
// 매개변수 전달
// 맴버번수 전달 (13강의 Name 맴버변수만들고 인스턴스 변수로 만들고 호출.)
// 매서드 전달 (Console.WriteLine)

// 매개변수, 맴버변수
// using System;

// class Cat {
//   public string Name;
// // 이름 초기화할수 있도록 만듬
//   public Cat(string name) {
//     Name = name;
//     Console.WriteLine("고양이의 이름을 "+Name+"입니다.");
//   }
// }

// class Program {
//   public static void Main (string[] args) {
//     // 맴버변수를 코코로 초기화하여 출력
//     // 코코는 생성자에서 생성
//     Cat myCat = new Cat("코코");
//     // 몰리는 맴버변수의 이름을 몰리로 변경하고 myCat.Name = "몰리"로 초기화
//     myCat.Name = "몰리";
//     Console.WriteLine("고양이의 이름은 "+myCat.Name+"입니다.");
//   }
// }

// private, this 키워드
// private : 외부에서 호출하지 못하게함. (내부에서만 사용)
// public : . 으로 호출할 수 있음
// this : 맴버변수, 매개변수 이름을 다르게 하여 사용하였지만. this는 자기 자신을 의미하고 (클래스 자신) 클래스 내에 있는 이름을 의미. - 즉 맴버변수의 이름임. / this 연산자가 없으면 맴버변수를 의미
// using System;

// class Cat {
//   // 정보은닉. public은 누군가 수정할 수 있음.
//   private string name;

//   public Cat(string name) {
//     this.name = name;
//     Console.WriteLine("고양이의 이름을 "+name+"입니다.");
//   }
  
//   // Setname : 값 설정 (이름을 가져오기 위해)
//   // 반환이 없기 때문에 void 사용
//   public void SetName(string name) {
//     this.name = name;
//   }
//   // Getname : 값을 가져오는 매서드
//   // 가져온 이름을 출력해야 하기 때문에 string 이라는 반환 데이터 사용
//   public string GetName() {
//     return this.name;
//   }
// }
  
// class Program {
//   public static void Main (string[] args) {
//     Cat myCat = new Cat("코코");
//     myCat.SetName("몰리");
//     Console.WriteLine("고양이의 이름은 "+myCat.GetName()+"입니다.");
//   }
// }