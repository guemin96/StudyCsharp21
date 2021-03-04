using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace AddressBookApp
{
    class DataFileManager
    {
        string dataFileName = "address.dat";
        //D:\GitRepository\StudyCsharp21\chap99\AddressBookApp\AddressBookApp\bin\Debug\netcoreapp3.1

        public List<AddressInfo> ReadData()
        {
            var listResult = new List<AddressInfo>();
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일


            var sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)); //open
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                //temp 잘라서 manager.listAddess 할당
                var splits = temp.Split("|");
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();

            return listResult;
        }
        public void WriteData(List<AddressInfo> param)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일

            //주소록을 다시 파일에 씀
            StreamWriter sw = new StreamWriter(
                new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (param.Count > 0)
            {
                foreach (var item in param)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }

            }
            sw.Close();

        }
    }
}
