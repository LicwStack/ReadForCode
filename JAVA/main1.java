package com.company;

import java.io.*;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        try
        {
            String str1="";
            System.out.println("��������ӣ�");
            Scanner scan = new Scanner(System.in);
            if(scan.hasNextLine()){
                str1 = scan.nextLine();
            }
            String str2="";
            System.out.println("�������ĸ��");
            Scanner scan1 = new Scanner(System.in);
            if(scan1.hasNextLine()){
                str2 = scan1.nextLine();
            }

            test tt = new test();
            System.out.println("���ӳ��Է�ĸ��ֵ��" + tt.MyInt(str1, str2));
        }
        catch(Exception ex)
        {
            System.out.println("��������ֵ��ʽ������");
        }
    }
}

class test
{
    public int MyInt(String a, String b)
    {
        int int1;
        int int2;
        int num;
        try
        {

            int1 = Integer.parseInt(a);
            int2 = Integer.parseInt(b);
            if (int2 == 0)
            {
                throw new ArithmeticException();
            }
            num = int1 / int2;
            return num;
        }
        catch (Exception de)
        {
            System.out.println(de);
            return 0;
        }
    }
}
