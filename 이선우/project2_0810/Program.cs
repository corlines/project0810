using System.Threading.Channels;
using static System.Console;
namespace project2_0810
{
    class Program
    {
        enum DialogResult { YES,NO,CANCEL,CONFIRM,OK };
        enum DialogResult2 { YES = 10, NO, CANCEL, CONFIRM = 50, OK };
        static void Main(string[] args)
        {
            #region 예제 1

            //byte a = 240;
            //Console.WriteLine($"a={a}");

            //byte b = 0b1111_0000;
            //Console.WriteLine($"b={b}");

            //byte c = 0XF0;
            //Console.WriteLine(c);

            //uint d = 0x1234_abcd;
            //Console.WriteLine(d);
            #endregion
            #region 예제 2
            //byte a = 255;
            //sbyte b = (sbyte)a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            #region 예제 3
            //uint a = uint.MaxValue;

            //Console.WriteLine(a);

            //a = a + 1;

            //Console.WriteLine(a);
            #endregion
            #region 예제 4
            //float a = 3.14159265358979323846f;
            //Console.WriteLine(a);

            //double b = 3.1415926535897932384626383327950288;
            //Console.WriteLine(b);
            #endregion
            #region 예제 5
            //float a = 3.14159265358979323846264338279f;
            //double b = 3.14159265358979323846264338279;
            //decimal c = 3.14159265358979323846264338279m;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            #endregion
            #region 예제 6
            //string a = "안녕하세요?";
            //string b = "박상현입니다.";

            //Console.WriteLine(a + b);
            #endregion
            #region 예제 7
            //string multiline = """
            //    별 하나에 추억과
            //    별 하나에 사랑과
            //    별 하나에 쓸쓸함과
            //    별 하나에 동경과
            //    별 하나에 시와
            //    별 하나에 어머니, 어머니
            //    """;
            //Console.WriteLine(multiline);
            #endregion
            #region 예제 8
            //object a = 123;
            //object b = 3.141592653589793238462643383279m;
            //object c = true;
            //object d = "안녕하세요";
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            #endregion
            #region 예제 9
            //int a = 123;
            //object b = (object)a;
            //int c = (int)b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //double x = 3.1414213;
            //object y = x;
            //object z = (double)y;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            #endregion
            #region 예제 10
            //sbyte a = 127;
            //Console.WriteLine(a);

            //int b = (int)a;
            //Console.WriteLine(b);

            //int x = 128;
            //Console.WriteLine(x);

            //sbyte y = (sbyte)x;
            //Console.WriteLine(y);
            #endregion
            #region 예제 11
            //float a = 69.6875f;
            //Console.WriteLine(a);

            //double b = (double)a;
            //Console.WriteLine(b);
            //Console.WriteLine("69.6875 == b : {0}",69.6875 == b);

            //float x = 0.1f;
            //Console.WriteLine(x);

            //double y = (double)x;
            //Console.WriteLine(y);

            //Console.WriteLine("0.1 == y : {0}",0.1 == y);
            #endregion
            #region 예제 12
            //int a = 500;
            //Console.WriteLine(a);

            //uint b =(uint)a;    
            //Console.WriteLine(b);

            //int x = -30;
            //Console.WriteLine(x);
            //uint y = (uint)x;
            //Console.WriteLine(y);
            #endregion
            #region 예제 13
            //float a = 0.9f;
            //int b = (int)a;
            //Console.WriteLine(b);
            //float c = 1.1f;
            //int d = (int)c;
            //Console.WriteLine(d);
            #endregion
            #region 예제 14
            //int a = 123;
            //string b = a.ToString();
            //Console.WriteLine(b);

            //float c = 3.14f;
            //string d = c.ToString();
            //Console.WriteLine(d);

            //string e = "123456";
            //int f = Convert.ToInt32(e);
            //Console.WriteLine(f);

            //string g = "1.2345";
            //float h = float.Parse(g);
            //Console.WriteLine(h);
            #endregion
            #region 예제 15
            //const int MAX_INT = 214748647;
            //const int MIN_INT = -2147483648;

            //Console.WriteLine(MAX_INT);
            //Console.WriteLine(MIN_INT);
            #endregion
            #region 예제 16
            //Console.WriteLine((int)DialogResult.YES);
            //Console.WriteLine((int)DialogResult.NO);
            //Console.WriteLine((int)DialogResult.CANCEL);
            //Console.WriteLine((int)DialogResult.CONFIRM);
            //Console.WriteLine((int)DialogResult.OK);
            #endregion
            #region 예제 17
            //DialogResult result = DialogResult.YES;

            //Console.WriteLine(result == DialogResult.YES);
            //Console.WriteLine(result == DialogResult.NO);
            //Console.WriteLine(result == DialogResult.CANCEL);
            //Console.WriteLine(result == DialogResult.CONFIRM);
            //Console.WriteLine(result == DialogResult.OK);
            #endregion
            #region 예제 18
            //Console.WriteLine((int)DialogResult2.YES);
            //Console.WriteLine((int)DialogResult2.NO);
            //Console.WriteLine((int)DialogResult2.CANCEL);
            //Console.WriteLine((int)DialogResult2.CONFIRM);
            //Console.WriteLine((int)DialogResult2.OK);
            #endregion
            #region 예제 19
            //int? a = null;

            //Console.WriteLine(a.HasValue);
            //Console.WriteLine(a != null);

            //a = 3;

            //Console.WriteLine(a.HasValue);
            //Console.WriteLine(a != null);
            //Console.WriteLine(a.Value);
            #endregion
            #region 예제 20
            //var a = 20;
            //Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            //var b = 3.1414213;
            //Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);
            //var c = "Hello World!";
            //Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            //var d = new int[] { 10, 20, 30};
            //Console.Write("Type: {0}, Value: ",d.GetType());
            //foreach(var e in d)
            //    Console.Write("{0} ",e);
            //Console.WriteLine();
            #endregion
            #region 예제 21
            //System.Int32 a = 123;
            //int b = 456;

            //Console.WriteLine("a type:{0}, value{1}",a.GetType().ToString(),a);
            //Console.WriteLine("b type:{0}, value{1}",b.GetType().ToString(),b);

            //System.String c = "abc";
            //string d = "def";
            //Console.WriteLine("c type:{0}, value{1}",c.GetType().ToString(),c);
            //Console.WriteLine("d type:{0}, value{1}",d.GetType().ToString(),d);
            #endregion
            #region 예제 22
            //string greeting = "Good Morning";


            //WriteLine(greeting);
            //WriteLine();


            //WriteLine("IndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            //WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));


            //WriteLine("LastIndexOF 'Good' : {0}",greeting.LastIndexOf("Good"));
            //WriteLine("LastIndedOf 'o' : {0}", greeting.LastIndexOf("o"));

            //WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            //WriteLine("Startswith 'Morning' : {0}", greeting.StartsWith("Morning"));

            //WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            //WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));
            //WriteLine("Contains 'Evening' : {0}",greeting.Contains("Evening"));
            //WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));
            //WriteLine("Replaced 'Morning' with 'Evening': {0}",
            //    greeting.Replace("Morning", "Evening"));
            #endregion
            #region 예제 23
            //WriteLine("ToLower() : '{0}'","ABC".ToLower());
            //WriteLine("ToUpper() : '{0}'","abc".ToUpper());

            //WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
            //WriteLine("Remove() : '{0}'", "I Don't Love you.".Remove(2, 6));

            //WriteLine("Trim() : '{0}'", "No Spaces ".Trim());
            //WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            //WriteLine("TrimEnd() : '{0}'"," No Spaces ".TrimEnd());
            #endregion
            #region 예제 24
            //string greeting = "Good morning";

            //WriteLine(greeting.Substring(0, 5));
            //WriteLine(greeting.Substring(5));
            //WriteLine();

            //string[] arr = greeting.Split(new string[] {" "}, StringSplitOptions.None);
            //WriteLine("Word Count : {0}",arr.Length);

            //foreach (string element in arr)
            //    WriteLine("{0}",element);
            #endregion


            #region 예제 25
            //string fmt = "{0,-20}{1,-15}{2,30}";

            //WriteLine(fmt, "Publisher", "Author", "Title");
            //WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            //WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            //WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
            #endregion

            WriteLine("10진수 {0:D}", 123);
            WriteLine("10진수 {0:D5}", 123);
            WriteLine("16진수: 0x{0:X}", 0xFF1234);
            WriteLine("16진수: 0x{0:X8}", 0xFF1234);

            WriteLine("숫자: {0:N}", 123456789);
            WriteLine("숫자: {0:No}", 12345789);
            WriteLine("고정 소수점: {0:F}", 123.45);
            WriteLine("고정 소수점 {0:F5}", 123.456);

            WriteLine("공학: {0:E}", 123.456789);



        }
    }
}
