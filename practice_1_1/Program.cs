int income = 0, outcome = 0;
int[] outcomeClassNum = new int[] { 0, 0, 0, 0, 0, 0 };
string[] outcomeClassName = new string[] { "不知道", "食", "衣", "住", "行", "育樂" };
while (true)
{
    Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)計算比例 (4)剩餘金額 (5)退出程式");
    Console.Write("請輸入數字選擇功能: ");
    int opt = int.Parse(Console.ReadLine());
    if (opt == 1)
    {
        Console.Write("輸入金額: ");
        income += int.Parse(Console.ReadLine());
    }
    else if (opt == 2)
    {
        Console.WriteLine("(1)食, (2)衣, (3)住, (4)行, (5)育樂");
        Console.Write("請輸入數字選擇支出項目: ");
        int classType = int.Parse(Console.ReadLine());
        Console.Write("請輸入支出金額: ");
        int tmp = int.Parse(Console.ReadLine());
        outcome += tmp;
        outcomeClassNum[classType] += tmp;
    }
    else if (opt == 3)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("{0}: {1}%", outcomeClassName[i], (outcome != 0 ? (double)outcomeClassNum[i] / outcome * 100 : 0));
        }
    }
    else if (opt == 4)
    {
        Console.WriteLine("剩餘金額為: {0}", income - outcome);
    }
    else
    {
        Console.WriteLine("已成功退出");
        Console.ReadKey();
        return;
    }
}