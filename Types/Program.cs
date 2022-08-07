// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Simple types
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

Console.WriteLine($"sbyteT: {sbyteT}");
Console.WriteLine($"byteT: {byteT}");
Console.WriteLine($"shortT: {shortT}");
Console.WriteLine($"ushortT: {ushortT}");
Console.WriteLine($"intT: {intT}");
Console.WriteLine($"uintT: {uintT}");
Console.WriteLine($"longT: {longT}");
Console.WriteLine($"ulongT: {ulongT}");
Console.WriteLine($"charT: {charT}");
Console.WriteLine($"floatT: {floatT}");
Console.WriteLine($"doubleT: {doubleT}");
Console.WriteLine($"boolT: {boolT}");
Console.WriteLine($"decimalT: {decimalT}");


var infinity = 1.0 / 0.0;
var negativeInfinity = -1.0 / 0.0;
Console.WriteLine($"Infinity: {infinity}");
Console.WriteLine($"negative Infinity {negativeInfinity}");

var intMax = int.MaxValue;
var intMin = int.MinValue;
Console.WriteLine($"max value {intMax}");
Console.WriteLine($"min value {intMin}");
Console.WriteLine($"max value +1 {intMax+1}");
Console.WriteLine($"min value -1 {intMin-1}");

var decimalMax = decimal.MaxValue;
Console.WriteLine($"decimal max: {decimalMax}");
// Console.WriteLine($"decimal max + 1: {decimalMax+1}");


int? intNullable = 5;
System.Nullable<int> intNull = null;
var hasValue = intNullable.HasValue;
var hasValue2 = intNull.HasValue;

Console.WriteLine($"has value: {hasValue}");
Console.WriteLine($"has value: {hasValue2}");

int intBox = 32;
object box = intBox;
Console.WriteLine($"box: {intBox}");
if (box is int) Console.WriteLine("its an int");