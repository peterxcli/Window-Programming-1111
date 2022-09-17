int income = 0, outcome = 0;
int[] typeNum = new int[0];
string[] typeName = new string[0];

int readNum (bool isIncome = false) {
    int ret = new int();
    try {
        ret = int.Parse(Console.ReadLine());
        if (isIncome && ret < 0) {Console.WriteLine("收入不可為負數"); ret = -1;}
        else if (ret < 0) {Console.WriteLine("不可輸入負數"); ret = -1;}
    }
    catch (Exception ex) {
        Console.WriteLine("請輸入數字");
        ret = -1;
    }
    return ret;
}

while (true) {
    Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式");
    Console.Write("請輸入數字選擇功能: ");
    int opt = readNum(isIncome: false);
    
    if (opt == 1) { //輸入收入 ok
        Console.Write("輸入金額: ");
        int tmp = readNum(isIncome: true);
        if (tmp == -1) {
            Console.WriteLine("");
            continue;
        }
        income += tmp;
        Console.WriteLine("");
    }
    else if (opt == 2) { //輸入支出 ok
        if (typeName.Length == 0) {
            Console.WriteLine("請新增支出項目");
            Console.WriteLine("");
            continue;
        }
        for (int i = 0; i < typeName.Length; i++) {
            Console.Write("({0}){1}{2}", i+1, typeName[i], (i == typeName.Length-1 ? "\n" : " "));
        }
        Console.Write("請輸入數字選擇支出項目: ");
        int typeIdx = readNum(isIncome:false)-1;
        if (typeIdx == -1) {
            Console.WriteLine("");
            continue;
        }
        if (typeIdx < 0 || typeIdx >= typeName.Length) {
            Console.WriteLine("此數字不在範圍中");
            Console.WriteLine("");
            continue;
        }
        Console.Write("請輸入支出金額: ");
        int tmp = readNum(isIncome: false);
        if (tmp == -1) {
            Console.WriteLine("");
            continue;
        }
        if (income < outcome + tmp) {
            Console.WriteLine("存款不足");
            Console.WriteLine("");
            continue;
        }
        outcome += tmp;
        typeNum[typeIdx] += tmp;
        Console.WriteLine("");
    }
    else if (opt == 3) { //新增項目 ok
        if (typeName.Length >= 5) {
            Console.WriteLine("已無法再新增支出項目");
            Console.WriteLine("");
            continue;
        }
        Console.Write("輸入項目名稱: ");
        string newType = Console.ReadLine();
        if (Array.Exists(typeName, x => x == newType)) {
            Console.WriteLine("支出項目已存在");
            Console.WriteLine("");
            continue;
        }
        typeName = typeName.Append(newType).ToArray();
        typeNum = typeNum.Append(0).ToArray();
        Console.WriteLine("");
    }
    else if (opt == 4) { //刪除項目 ok
        if (typeName.Length == 0 ) {
            Console.WriteLine("已無法再刪除支出項目");
            Console.WriteLine("");
            continue;
        }
        Console.Write("輸入項目名稱: ");
        string targetType = Console.ReadLine();
        if (!Array.Exists(typeName, x => x == targetType)) {
            Console.WriteLine("此項目不存在");
            Console.WriteLine("");
            continue;
        }
        int index = Array.IndexOf(typeName, targetType);
        outcome -= typeNum[index];
        //Console.WriteLine("{0} {1}", outcome, typeNum[index]);
        typeNum = typeNum.Where((val, idx) => idx != index).ToArray();
        typeName = typeName.Where((val, idx) => idx != index).ToArray();
        Console.WriteLine("");
    }
    else if (opt == 5) { //計算比例 ok
        for (int i = 0; i < typeName.Length; i++) {
            Console.WriteLine("({0}){1}: {2}%", i+1, typeName[i], (outcome != 0 ? (double)typeNum[i] / outcome * 100 : 0));
        }
        Console.WriteLine("");
    }
    else if (opt == 6) { //查詢支出
        Console.WriteLine("目前總支出: {0}", outcome);
        Console.Write("輸入項目名稱: ");
        string targetType = Console.ReadLine();
        if (!Array.Exists(typeName, x => x == targetType)) {
            Console.WriteLine("此項目不存在");
            Console.WriteLine("");
            continue;
        }
        int index = Array.IndexOf(typeName, targetType);
        Console.WriteLine("{0}: {1}", typeName[index], typeNum[index]);
        Console.WriteLine("");
    }
    else if (opt == 7) { //剩餘金額 ok
        Console.WriteLine("剩餘金額為: {0}", income - outcome);
        Console.WriteLine("");
    }
    else if (opt == 8) { //退出程式 ok
        Console.WriteLine("已成功退出 press any key to exit");
        Console.ReadKey();
        return;
    }
}