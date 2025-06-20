using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4];

            // カードの番号を4回入力
            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    Console.Write($"{i + 1}番目のカードを入力してください (1～4): ");
                    string inputStr = Console.ReadLine();

                    // 数値チェック
                    if (!int.TryParse(inputStr, out int input))
                    {
                        Console.WriteLine("⚠ エラー: 数値を入力してください。");
                        continue;
                    }

                    // 範囲チェック
                    if (input < 1 || input > 4)
                    {
                        Console.WriteLine("⚠ エラー: 1～4の範囲で入力してください。");
                        continue;
                    }

                    // OKなら格納して次へ
                    num[i] = input;
                    break;
                }
            }

            // 結果表示（任意）
            Console.WriteLine("入力されたカード番号:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i + 1}枚目: {num[i]}");
            }

        }
    }
}
