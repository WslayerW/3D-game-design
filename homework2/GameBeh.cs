using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBeh : MonoBehaviour
{
    private int [,] board = new int [3,3];//棋盘，0、1、2分别代表空、玩家1占据、玩家2占据
    private int turn = 0;//用来表示落子顺序
    private int square_size = Screen.width / 10;//一个格子的尺寸
    private int menu_width = Screen.width / 5, menu_height = Screen.width / 10;//主菜单每一个按键的宽度和高度
    private int mode = 0;//根据不同mode显示不同场景
    /*
    0 主菜单
    1 玩家VS玩家
    2 玩家VS人机
    */
    private GUIStyle bigStyle, blackStyle;//自定义字体格式
    public Texture2D empty, icon1, icon2;//不同玩家的图标（圈和叉）


    //Unity初始化整体框架
    void Start()
    {

        //大字体初始化
        bigStyle = new GUIStyle();
        bigStyle.normal.textColor = Color.white;
        bigStyle.normal.background = null;
        bigStyle.fontSize = 50;

        //black
        blackStyle = new GUIStyle();
        blackStyle.normal.textColor = Color.black;
        blackStyle.normal.background = null;
        blackStyle.fontSize = 30;

    }

    // Update函数，做过测试在该例程中删除好像完全没有影响
    void Update()
    {
       
    }

    void OnGUI() {
        switch(mode) {
            case 0:
                mainMenu();
                break;
            case 1:
                playerVsPlayer();
                break;
           
        }       
    }
    void mainMenu() {
        GUI.Label(new Rect(Screen.width / 2 - menu_width * 0.8f, Screen.height * 0.1f, menu_width, menu_height), "Main Menu", bigStyle);
        if (GUI.Button(new Rect(Screen.width / 2 - menu_width * 1/2, Screen.height / 4, menu_width, menu_height), "Start")) {
            mode = 1;
        }
    }
    int checkStateWithoutOutput() {
        int res = -1;
        //检查游戏结果是否已经产生

        //检查横向结果
        for (int i = 0; i < 3; ++i) {
            if (board[i,0] != 0 && board[i,0] == board[i,1] && board[i,0] == board[i,2]) {
                res = board[i,0];
                break;
            }
        }
        //未结束，继续检查纵向结果
        if (res == -1)
            for (int j = 0; j < 3; ++j) {
                if (board[0,j] != 0 && board[0,j] == board[1,j] && board[0,j] == board[2,j]) {
                    res = board[0,j];
                    break;
                }
            }
        //未结束，继续检查斜向结果
        if (res == -1)
            if (board[1,1] != 0 && (board[0,0] == board[1,1] && board[1,1] == board[2,2] || board[0,2] == board[1,1] && board[2,0] == board[1,1])) {
                res = board[1,1];
            }
        //未结束，检查是否仍有空位
        if (res == -1) {
            int cnt = 0;
            for (int i = 0; i < 3; ++i) {
                for (int j = 0; j < 3; ++j){
                    if (board[i,j] == 0) {
                        cnt++;
                        break;
                    }
                }
            }
            if (cnt == 0) {
                res = 3;
            }
        }
        if (res == -1) return 0;
        return res;
    }
    void checkState() {
        int res = checkStateWithoutOutput();
        //根据不同res对应不同操作
        if (res == 0) return ;//没有什么特殊状态
        if (res == 1) {//玩家一胜利
            if (mode == 1) {
                GUI.Label(new Rect(0, Screen.height / 2, square_size * 1.5f, square_size * 0.8f), "Player 1 wins!", blackStyle);

            }

        }
        else if (res == 2) {//玩家二或人机胜利
            if (mode == 1) {
                GUI.Label(new Rect(0, Screen.height / 2, square_size * 1.5f, square_size * 0.8f), "Player 2 wins!", blackStyle);
            }
        }
            
        
        else if (res == 3) {
            GUI.Label(new Rect(0, Screen.height / 2, square_size * 1.5f, square_size * 0.8f), "Draw!", blackStyle);
        }
        
    }

    void playerMove() {
        for (int i = 0; i < 3; ++i) {
            for (int j = 0; j < 3; ++j) {
                switch(board[i,j]) {//board[i,j]有三种状态，空、被玩家1占据、被玩家2占据
                    case 0:
                        if (GUI.Button(new Rect(Screen.width / 2 + (i - 1.5f) * square_size, Screen.height / 2 + (j - 1.5f)* square_size, square_size, square_size), empty)) {
                            //如果当前玩家选择了这个格子，则为此格子赋上代表玩家的值，在下一帧时这个格子上会显示相应的图标
                            board[i,j] = turn + 1;
                            turn = 1 - turn;
                            
                        }
                        break;
                    case 1:
                        GUI.Button(new Rect(Screen.width / 2 + (i - 1.5f) * square_size, Screen.height / 2 + (j - 1.5f) * square_size, square_size, square_size), icon1);
                        break;
                    case 2:
                        GUI.Button(new Rect(Screen.width / 2 + (i - 1.5f) * square_size, Screen.height / 2 + (j - 1.5f) * square_size, square_size, square_size), icon2);
                        break;
                }
            }
        }
        checkState();
        
        if (GUI.Button(new Rect(Screen.width - square_size , Screen.height - square_size * 0.7f, square_size, square_size * 0.7f), "Reset")) {
            reset();
        }
        if (GUI.Button(new Rect(0 , Screen.height - square_size * 0.7f, square_size * 1.6f, square_size * 0.7f), "Return to Menu")) {
            reset();
            mode = 0;
        }

    }

    void playerVsPlayer() {
        playerMove();
    }
    
    
    void reset() {
        for (int i = 0; i < 3; ++i) {
            for (int j = 0; j < 3; ++j) {
                board[i,j] = 0;
            }
        }
        turn = 0;
    }
}
