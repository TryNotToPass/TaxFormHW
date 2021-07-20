using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxFormHW
{
    public partial class TaxCnt : Form
    {
        #region 基礎設定
        public TaxCnt()
        {
            InitializeComponent();
        }

        private Point _startPoint;

        private void init() //初始化
        {
            radioButton1.Checked = true;
            this.cartype_cbx.SelectedIndex = 0;
            this.cc_cbx.SelectedIndex = 0;
            this.cc_cbx.Enabled = false;
            this.vScrollBar1.Maximum = this.lbl_ans.Text.Length;
            this.lbl_ans.Location = this._startPoint;
            this.lbl_ans.Text = String.Empty;
        }

        private void TaxCnt_Load(object sender, EventArgs e)
        {
            this._startPoint = this.lbl_ans.Location;
            init();
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            init();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.from_dtp.Visible = false;
                this.to_dtp.Visible = false;
                this.label1.Visible = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.from_dtp.Visible = true;
                this.to_dtp.Visible = true;
                this.label1.Visible = true;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.lbl_ans.Text = String.Empty; //洗白

            DateTime from_date = this.from_dtp.Value;
            DateTime to_date = this.to_dtp.Value;

            //測是否日期打反，打反則校正回歸
            if (YearCounter(from_date, to_date, 0) < 0)
            {
                this.from_dtp.Value = to_date;
                this.to_dtp.Value = from_date;
                from_date = this.from_dtp.Value;
                to_date = this.to_dtp.Value;
            }

            decimal dayofyear; //年計算的分母
            decimal taxperyear = GetTaxPerYear(); //取得年繳稅
            int subtract = to_date.Year - from_date.Year;

            if (radioButton2.Checked) //使用者想要自訂日期
            {
                decimal daycnt;
                if (subtract == 0) //處理不足一年
                {
                    daycnt = YearCounter(from_date, to_date, 0);//使用者自訂的天數，當天計算
                    if (DateTime.IsLeapYear(from_date.Year)) dayofyear = 366;
                    else dayofyear = 365;

                    this.lbl_ans.Text += $"使用期間: {from_date.ToString("yyyy-MM-dd")} → {to_date.ToString("yyyy-MM-dd")}" +
                    $"\n計算天數: {daycnt}" +
                    $"\n汽缸CC數/馬力: {this.cc_cbx.Text}" +
                    $"\n用途: {this.cartype_cbx.Text}" +
                    $"\n計算公式: {taxperyear} * {daycnt}/{dayofyear}" +
                    $"\n應納稅額: {Math.Truncate(taxperyear * (daycnt / dayofyear))} 元";
                }
                else //使用者自訂很多年
                {
                    
                    decimal total = 0;
                    for (int i = 0; i < subtract+1; i++)
                    {
                        decimal tax_ans;
                        if (i == 0)//第一條不一定是一整年
                        {
                            if (DateTime.IsLeapYear(from_date.Year)) dayofyear = 366;
                            else dayofyear = 365;
                            decimal temp = YearCounter(from_date, new DateTime(from_date.Year + 1, 1, 1), 0);
                            tax_ans = Math.Truncate(taxperyear * (temp / dayofyear));
                            total += tax_ans;
                            this.lbl_ans.Text += $"使用期間: {from_date.ToString("yyyy-MM-dd")} → {from_date.Year}-12-31" +
                            $"\n計算天數: {temp}" +
                            $"\n汽缸CC數/馬力: {this.cc_cbx.Text}" +
                            $"\n用途: {this.cartype_cbx.Text}" +
                            $"\n計算公式: {taxperyear} * {temp}/{dayofyear}" +
                            $"\n應納稅額: {tax_ans} 元";
                        }
                        else if (i == (subtract)) //最後一條
                        {
                            if (DateTime.IsLeapYear(to_date.Year)) dayofyear = 366;
                            else dayofyear = 365;
                            daycnt = YearCounter(new DateTime(to_date.Year, 1, 1), to_date, 0);//使用者自訂的天數
                            tax_ans = Math.Truncate(taxperyear * (daycnt / dayofyear));
                            total += tax_ans;
                            this.lbl_ans.Text += $"\n\n使用期間: {to_date.Year}-1-1 → {to_date.ToString("yyyy-MM-dd")}" +
                            $"\n計算天數: {daycnt}" +
                            $"\n汽缸CC數/馬力: {this.cc_cbx.Text}" +
                            $"\n用途: {this.cartype_cbx.Text}" +
                            $"\n計算公式: {taxperyear} * {daycnt}/{dayofyear}" +
                            $"\n應納稅額: {tax_ans} 元";
                        }
                        else
                        {
                            if (DateTime.IsLeapYear(from_date.Year + i)) dayofyear = 366;
                            else dayofyear = 365;
                            total += taxperyear;
                            this.lbl_ans.Text += $"\n\n使用期間: {from_date.Year + i}-1-1 → {from_date.Year + i}-12-31" +
                            $"\n計算天數: {dayofyear}" +
                            $"\n汽缸CC數/馬力: {this.cc_cbx.Text}" +
                            $"\n用途: {this.cartype_cbx.Text}" +
                            $"\n計算公式: {taxperyear} * {dayofyear}/{dayofyear}" +
                            $"\n應納稅額: {taxperyear} 元";
                        }
                    }
                    if (subtract > 0) this.lbl_ans.Text += $"\n\n全部應納稅額: 共 {total} 元";
                }
            }
            else //使用者使用全年度
            {
                if (DateTime.IsLeapYear(from_date.Year)) dayofyear = 366;
                else dayofyear = 365;

                this.lbl_ans.Text = $"使用期間: {DateTime.Now.ToString("yyyy")}-01-01 → {DateTime.Now.ToString("yyyy")}-12-31" +
                $"\n計算天數: {dayofyear}" +
                $"\n汽缸CC數/馬力: {this.cc_cbx.Text}" +
                $"\n用途: {this.cartype_cbx.Text}" +
                $"\n計算公式: {taxperyear} * {dayofyear}/{dayofyear}" +
                $"\n應納稅額: {taxperyear} 元";
            }
            this.vScrollBar1.Maximum = this.lbl_ans.Text.Length*5/3;

        }

        #region 方法集

        private void cartype_cbx_SelectedIndexChanged(object sender, EventArgs e) //更新表單
        {
            string carType = this.cartype_cbx.Text;
            string elect = "馬力";
            string oil = "汽缸CC數";
            if (carType.Contains("電動")) this.label3.Text = elect;
            else this.label3.Text = oil;

            this.cc_cbx.Enabled = true;
            this.cc_cbx.Items.Clear();
            switch (carType)
            {
                case "機車":
                    this.cc_cbx.Items.AddRange(new String[] {"150以下","150~250","251~500","501~600","601~1200","1201~1800","1801或以上"});
                    break;
                case "貨車":
                    this.cc_cbx.Items.AddRange(new String[] { "500以下", "501~600", "601~1200", "1201~1800", "1801~2400"
                    , "2401~3000", "3001~3600","3601~4200", "4200~4800", "4801~5400", "5401~6000","6001~6600", "6601~7200"
                    , "7201~7800", "7801~8400", "8401~9000", "9001~9600", "9601~10200", "10201以上"});
                    break;
                case "大客車":
                    this.cc_cbx.Items.AddRange(new String[] { "600以下", "601~1200", "1201~1800", "1801~2400"
                    , "2401~3000", "3001~3600","3601~4200", "4200~4800", "4801~5400", "5401~6000","6001~6600", "6601~7200"
                    , "7201~7800", "7801~8400", "8401~9000", "9001~9600", "9601~10200", "10201以上"});
                    break;
                case "自用小客車":
                    this.cc_cbx.Items.AddRange(new String[] { "500以下", "501~600", "601~1200", "1201~1800", "1801~2400", "2401~3000"
                    , "3001~4200", "4200~5400", "5401~6600", "6601~7800", "7801以上"});
                    break;
                case "營業用小客車":
                    this.cc_cbx.Items.AddRange(new String[] { "500以下", "501~600", "601~1200", "1201~1800", "1801~2400", "2401~3000"
                    , "3001~4200", "4200~5400", "5401~6600", "6601~7800", "7801以上"});
                    break;
                case "自用電動小客車":
                    this.cc_cbx.Items.AddRange(new String[] { "38.6PS以下", "38.7-56.8PS", "56.9-84.2PS", "84.3-184.7PS", "184.8-265.9PS", "266.0-326.8PS"
                    , "326.9-420.2PS", "420.3-476.0PS", "476.1-516.6PS", "516.7PS以上"});
                    break;
                case "營業電動小客車":
                    this.cc_cbx.Items.AddRange(new String[] { "38.6PS以下", "38.7-56.8PS", "56.9-84.2PS", "84.3-184.7PS", "184.8-265.9PS", "266.0-326.8PS"
                    , "326.9-420.2PS", "420.3-476.0PS", "476.1-516.6PS", "516.7PS以上"});
                    break;
                case "電動機車":
                    this.cc_cbx.Items.AddRange(new String[] { "21.54PS以下", "21.55-42.71PS", "42.72-53.43PS", "53.44-62.73PS", "62.74-121.76PS", "121.77PS以上" });
                    break;                
                case "電動貨車/大客車":
                    this.cc_cbx.Items.AddRange(new String[] { "140.1PS以下", "140.2-203PS", "203.1-250.7PS", "250.8-290.3PS", "290.4-341PS", "341.1-366.4PS", "366.5PS以上" });
                    break;
            }
            this.cc_cbx.SelectedIndex = 0;
        }

        private decimal GetTaxPerYear() //獲取年繳稅金
        {
            if (this.cartype_cbx.SelectedIndex == -1) return 0;

            int ct_index = this.cc_cbx.SelectedIndex;
            string carType = this.cartype_cbx.Text;
            string ccType = this.cc_cbx.Text;

            decimal taxperyear = 0;

            switch (carType)
            {
                case "機車":
                    switch (ccType) 
                    {
                        case "150~250":
                            taxperyear = 800;
                            break;
                        case "251~500":
                            taxperyear = 1620;
                            break;
                        case "501~600":
                            taxperyear = 2160;
                            break;
                        case "601~1200":
                            taxperyear = 4320;
                            break;
                        case "1201~1800":
                            taxperyear = 7120;
                            break;
                        case "1801或以上":
                            taxperyear = 11230;
                            break;
                    }
                    break;                
                case "貨車":
                    switch (ccType)
                    {
                        case "500以下":
                            taxperyear = 900;
                            break;
                        case "501~600":
                            taxperyear = 1080;
                            break;
                        case "601~1200":
                            taxperyear = 1800;
                            break;
                        default:
                            ct_index -=2;
                            taxperyear = 1800 + 900 * ct_index;
                            break;
                    }
                    break;                
                case "大客車":
                    switch (ccType)
                    {
                        case "600以下":
                            taxperyear = 1080;
                            break;
                        case "601~1200":
                            taxperyear = 1800;
                            break;
                        default:
                            ct_index -= 1;
                            taxperyear = 1800 + 900 * ct_index;
                            break;
                    }
                    break;                
                case "自用小客車":
                    switch (ccType)
                    {
                        case "500以下":
                            taxperyear = 1620;
                            break;
                        case "501~600":
                            taxperyear = 2160;
                            break;
                        case "601~1200":
                            taxperyear = 4320;
                            break;
                        case "1201~1800":
                            taxperyear = 7120;
                            break;
                        case "1801~2400":
                            taxperyear = 11230;
                            break;
                        case "2401~3000":
                            taxperyear = 15210;
                            break;
                        case "3001~4200":
                            taxperyear = 28220;
                            break;
                        case "4201~5400":
                            taxperyear = 46170;
                            break;
                        case "5401~6600":
                            taxperyear = 69690;
                            break;
                        case "6601~7800":
                            taxperyear = 117000;
                            break;
                        case "7801以上":
                            taxperyear = 151200;
                            break;
                        default:
                            taxperyear = 1620;
                            break;
                    }
                    break;                
                case "營業用小客車":
                    switch (ccType)
                    {
                        case "500以下":
                            taxperyear = 900;
                            break;
                        case "501~600":
                            taxperyear = 1260;
                            break;
                        case "601~1200":
                            taxperyear = 2160;
                            break;
                        case "1201~1800":
                            taxperyear = 3060;
                            break;
                        case "1801~2400":
                            taxperyear = 6480;
                            break;
                        case "2401~3000":
                            taxperyear = 9900;
                            break;
                        case "3001~4200":
                            taxperyear = 16380;
                            break;
                        case "4201~5400":
                            taxperyear = 24300;
                            break;
                        case "5401~6600":
                            taxperyear = 33660;
                            break;
                        case "6601~7800":
                            taxperyear = 44460;
                            break;
                        case "7801以上":
                            taxperyear = 56700;
                            break;
                        default:
                            taxperyear = 900;
                            break;
                    }
                    break;
                case "自用電動小客車":
                    switch (ccType)
                    {
                        case "38.6PS以下":
                            taxperyear = 1620;
                            break;
                        case "38.7-56.8PS":
                            taxperyear = 2160;
                            break;
                        case "56.9-84.2PS":
                            taxperyear = 4320;
                            break;
                        case "84.3-184.7PS":
                            taxperyear = 7120;
                            break;
                        case "184.8-265.9PS":
                            taxperyear = 11230;
                            break;
                        case "266.0-326.8PS":
                            taxperyear = 15210;
                            break;
                        case "326.9-420.2PS":
                            taxperyear = 28220;
                            break;
                        case "420.3-476.0PS":
                            taxperyear = 46170;
                            break;
                        case "476.1-516.6PS":
                            taxperyear = 69690;
                            break;
                        case "516.7PS以上":
                            taxperyear = 117000;
                            break;
                    }
                    break;
                case "營業電動小客車":
                    switch (ccType)
                    {
                        case "38.6PS以下":
                            taxperyear = 900;
                            break;
                        case "38.7-56.8PS":
                            taxperyear = 1260;
                            break;
                        case "56.9-84.2PS":
                            taxperyear = 2160;
                            break;
                        case "84.3-184.7PS":
                            taxperyear = 3060;
                            break;
                        case "184.8-265.9PS":
                            taxperyear = 6480;
                            break;
                        case "266.0-326.8PS":
                            taxperyear = 9900;
                            break;
                        case "326.9-420.2PS":
                            taxperyear = 16380;
                            break;
                        case "420.3-476.0PS":
                            taxperyear = 24300;
                            break;
                        case "476.1-516.6PS":
                            taxperyear = 33660;
                            break;
                        case "516.7PS以上":
                            taxperyear = 44460;
                            break;
                    }
                    break;
                case "電動機車":
                    switch (ccType)
                    {
                        case "21.55-42.71PS":
                            taxperyear = 800;
                            break;
                        case "42.72-53.43PS":
                            taxperyear = 1620;
                            break;
                        case "53.44-62.73PS":
                            taxperyear = 2160;
                            break;
                        case "62.74-121.76PS":
                            taxperyear = 4320;
                            break;
                        case "121.77PS以上":
                            taxperyear = 7120;
                            break;
                    }
                    break;
                case "電動貨車/大客車":
                    switch (ccType)
                    {
                        case "140.1PS以下":
                            taxperyear = 4500;
                            break;
                        case "140.2-203PS":
                            taxperyear = 6300;
                            break;
                        case "203.1-250.7PS":
                            taxperyear = 8100;
                            break;
                        case "250.8-290.3PS":
                            taxperyear = 9900;
                            break;
                        case "290.4-341PS":
                            taxperyear = 11700;
                            break;
                        case "341.1-366.4PS":
                            taxperyear = 13500;
                            break;
                        case "366.5PS以上":
                            taxperyear = 15300;
                            break;
                    }
                    break;

                default:
                    break;
            }
            return taxperyear;
            #region nitendo switch 數值集合
            //機車
            //貨車
            //大客車
            //自用小客車
            //營業用小客車
            //自用電動小客車
            //營業電動小客車
            //電動機車
            //電動貨車/大客車
            #endregion
        }

        private decimal YearCounter(DateTime fromD, DateTime toD, int type) //日數計算機，參數0,1
        {
            decimal result = 0;
            if (type == 0) //單純算兩日期日數
            {
                TimeSpan days = new TimeSpan(toD.Ticks - fromD.Ticks);
                result = days.Days+1;
            }
            if (type == 1) //只看年算總日數
            {
                DateTime from = new DateTime(fromD.Year, 1, 1);
                DateTime to = new DateTime(toD.Year, 12, 31);
                TimeSpan days = new TimeSpan(to.Ticks - from.Ticks);
                result = days.Days+1;
            }
            return result;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e) //下拉把
        {
            var newPoint = new Point(
            this.lbl_ans.Location.X,
            this._startPoint.Y - this.vScrollBar1.Value);
            this.lbl_ans.Location = newPoint;
        }
        #endregion


    }
}
