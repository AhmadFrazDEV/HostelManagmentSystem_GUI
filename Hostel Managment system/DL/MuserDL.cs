using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalManagmentSystem.BL;
namespace HostalManagmentSystem.DL
{
    class MuserDL
    {
        private static List<Muser> userList = new List<Muser>();
        public static void addList(Muser u)
        {
            userList.Add(u);
        }
        public static bool signIn(Muser user)
        {
            foreach (Muser storedUser in userList)
            {
                if (user.getName() == storedUser.getName() && user.getPassword() == storedUser.getPassword() && user.getRoll() == storedUser.getRoll()) ;
                {
                    return true;
                }
            }
            return false;
        }

        public static string parseData(string rec, int field)
        {
            int coma = 1;
            string item = "";
            for (int i = 0; i < rec.Length; i++)
            {
                if (rec[i] == ',')
                {
                    coma++;
                }
                else if (coma == field)
                {
                    item = item + rec[i];
                }
            }
            return item;
        }

        public static bool readDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string rec;
                while ((rec = file.ReadLine()) != null)
                {
                    string userName = parseData(rec, 1);
                    string userpassword = parseData(rec, 2);
                    string userroll = parseData(rec, 3);
                    Muser user = new Muser(userName, userpassword, userroll);
                    addList(user);
                }
                file.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeIntoFile(Muser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.getName() + "," + user.getPassword() + "," + user.getRoll());
            file.Flush();
            file.Close();
        }
    }
}
