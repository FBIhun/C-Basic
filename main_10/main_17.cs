// // MSDN : C#의 지식창고.
// // 데이터형 [] 변수명; -> 배열의 선언

// using System;

// public class MainClass {
//   public static void Main() {
//     int[] array1 = new int[3];
//     array1[0] = 10;
//     array1[1] = 20;
//     array1[2] = 30;

//     int[] array2 = new int[] {1, 2, 3};

//     int[] array3 = {4, 5, 6};

//     // Console.WriteLine(array1);
//     // Console.WriteLine(array2);
//     // Console.WriteLine(array3);
//     // Console.WriteLine(array1[0]);
//     // Console.WriteLine(array1[1]);
//     // Console.WriteLine(array1[2]);
  
//     // 비효율적으로 for 문 사용
//     // for(int i=0; i<3; i++)
//     //   Console.WriteLine(array2[i]);
    
//     // 어레이 안의 내용을 알면 반복문으로 가능하지만 모른다면 ? -> Length 사용
//     // Console.WriteLine(array3.Length);
//     // for(int i=0; i<array3.Length; i++)
//     //   Console.WriteLine(array3[i]);

//     // foreach 문
//     foreach(int i in array3) {
//       Console.WriteLine(i);
//     }
//   }
// }