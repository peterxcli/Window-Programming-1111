using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_3_2
{
    public class Game
    {
        private List<int>[] stacks;
        
        public Game(string[] input)
        {
            stacks = new List<int>[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                stacks[i] = new List<int>();
                var arr = input[i].Split(' ');
                int k = stacks.Length;
                if (input[i] == "") continue;
                foreach (var s in arr) stacks[i].Add(int.Parse(s));
            }
        }

        public bool canPlace(int i)
        {
            if (stacks[i].Count < 4) return true;
            else return false;
        }

        public bool canTake(int i)
        {
            if (stacks[i].Count > 0) return true;
            else return false;
        }

        public void move(int i, int j)
        {
            int tmp = stacks[i].Last();
            stacks[i].RemoveAt(stacks[i].Count-1);
            stacks[j].Add(tmp);
        }

        public string output(int i)
        {
            string ret = "";
            foreach (var item in stacks[i]) ret += item.ToString();
            return ret;
        }
        public bool win()
        {
            string[] stacksSort = new string[stacks.Length];
            for (int i = 0; i < stacksSort.Length; i++) stacksSort[i] = output(i);
            Array.Sort(stacksSort);
            for (int i = 0; i < stacksSort.Length; i++)
            {
                if (stacksSort[i] == "") continue;
                if (stacksSort[i].Length != 3) return false;
                foreach (var s in stacksSort[i])
                {
                    if (int.Parse(s.ToString()) != i) return false;
                }
            }
            return true;
        }
    }
}
