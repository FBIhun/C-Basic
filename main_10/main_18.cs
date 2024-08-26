// 컬렉션(COllection) : 데이터를 저장하는 자료구조
// arrayList : array(처음 초기화할때 크기가 정해짐)와 비슷하나 값이 가변적임 , 순차적 값크기, 값 형태 여러가지 섞을 수도 있음
// Queue : 값이 먼저 입력한 것이 먼저 빠져나감.
// Stack : 먼저 입력한 값이 나중에 나감.
// Hashtable : 순서가 따로 정해져 있지 않음. 
// -> Key(value를 찾기위한 값), Value(key로 가져올 항목) 로 구성됨
// using System;
// using System.Collections;

// public class MainClass {
//   public static void Main() {

// Hashtable
    // Hashtable ht = new Hashtable();
    // // 키,값 형태로 아이템 추가
    // ht["apple"] = "사과";
    // ht["banana"] = "바나나";
    // ht["orange"] = "오렌지";
    // // 저장된 키 값 출력  
    // Console.WriteLine(ht["apple"]);
    // Console.WriteLine(ht["banana"]);
    // Console.WriteLine(ht["orange"]);
  
// Stack
    // Stack st = new Stack();
    // st.Push(1);
    // st.Push(2);
    // st.Push(3);

    // while(st.Count > 0)
    //   Console.WriteLine(st.Pop());
    
// * Queue
    // Queue qu = new Queue();
    // // Enqueue로 값 생성
    // qu.Enqueue(1);
    // qu.Enqueue(2);
    // qu.Enqueue(3);
    // // Dequeue로 값 가져옴.
    // while(qu.Count > 0)
    //   Console.WriteLine(qu.Dequeue());
    // // 먼저 입력된 숫자가 먼저 나옴.

//  * arrayLIst
    // ArrayList al = new ArrayList();
    // al.Add(1);
    // al.Add("Hello");
    // al.Add(3.4);
    // al.Add(true);

    // foreach(var item in al)
    // Console.WriteLine(item);

    // al.Remove("Hello");
    // Console.WriteLine("----------------");

    // foreach(var item in al)
    //   Console.WriteLine(item);
//   }
// }