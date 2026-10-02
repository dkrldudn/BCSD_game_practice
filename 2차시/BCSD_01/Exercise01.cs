using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    private void Awake()
    {
        /*sbyte  byteValue   = -128;
        byte   ubyteValue  = 255;
        short  shortValue  = -32768;
        ushort ushortValue = 65535;
        int    intValue    = -2147483648;
        uint   uintValue   = 4294967295;
        long   longValue   = -9223372036854775808;
        ulong  ulongValue  = 18446744073709551615;
        char   charValue   = 'K';

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("ubyte Data : " + ubyteValue);
        Debug.Log("short Data : " + shortValue);
        Debug.Log("ushort Data : " + ushortValue);
        Debug.Log("int Data : " + intValue);
        Debug.Log("uint Data : " + uintValue);
        Debug.Log("long Data : " + longValue);
        Debug.Log("ulong Data : " + ulongValue);
        Debug.Log("char Data : " + charValue);*/

        /*float floatValue01 = 3.14159265358979238462643383279f;
        float floatValue02 = 31.4159265358979238462643383279f;
        double doubleValue = 3.14159265358979238462643383279;
        decimal decimalValue = 3.14159265358979238462643383279m;

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue01);
        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);*/

        /*string stringValue = "안녕하세요. 고박사입니다.";
        bool boolValue = true;

        Debug.Log("string Data : " + stringValue);
        Debug.Log("bool Data : " + boolValue);*/

        /*sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        //오버플로우 발생
        sbyte sbyteValue = 130;
        int intValue = (int)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);*/

        /*sbyte sbyteValue = 31;
        byte byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        //부호 있는 정수가 음수
        sbyte sbyteValue = -31;
        byte byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        //부호 없는 정수 > 부호 있는 정수 최댓값
        sbyteValue = (sbyte)byteValue;
        byteValue = 200;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);*/

        /*float floatValue = 69.6875f;
        double doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        floatValue = 0.1f;
        doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);*/

        /*float floatValue = 0.9f;
        int intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);

        floatValue = 1.1f;
        intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);*/

        /*int intValue = 10;
        float floatValue = 12.3456f;
        string stringValue = "33";

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);

        intValue = int.Parse(stringValue);
        floatValue = float.Parse(stringValue);
        stringValue = "33.4567";

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);*/

        /*enum PlaeyrState{Idle, Move, Attack}

        private void Awake()
        {
            PlayerState playerState = PlayerState.Idle;
            switch(plaeyrState)
            {
                case PlayerIdle{
                    Debug.Log("플레이어 상태: 대기");
                    break;
                }
                case PlayerMove{
                    Debug.Log("플레이어 상태: 이동");
                    break;
                }
                case PlayerAttack{
                    Debug.Log("플레이어 상태: 공격");
                    break;
                }
            }
        }*/

        /*int minutes = 1;
        int seconds = 15;

        // 서식 항목 - 맞춤
        Debug.Log(string.Format("기본 : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("왼쪽 맞춤 : {0, -5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("오른쪽 맞춤 : {0, 5}{1}{2}", minutes, ":", seconds));

        // 서식 항목 - 서식 문자열 설정 (숫자)
        Debug.Log(string.Format("10진수 서식화 : {0:D}", 123));
        Debug.Log(string.Format("10진수 서식화(5자리) : {0:D5}", 123));

        Debug.Log(string.Format("16진수 서식화 : {0:X}", 0x00));
        Debug.Log(string.Format("16진수 서식화(10자리) : {0:X10}", 0x00));

        Debug.Log(string.Format("고정소수점 서식화 : {0:F}", 1.23));
        Debug.Log(string.Format("고정소수점 서식화(소수점 1자리) : {0:F1}", 1.23));

        Debug.Log(string.Format("콤마로 구분 : {0:N}", 1234567890));
        Debug.Log(string.Format("지수 : {0:E}", 1234567890));

        //서식 문자열 설정
        DateTime dt = new DateTime(2020, 2, 22, 13, 40, 0);
        DateTime str = dt.Tostring("yyyy-MM-dd tt hh:mm:ss (dddd)");
        Debug.Log(str);

        str = dt.Tostring("yyyy-MM-dd HH:mm:ss (dddd)");
        Debug.Log(str);

        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf('o');
        Debug.Log($"o는 앞에서부터 {numeric+1}번째에 있습니다.");

        numeric = str.LastIndexOf('o');
        Debug.Log($"o는 뒤에서부터 {numeric}번째에 있습니다.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} 문장은 Hello부터 시작한다? {isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str} 문장은 World부터 시작한다? {isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} 문장은 Hello로 끝난다? {isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str} 문장은 World로 끝난다? {isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str} 문장에 Hell이 포함되어 있다? {isTrue}");*/
    
        /*int a = 10;
        Debug.Log($"a = 10 : {a}");

        a += 10;
        Debug.Log($"a += 10 : 결과 값 {a}");

        // 무작위 보기의 보간식에 수식을 넣어서 연산
        Debug.Log($"a == 9 : 결과 값 {a == 9}");
        Debug.Log($"a == 8 : 결과 값 {a == 8}");
        Debug.Log($"a /= 7 : 결과 값 {a /= 7}");
        Debug.Log($"a %= 6 : 결과 값 {a %= 6}");
        Debug.Log($"a %= 5 : 결과 값 {a %= 5}");
        Debug.Log($"a |= 4 : 결과 값 {a |= 4}");
        Debug.Log($"a ^= 3 : 결과 값 {a ^= 3}");
        Debug.Log($"a <<= 2 : 결과 값 {a <<= 2}");
        Debug.Log($"a >>= 1 : 결과 값 {a >>= 1}");

        int a = 10;
        Debug.Log(a);

        a++;
        Debug.Log(a);

        ++a;
        Debug.Log(a);

        Debug.Log(a++);
        Debug.Log(a);
        Debug.Log(++a);
        Debug.Log(a);

        bool result = false;
        int x = 5, y = 2;

        // && 연산자 (두 조건이 모두 참일 때만 참)
        result = x > 2 && y != 5;
        Debug.Log($"{x} > 2 && {y} != 5 = {result}");

        // || 연산자 (두 조건이 모두 거짓일 때만 거짓)
        result = x < 4 || y == 3;
        Debug.Log($"{x} < 4 || {y} == 3 = {result}");

        // ! 연산자 (참은 거짓으로 거짓은 참으로)
        Debug.Log(result);
        result = !result;
        Debug.Log(result);

        // 조건(삼항) 연산자
        int hp = -10;
        hp = hp < 0 ? 0 : hp;
        Debug.Log("체력 : " + hp);*/

        /*if(x%2==0)
        {
            Debug.Log("x는 짝수다");
        }

        if(x>5&&x<10)
        {
            Debug.Log("x는 5보다 크고 10보다 작다");
        }

        if(x>5)
        {
            if(x<10)
            {
                Debug.Log("x는 5보다 크고 10보다 작다");
            }
        }

        if (x >= 90)
        {
            Debug.Log("학점 : A+");
        }
        else if (x >= 80)
        {
            Debug.Log("학점 : B+");
        }
        else if (x >= 70)
        {
            Debug.Log("학점 : C+");
        }
        else if (x >= 60)
        {
            Debug.Log("학점 : D");
        }
        else
        {
            Debug.Log("학점 : F");
        }*/

        /*for(int index=0; index<10; ++index)
        {
            Debug.Log(index);
        }

        for(int x=1; x<10; ++x)
        {
            for(int y=1; y<10; ++y)
            {
                Debug.Log($"{x}x{y}={x*y}");
            }
        }

        int result =0;
        int index =1;

        while(index<=100)
        {
            result += index;
            index++;
        }
        Debug.Log($"1부터 100까지의 합은 {result}");*/

        /*int[] enemys = new int[5];

        Debug.Log($"배열의 타입 : {enemys.GetType()}");
        Debug.Log($"배열의 기본 타입: {enemys.GetType().BaseType}");

        Debug.Log("==정렬 전==");
        for(int index=0; index<enemys.Length; ++index)
        {
            enemys[index] = UnityEngine.Random.Range(0, 100);

            Debug.Log(enemys[index]);
        }

        Array.Sort(enemys);

        Debug.Log("==정렬 후==");
        for(int index=0; index<enemys.Length; ++index)
        {
            Debug.Log(enemys[index]);
        }
        Debug.Log($"Dimensions : {enemys.Rank}");

        int[][] array = new int[3][];

        array[0] new int[3] {1, 2, 3};
        array[1] new int[] {10, 20, 30, 40};
        array[2] new int[] {100, 200, 300, 400, 500};

        for(int i=0; i<array.Length; ++i)
        {
            for(int j=0; j<array[i].Length; ++j)
            {
                Debug.Log($"[{i}][{j}] = {array[i][j]}");
            }
        }*/
    }
}