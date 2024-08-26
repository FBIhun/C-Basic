// 예외상황 예외처리하기.

// try 예외가 발생할 수 있는 상황 코드
// catch 예외가 발생할 때 출력할 내용
// 예외상황을 모르면 Exception 을 통해 오류상황 확인 가능

using System;
using System.Collections;

public class MainClass {
  public static void Main () {
    Console.Write("나눌 숫자를 입력하세요 :");
    // int divider = int.Parse(Console.ReadLine());
    // 문자를 숫자로 변환 (Parse)
    int num = int.Parse(Console.ReadLine());
    try {
      Console.WriteLine(10/num);
    }
    // catch {
    catch (Exception e) {
      // Console.WriteLine("0으로 나눌 수 없습니다.");
      Console.WriteLine("예외 : " + e.Message);
    }
    // Console.WriteLine(10/num);
  }
}