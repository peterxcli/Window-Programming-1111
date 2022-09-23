Dictionary<string, Tuple<int, int, int> > dict = new Dictionary<string, Tuple<int, int, int> >();
string[,] curriculum = new string[15, 15]; //curriculum[section, week]

for (int i = 1; i <= 8; i++) for (int j = 1; j <= 7; j++) curriculum[i, j] = "";
string[] week_alias = new string[] {"", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

while (true) {
    Console.WriteLine("(1)add course (2)delete course (3)print curriculum (4)calculate score (5)exit program");
    Console.Write("enter number to select features:");
    int opt = int.Parse(Console.ReadLine());
    if (opt == 1) {
        Console.WriteLine("enter the course which you want to add, the format is <course-id week start-section end-section>");
        
        string course_id;
        int week, start_section, end_section;
        string tmp = Console.ReadLine();
        course_id = tmp.Substring(0, 5);
        week = int.Parse(tmp.Substring(6, 1)); start_section = int.Parse(tmp.Substring(8, 1)); end_section = int.Parse(tmp.Substring(10, 1));
        if (dict.ContainsKey(course_id)) {
            Console.WriteLine("course duplicate!!");
            Console.WriteLine();
            continue;
        }
        bool flag = false;
        for (int i = start_section; i <= end_section; i++) if (curriculum[i, week] != "") flag = true;
        if (flag) {
            Console.WriteLine("course conflict!!");
            Console.WriteLine();
            continue;
        }
        dict.Add(course_id, new Tuple<int, int, int>(week, start_section, end_section));
        for (int i = start_section; i <= end_section; i++) curriculum[i, week] = course_id;
        Console.WriteLine("course added successfully!!");
        Console.WriteLine();
    }
    else if (opt == 2) {
        Console.Write("enter the course-id which you want to remove: ");
        string course_id = Console.ReadLine();
        if (!dict.ContainsKey(course_id)) {
            Console.WriteLine("course not exist!!");
            Console.WriteLine();
            continue;
        }
        var tmp = dict[course_id];
        int week = tmp.Item1, start_section = tmp.Item2, end_section = tmp.Item3;
        for (int i = start_section; i <= end_section; i++) curriculum[i, week] = "";
        dict.Remove(course_id);
        Console.WriteLine("course :{0} removed successfully!!", course_id);
        Console.WriteLine();
    }
    else if (opt == 3) {
        for (int i = 0; i < 8; i++) Console.Write(String.Format("{0, -6}", week_alias[i]));
        Console.WriteLine();
        for (int i = 1; i <= 8; i++) {
            Console.Write(String.Format("{0, -6}", i.ToString()));
            Console.Write(String.Format("{0, -6}", curriculum[i, 7]));
            for (int j = 1; j <= 6; j++) Console.Write(String.Format("{0, -6}", curriculum[i, j]));
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    else if (opt == 4) {
        int ret = 0;
        foreach(var x in dict) {
            ret += x.Value.Item3 - x.Value.Item2 + 1;
        }
        Console.WriteLine(ret);
        Console.WriteLine();
    }
    else if (opt == 5) {
        Console.WriteLine("已成功退出 press any key to exit");
        Console.ReadKey();
        return;
    }
}   
