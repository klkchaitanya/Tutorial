﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLogicLayer
{
    public class Validation
    {
        public static int checkNull(string str)
        {
            if (str == "")
                return 0;
            else
                return 1;
        }

        // ***************************   Customer Name Validation  *************************//
        public static int customerName(string cname)
        {
            int flag = 0;
            String s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char c in cname.ToUpper().ToCharArray())
            {
                if (!s.Contains(c))
                    flag = 1;
            }
            if (flag == 1)
                return 1;
            else
                return 0;
        }

        // ***************************  Pin Code Validation  *************************//
        public static int pinCode(string pincode)
        {
            string s = "0123456789";
            foreach (char c in pincode)
            {
                if (s.Contains(c))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }


        // ***************************  Phone Number Validation  *************************//
        public static int phoneNumber(string pnum)
        {
            string phone_format = "[7-9]{1}[0-9]{9}";
            if (!Regex.IsMatch(pnum, phone_format))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        // *************************** Email Validation  *************************//
        public static int email(string email)
        {
            string email_format = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            if (!Regex.IsMatch(email, email_format))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        // ***************************  Password Validation  *************************//
        public static int password(string pass, string cname)
        {
            int flag_small_alph = 0, flag_caps_alph = 0, flag_num = 0;
            if (pass.Contains(cname))
            {
                return 2;
            }
            else
            {
                string alph = "abcdefghijklmnopqrstuvwxyz";
                string nums = "0123456789";
                string symbol = "!@$%&*_";
                int count=0;
                foreach (char c in alph.ToCharArray())
                {
                    if (pass.Contains(c))
                        flag_small_alph = 1;

                }
                
                foreach (char c in alph.ToUpper().ToCharArray())
                {
                    if (pass.Contains(c))
                        flag_caps_alph = 1;
                }

                foreach (char c in nums.ToCharArray())
                {
                    if (pass.Contains(c))
                        flag_num = 1;
                }

                foreach (char c in symbol.ToCharArray())
                {
                    if (pass.Contains(c))
                    {
                        //flag_symbol = 1;
                        count++;
                    }
                }
                if (flag_num == 1 && flag_small_alph == 1 && flag_caps_alph == 1 && count == 1)
                    return 1;
                else
                    return 0;
            }
        }
    }
}