//Simple types
using System.Text;

sbyte sbyteT = default; //0
byte byteT = default; //0
short shortT = default; //0 -- 16
ushort ushortT = default; //0
int intT = default; //0 -- 32
uint uintT = default; //0
long longT = default; //0 -- 64
ulong ulongT = default; //0
char charT = default; //'\x000'
float floatT = default; //0.0f
double doubleT = default; //0.0d
bool boolT = default; //false
decimal decimalT = default; //0m

var sb = new StringBuilder();
sb.AppendLine(String.Format("{0,10} {1,10}","sbyteT:", sbyteT));
sb.AppendLine(String.Format("{0,10} {1,10}","byteT:", byteT));
sb.AppendLine(String.Format("{0,10} {1,10}","shortT:", shortT));
sb.AppendLine(String.Format("{0,10} {1,10}","ushortT:", ushortT));
sb.AppendLine(String.Format("{0,10} {1,10}","intT:", intT));
sb.AppendLine(String.Format("{0,10} {1,10}","uintT:", uintT));
sb.AppendLine(String.Format("{0,10} {1,10}","longT:", longT));
sb.AppendLine(String.Format("{0,10} {1,10}","ulongT:", ulongT));
sb.AppendLine(String.Format("{0,10} {1,10}","charT:", charT));
sb.AppendLine(String.Format("{0,10} {1,10}","floatT:", floatT));
sb.AppendLine(String.Format("{0,10} {1,10}","doubleT:", doubleT));
sb.AppendLine(String.Format("{0,10} {1,10}","boolT:", boolT));
sb.AppendLine(String.Format("{0,10} {1,10}","decimalT:", decimalT));
Console.WriteLine(sb);

var typesRepo = new Types();
typesRepo.ShowRun();