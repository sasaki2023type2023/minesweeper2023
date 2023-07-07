using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cell;

namespace Minesweeper
{
    internal class Cell
    {
    }
}
{
 class cell : PictureBox
{
    /// <summary>
    /// <セルの状態>
    /// </summary>
    public enum mode
    {

        ///<summary>
        ///正体_空白0
        ///</summary>
        ans_blank0 = 0,

        ///<summary>
        ///正体_空白1
        ///</summary>
        ans_blank1 = 1,

        ///<summary>
        ///正体_空白2
        ///</summary>
        ans_blank2 = 2,

        ///<summary>
        ///正体_空白3
        ///</summary>
        ans_blank3 = 3,

        ///<summary>
        ///正体_空白4
        ///</summary>
        ans_blank4 = 4,

        ///<summary>
        ///正体_空白5
        ///</summary>
        ans_blank5 = 5,

        ///<summary>
        ///正体_空白6
        ///</summary>
        ans_blank6 = 6,

        ///<summary>
        ///正体_空白7
        ///</summary>
        ans_blank7 = 7,

        ///<summary>
        ///正体_空白8
        ///</summary>
        ans_blank8 = 8,

        ///<summary>
        ///正体_爆弾
        ///</summary>
        ans_mine = 9,

        ///<summary>
        ///正体_爆弾処理失敗
        ///</summary>
        ans_minex = 10,

        ///<summary>
        ///ボタン_空白
        ///</summary>
        btn_blank = 11,

        ///<summary>
        ///ボタン_旗
        ///</summary>
        btn_flag = 12,

        ///<summary>
        ///ボタン_検討
        ///</summary>
        btn_hold = 13,

        ///<summary>
        ///ボタン_旗不正
        ///</summary>
        btn_flagx = 22,

        ///<summary>
        ///正体_空白
        ///</summary>
        btn_holdx = 23,

    }

    ///<summary>
    ///正体
    ///</summary>
    public mode Ans { get; get; }
    private mode _thisMode;

    ///<summary>
    ///現在の状態
    ///</summary>

    public mode ThisMode
    {
        get => _thisMode;
        set
        {

            _thisMode = value;

            ChangeImg(value);
        }

    }

    public Point Point { get; }

    private Dictionary<Point, cell> CellList;

    /// <summary>
    ///  コンストラクタ
    ///</summary>>
    ///
    ///<param name ="point"></param>
    ///<param name ="cellList"></param>
    
    public cell(Point point, Dictionary<Point, Cell> cellList)

    {

        Point = 

    }

    

    























    }

break;
case Mode.ans_blank1:
    BackgroundImage = Properties.Resources.ans_blank1;
    break;

    break;
case Mode.ans_blank2:
    BackgroundImage = Properties.Resources.ans_blank2;
    break;

    break;
case Mode.ans_blank3:
    BackgroundImage = Properties.Resources.ans_blank3;
    break;

    break;
case Mode.ans_blank4:
    BackgroundImage = Properties.Resources.ans_blank4;
    break;

    break;
case Mode.ans_blank5:
    BackgroundImage = Properties.Resources.ans_blank5;
    break;

    break;
case Mode.ans_blank6:
    BackgroundImage = Properties.Resources.ans_blank6;

    break;
case Mode.ans_blank7:
    BackgroundImage = Properties.Resources.ans_blank7;
    break;

    break;
case Mode.ans_blank8:
    BackgroundImage = Properties.Resources.ans_blank8;
    break;

    break;
case Mode.ans_mine:
    BackgroundImage = Properties.Resources.ans_mine;
    break;

    break;
case Mode.ans_mineX:
    BackgroundImage = Properties.Resources.ans_mineX;
    break;

    break;
case Mode.btn_blank:
    BackgroundImage = Properties.Resources.btn_blank ;
    break;

    break;
case Mode.btn_flag:
    BackgroundImage = Properties.Resources.btn_flag;
    break;

    break;
case Mode.btn_hold:
    BackgroundImage = Properties.Resources.btn_hold;
    break;

    break;
case Mode.btn_flagX:
    BackgroundImage = Properties.Resources.btn_flagX;
    break;

case Mode.btn_holdX:
    BackgroundImage = Properties.Resources.btn_holdx;
    break;

    break;

    break;

}
 }

