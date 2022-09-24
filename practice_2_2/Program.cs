char[, ] grid = new char[9, 9];

int player_X = 0, player_O = 0;
bool flag = false; //true : X, false : O

for (int i = 1; i <= 8; i++) 
    for (int j = 1; j <= 8; j++)
        grid[i, j] = '-'; 

void print() {
    Console.Write(String.Format("{0, -2}", ""));
    for (int i = 0; i < 8; i++) Console.Write(String.Format("{0, -2}", (char)('A'+i)));
    Console.WriteLine();
    for (int i = 1; i <= 8; i++) {
        Console.Write(String.Format("{0, -2}", i.ToString()));
        for (int j = 1; j <= 8; j++) {
            Console.Write(String.Format("{0, -2}", grid[i, j]));
        }
        Console.WriteLine();
    }
}

char getCurrentPlayer() {
    return (flag ? 'X' : 'O'); 
}

char getAgainstPlayer() {
    return (!flag ? 'X' : 'O'); 
}

void minusAgainstAndAddCurrentPlayer() {
    if (flag) {player_X--; player_O++;}
    else {player_O--; player_X++;}
}

void process_right(int i, int j) {
    int endRow = 0, endCol = 0;
    for (int col = j+1; col <= 8; col++) {
        if (grid[i, col] == getCurrentPlayer()) {
            endCol = col;
            endRow = i;
        }
    }
    if (endCol == 0 || endRow == 0) return;
    for (int col = j+1; col <= endCol -1; col++) {
        if (grid[i, col] == getAgainstPlayer()) {
            grid[i, col] = getCurrentPlayer();
            minusAgainstAndAddCurrentPlayer();
        }
    }
}

void process_down(int i, int j) {
    int endRow = 0, endCol = 0;
    for (int row = i+1; row <= 8; row++) {
        if (grid[row, j] == getCurrentPlayer()) {
            endCol = j;
            endRow = row;
        }
    }
    if (endCol == 0 || endRow == 0) return;
    for (int row = i+1; row <= endRow - 1; row++) {
        if (grid[row, j] == getAgainstPlayer()) {
            grid[row, j] = getCurrentPlayer();
            minusAgainstAndAddCurrentPlayer();
        }
    }
}

void process_left(int i, int j) {
    int endRow = 0, endCol = 0;
    for (int col = j-1; col >= 1; col--) {
        if (grid[i, col] == getCurrentPlayer()) {
            endCol = col;
            endRow = i;
        }
    }
    if (endCol == 0 || endRow == 0) return;
    for (int col = j-1; col >= endCol + 1; col--) {
        if (grid[i, col] == getAgainstPlayer()) {
            grid[i, col] = getCurrentPlayer();
            minusAgainstAndAddCurrentPlayer();
        }
    }
}

void process_up(int i, int j) {
    int endRow = 0, endCol = 0;
    for (int row = i-1; row >= 1; row--) {
        if (grid[row, j] == getCurrentPlayer()) {
            endCol = j;
            endRow = row;
        }
    }
    if (endCol == 0 || endRow == 0) return;
    for (int row = i-1; row >= endRow + 1; row--) {
        if (grid[row, j] == getAgainstPlayer()) {
            grid[row, j] = getCurrentPlayer();
            minusAgainstAndAddCurrentPlayer();
        }
    }
}

Console.Clear();

while (player_O + player_X < 64) {
    print();
    Console.WriteLine("玩家 O 有 {0} 顆棋子 玩家 X 有 {1} 顆棋子", player_O, player_X);
    Console.WriteLine("輪到玩家{0} 請輸入要下的位置", (flag ? 'X' : 'O'));
    string pos = Console.ReadLine();
    int row = pos[1] - '0', col = pos[0] - 'A' + 1;
    if (grid[row, col] != '-') {
        Console.WriteLine("此位子已有棋子 按任意鍵繼續");
        Console.ReadKey();
        Console.Clear();
        continue;
    }
    //Console.WriteLine("row: {0}, col: {1}", row, col);
    grid[row, col] = (flag ? 'X' : 'O');
    if(flag)player_X++; else player_O++;
    process_right(row, col);
    Console.Clear();
    flag = !flag;
}

Console.WriteLine("遊戲結束, 玩家{0}獲勝", (player_O > player_X ? 'O' : "X"));