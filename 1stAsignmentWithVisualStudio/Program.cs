int num1=0;
int num2=0;
string MessagePlus1 = "الرجاء إدخال الرقم المطلوب لعملية الجمع";
string MessagePlus2 = "الرجاء إدخال الرقم الذي تريد جمعه على الرقم الأول";
string MessageMinus1 = "الرجاء إدخال الرقم المطلوب لعملية الطرح";
string MessageMinus2 = "الرجاء إدخال الرقم الذي تريد طرحه من الرقم الأول";
string MessageMultiply1 = "الرجاء إدخال الرقم المطلوب لعملية الضرب";
string MessageMultiply2 = "الرجاء إدخال الرقم الذي تريد حاصل ضرب الرقم الأول فيه";
string MessageDivide1 = "الرجاء إدخال الرقم المطلوب لعملية القسمة";
string MessageDivide2 = "الرجاء إدخال الرقم الذي تريد حاصل قسمة الرقم الأول عليه";
string Result = "";
Console.WriteLine(MessagePlus1);
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MessagePlus2);
num2 = Convert.ToInt32(Console.ReadLine());
Result = num1 + "+" + num2 + "=";
Console.WriteLine(Result+(num1+num2));
Console.WriteLine("اضغط أي مفتاح على لوحة المفاتيح للانتقال إلى العملية التالية");
Console.ReadKey();
Console.WriteLine(MessageMinus1);
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MessageMinus2);
num2 = Convert.ToInt32(Console.ReadLine());
Result = num1 + "-" + num2 + "=";
Console.WriteLine(Result + (num1 - num2));
Console.WriteLine("اضغط أي مفتاح على لوحة المفاتيح للانتقال إلى العملية التالية");
Console.ReadKey();
Console.WriteLine(MessageMultiply1);
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MessageMultiply2);
num2 = Convert.ToInt32(Console.ReadLine());
Result = num1 + "*" + num2 + "=";
Console.WriteLine(Result + (num1 * num2));
Console.WriteLine("اضغط أي مفتاح على لوحة المفاتيح للانتقال إلى العملية التالية");
Console.ReadKey();
Console.WriteLine(MessageDivide1);
double numDivide1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(MessageDivide2);
double numDivide2 = Convert.ToDouble(Console.ReadLine());
Result = numDivide1+ "/" + numDivide2+ "=";
Console.WriteLine(Result+(numDivide1/numDivide2));
Console.WriteLine("شكرا لاستخدامك برنامج الآلة الحاسبة المبسط، اضغط على أي مفتاح لإنهاء البرنامج");
Console.ReadKey();