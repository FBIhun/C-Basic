// 오버로딩 : 여러개를 선언하고 형식이나 갯수에 맞게끔 호출
// 오버라이딩(overriding) : 부모클래스의 메소드를 자식클래스에서 재정의
// (해당하는 클래스에서의 매서드가 호출됨.)

// using System;
// // 기반클래스
// class Robot {
//   public void Move() {
//     Console.WriteLine("로봇이 움직입니다.");
//   }
// }
// // : Robot 은 Robot 클래스를 상속받는다
// class CleanRobot : Robot {
//   public void Move() {
//     Console.WriteLine("청소 로봇이 움직입니다.");
//   }
// }
// // RescueRobot 은 Robot 클래스를 상속받는다
// class RescueRobot : Robot {
//   public void Move() {
//     Console.WriteLine("구조 로봇이 움직입니다.");
//   }
// }

// class Program {
//   public static void Main (string[] args) {
//     CleanRobot cr = new CleanRobot();
//     RescueRobot rr = new RescueRobot();
//     cr.Move();
//     rr.Move();
//   }
// }

// 상속 : 기반클래스(base class)에서 파생 클래스(derived class)에서 받을 수 있음.

// using System;

// class Robot {
//   public void Move() {
//     Console.WriteLine("로봇이 움직입니다.");
//   }
// }
// // : Robot 은 Robot 클래스를 상속받는다
// class CleanRobot : Robot {
//   public void Clean() {
//     Console.WriteLine("청소를 시작합니다.");
//   }
// }

// class Program {
//   public static void Main (string[] args) {
//     CleanRobot cr = new CleanRobot();
//     cr.Move();
//     cr.Clean();
//   }
// }

