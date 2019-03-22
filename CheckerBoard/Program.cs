using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckerBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            // 选手A每轮投掷数
            int iResultA = 0;
            // 选手A总投掷数
            int totalResultA = 0;

            // 选手B每轮投掷数
            int iResultB = 0;
            // 选手B总投掷数
            int totalResultB = 0;

            // 骰子最大最小数
            int minData = 1;
            int maxData = 7;

            //最大投掷次数
            const int maxThrowTimes = 100;

            // 最大棋盘数字
            const int maxCheckerBoardData = 100;

            // 定义随机生成数类
            Random randData = new Random();

            // 循环投掷
            for (int iTime = 0; iTime < maxThrowTimes; iTime++)
            {
                //选手A投掷
                iResultA = randData.Next(minData,maxData);
                totalResultA += iResultA;
                String outStringA = "PlayerA-第" + Convert.ToString(iTime + 1) + "次投掷:" + iResultA;
                System.Console.WriteLine(outStringA);

                //选手B投掷
                iResultB = randData.Next(minData,maxData);
                totalResultB += iResultB;
                String outStringB = "PlayerB-第" + Convert.ToString(iTime+1) + "次投掷:" + iResultB;
                System.Console.WriteLine(outStringB);

                if (totalResultA > maxCheckerBoardData || totalResultB > maxCheckerBoardData)
                {
                    break;
                }
            }

            System.Console.WriteLine("PlayerA总数："+totalResultA);
            System.Console.WriteLine("PlayerB总数："+totalResultB);

            // 判断结果
            if (totalResultA>100)
	        {
		        System.Console.WriteLine("Winner:PlayerA");
	        }
            else
            {
                System.Console.WriteLine("Winner:PlayerB");
            }
          

        }
    }
}
