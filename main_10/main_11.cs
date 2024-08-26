// using System;

// class Program {
//   public static void Main (string[] args) {
//     sbyte value1 = 64;
//     sbyte value2 = 64;
//     // (암시적 형변환 - 컴파일러가 자등으로 형변환) 
//     // int가 되었으나 sbyte에 넣어서 오류인것
//     // int value3 = value1 + value2;
//     // 중괄호를 넣어서 명시적 형변환(직접 형변환) , 
//     // 연산시에 자동으로 더큰데이터로 형변환됨.
//     int value3 = (int)value1 + value2;
//     // sbyte value3 = value1 + value2;
//     Console.WriteLine(value3);
//     // sbyte num = 128;
//     // Console.WriteLine(num);
//   }
// }