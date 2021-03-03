﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\GitRepository\\StudyCsharp21\\SampleDir\\SubFolder\\a.dat";// 텍스트 파일 생성위치

            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write));//append 첨부하다 중복으로 추가됨
                sw.WriteLine(int.MaxValue);
                sw.WriteLine("Hello, World!");
                sw.WriteLine($"uint.MaxValue = {uint.MaxValue}");
                sw.WriteLine("안녕하세요");
                sw.WriteLine($"double.MaxValue = {double.MaxValue}");

                Console.WriteLine("파일 생성");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일쓰기 예외발생 : {ex.Message}");

            }
            finally
            {

                sw.Close();
            }

            StreamReader sr = null;

            sr = new StreamReader(new FileStream(filePath, FileMode.Open,FileAccess.Read));
            Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

            while (sr.EndOfStream == false)//파일의 제일 마지막 false가 되면 마지막
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();

        }
    }
}
