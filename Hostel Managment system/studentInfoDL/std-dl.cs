using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalManagmentSystem.stdudentInfoBL;
namespace HostalManagmentSystem.studentInfoDL
{
    class std_Dl
    {
        public static string application_path = "application.txt";
        public static List<std_BL> inforMationList = new List<std_BL>();
        public static void addInformation(std_BL std)
        {
            inforMationList.Add(std);
        }

        public static string parseData(string rec, int field)
        {
            int coma = 1;
            string item = " ";
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
                    string fname = parseData(rec, 1);
                    string fatname = parseData(rec, 2);
                    string dob = parseData(rec, 3);
                    string phoneNo = parseData(rec, 4);
                    string address = parseData(rec, 5);
                    string matricMarks = parseData(rec, 6);
                    string fscMarks = parseData(rec, 7);
                    string ecatMarks = parseData(rec, 8);
                    string aggregate = parseData(rec, 9);

                    std_BL student = new std_BL(fname, fatname, dob, phoneNo, address, matricMarks, fscMarks, ecatMarks , aggregate);
                    addInformation(student);
                }
                file.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeIntoFile(std_BL user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.Fname1 + "," + user.Fathname + "," + user.Dob + "," + user.PhoneNo + "," + user.Address + "," + user.MatricMarks + "," + "," + user.FscMarks1 + "," + user.EcatMarks + "," + user.Aggregate);
            file.Flush();
            file.Close();
        }

        public static void addComlain(string path, string complain)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(complain);
            file.Flush();
            file.Close();
        }

        public static void deleteUserFromList(std_BL user)
        {
            for (int index = 0; index < inforMationList.Count; index++)
            {
                if (inforMationList[index].Fname1 == user.Fname1 && inforMationList[index].Fathname == user.Fathname && inforMationList[index].Dob == user.Dob && inforMationList[index].PhoneNo == user.PhoneNo && inforMationList[index].Address == user.Address && inforMationList[index].MatricMarks == user.MatricMarks && inforMationList[index].FscMarks1 == user.FscMarks1 && inforMationList[index].EcatMarks == user.EcatMarks)
                {
                    inforMationList.RemoveAt(index);
                }
            }

        }

        public static void EditUserFromList(std_BL previous, std_BL updated)
        {
            foreach (std_BL user in inforMationList)
            {
                if (user.Fname1 == previous.Fname1 && user.Fathname == previous.Fathname && user.Dob == previous.Dob && user.PhoneNo == previous.PhoneNo && user.Address == previous.Address && user.MatricMarks == previous.MatricMarks && user.FscMarks1 == previous.FscMarks1 && user.EcatMarks == previous.EcatMarks)
                {
                    user.Fname1 = updated.Fname1;
                    user.Fathname = updated.Fathname;
                    user.Dob = updated.Dob;
                    user.PhoneNo = updated.PhoneNo;
                    user.Address = updated.Address;
                    user.MatricMarks = updated.MatricMarks;
                    user.FscMarks1 = updated.FscMarks1;
                    user.EcatMarks = updated.EcatMarks;

                }
            }

        }
        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (std_BL storedUser in inforMationList)
            {

                file.WriteLine(storedUser.Fname1 + "," + storedUser.Fathname + "," + storedUser.Dob + "," + storedUser.PhoneNo + "," + storedUser.Address + "," + storedUser.MatricMarks + "," + storedUser.FscMarks1 + "," + storedUser.EcatMarks);
            }
            file.Flush();
            file.Close();

        }

        public static void storeApplicationinfile(string app, string pass)
        {
            StreamWriter file = new StreamWriter(application_path, true);
            file.WriteLine(pass + "," + app);

            file.Flush();
            file.Close();
        }

        public static void sortList(List<std_BL> students)
        {
            double temp;
            string temp_name = "";

            //for (int i = 0; i < students.Count; i++)
            //{
            //    for (int j = 1; j < students.Count; j++)
            //    {
            //        if (students[i].Aggregate < students[j].Aggregate)
            //        {
            //            temp = students[i].Aggregate;
            //            students[i].Aggregate = students[j].Aggregate;
            //            students[j].Aggregate = temp;

            //            temp_name = students[i].name;
            //            students[i].name = students[j].name;
            //            students[j].name = temp_name;
            //        }
            //    }
            //}

        }

        public static string calculate_Aggregate(string EcatMarks, string FscMarks)
        {
            double ecat = Convert.ToDouble(EcatMarks);
            double fsc = Convert.ToDouble(FscMarks);
            double aggregate = ((ecat * 100.0 / 400.0) * 0.30) + ((fsc * 100.0 / 1100.0) * 0.70);
            return aggregate.ToString();
        }
        
    }
}
