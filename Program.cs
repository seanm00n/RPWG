using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPWG {
    static class Program {
        //RPWG v1.0
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RPWG());
        }
        public static string RandGen() {
            
            string[] strA = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] strB = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] strC = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] strD = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };
            string password = "";

            password += GetElement(strA, 3);
            password += GetElement(strB, 3);
            password += GetElement(strC, 3);
            password += GetElement(strD, 3);

            return Shuffle(password);
        }
        public static string GetElement(string[] str, int len) {
            int index01;
            string result = "";
            int randN;
            string[] temp = new string[len];
            for (index01 = 0; index01 < len; index01++) {
                Random rand = new Random(Guid.NewGuid().GetHashCode());//thx!
                do {
                    randN = rand.Next(0, str.Length);
                    temp[index01] = str[randN];
                } while (CheckOverlap(str, str[randN]));
                    result += temp[index01];
            }
            return result;
        }
        public static bool CheckOverlap(string[] str, string element) {
            for (int index01 = 0; index01 < str.Length; index01++) {
                if (str[index01] == element) {
                    return false;
                }
            }
            return true;
        }
        public static string Shuffle(string str) {//index<->rand index (swap)
            char[] result = str.ToCharArray();
            char temp;
            int index01;
            for (index01 = 0; index01 < str.Length; index01 ++) {
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                int randN = rand.Next(0, str.Length);
                temp = result[randN];
                result[randN] = result[index01];
                result[index01] = temp;
            }
            return new string(result);
        }
    }
}
