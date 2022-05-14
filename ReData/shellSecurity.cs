using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ReData
{
    public class shellSecurity
    {
        #region hideInfo

        // lucipher code
        private static int[] PblockChanges = { 0, 8, 13, 5, 9, 1, 15, 4, 3, 12, 2, 14, 7, 6, 10, 11 };
        public static BitArray[] InputSbox = new BitArray[] {
            new BitArray(new bool[3] { false, false, false }),
            new BitArray(new bool[3] { false, false, true }),
            new BitArray(new bool[3] { false, true, false }),
            new BitArray(new bool[3] { false, true, true }),
            new BitArray(new bool[3] { true, false, false }),
            new BitArray(new bool[3] { true, false, true }),
            new BitArray(new bool[3] { true, true, false }),
            new BitArray(new bool[3] { true, true, true }),
        };
        public static BitArray[] OutputSbox = new BitArray[] {
            new BitArray(new bool[3] { false, true, true }),
            new BitArray(new bool[3] { true, true, true }),
            new BitArray(new bool[3] { false, false, false }),
            new BitArray(new bool[3] { true, true, false }),
            new BitArray(new bool[3] { false, true, false }),
            new BitArray(new bool[3] { true, false, false }),
            new BitArray(new bool[3] { true, false, true }),
            new BitArray(new bool[3] { false, false, true }),
        };
         private static bool[] Pbox(BitArray mess, int[] PblockChanges, bool reverse)
        {
            bool[] res = new bool[mess.Length];
            for (int i = 0; i < mess.Length; i++)
            {
                if (!reverse)
                {
                    res[PblockChanges[i]] = mess[i];
                }
                else
                {
                    res[i] = mess[PblockChanges[i]];
                }
            }
            return res;

        }
        private static bool Check(BitArray temp, BitArray input)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != input[i])
                    return false;
            }
            return true;
        }
        private static bool[] Sbox(BitArray mess, bool reverse)
        {
            bool[] res = new bool[mess.Length];
            res[0] = mess[0]; 
            for (int i = 1; i < mess.Length-1; i+=3)
            {
                BitArray temp = new BitArray(new bool[3] { mess[i], mess[i+1], mess[i + 2] });
                for (int j = 0; j < InputSbox.Length; j++)
                {
                    if (Check(temp, reverse? OutputSbox[j]:InputSbox[j]))
                    {
                        temp = reverse ? OutputSbox[j]: InputSbox[j];
                        break;
                    }

                }
                temp.CopyTo(res, i);
            }
            return res;
        }
        
        private static byte[] Encrypt(byte[] byteMessage, bool reverse)
        {
            byte[] result = new byte[byteMessage.Length];
            for (int i = 0; i < byteMessage.Length - 1; i+=2)
            {   
                BitArray mess = new BitArray(new byte[2] {byteMessage[i], byteMessage[i + 1] });
                for (int j = 0; j < 6; j++)
                {
                    mess = new BitArray(Pbox(mess, PblockChanges, reverse));
                    mess = new BitArray(Sbox(mess, reverse));
                }
                mess = new BitArray(Pbox(mess, PblockChanges, reverse));
                mess.CopyTo(result, i); 
            }
            return result;
        }
        
        #endregion

        #region Regestry

        private int _iRegestry(int viI, string sS, string sS1)
        {
            sS = @"Software\" + sS + @"\" + sS1;
            Microsoft.Win32.RegistryKey clRegistryKey;
            if (viI == 0)
            {
                clRegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(sS);
                if (clRegistryKey == null)
                {
                    clRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(sS);
                }
            }
            else
            {
                clRegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(sS, true);
            }
            //К этому времени раздел должен быть
            if (clRegistryKey != null)
            {
                if (viI == 0)
                {
                    //Есть ли параметры в разделе
                    string[] sKeyNames = clRegistryKey.GetValueNames();
                    if (sKeyNames.Length != 0)
                    {  
                        var temp =clRegistryKey.GetValue("isFirstStart");
                        clRegistryKey.Close();
                        return 0;
                    }
                    else
                    {
                        clRegistryKey.SetValue("isFirstStart", false);
                        clRegistryKey.Close();
                        return 0;
                    }
                }
                else
                {
                    try
                    {
                        clRegistryKey.SetValue("isFirstStart", false);
                        clRegistryKey.Close();
                    }
                    catch (Exception)
                    {
                        //Ошибка работы с реестром
                        return 1;

                    } //try catch

                    return 0;
                }
            }
            return 1;
        }


        #endregion
        public shellSecurity()
        {
            
            string line = "";
            StreamReader sr = new StreamReader("config.conf");
            while (!sr.EndOfStream)
                line += sr.ReadLine();
            sr.Close();
            if (!getInfo(line))
            {
                MessageBox.Show("хаха");
            }

        }

        private bool IsFirstStart()
        {
            
        }

        private bool getInfo(string line)
        {
            bool answer = true;
            int count = Decoder(line);
            if (count < 10)
            {
                count++;
            }
            else
            {
                MessageBox.Show("Использование программы прекращенно",
                    caption:"Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                answer = false;
            }
            using (StreamWriter sr = new StreamWriter("config.conf"))
            {
                byte[] newStart = Encoding.UTF8.GetBytes(Convert.ToString(count));
                string newline = Encoding.UTF8.GetString(Encrypt(newStart, false));
                sr.WriteLine(newline);
            }

            return answer;
        }

        private int Decoder(string line)
        {
            byte[] mess = Encoding.UTF8.GetBytes(line);
            int result = Convert.ToInt32(Encoding.UTF8.GetString(Encrypt(mess, true)));
            return result;
        }
    }
}