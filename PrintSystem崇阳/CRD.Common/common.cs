using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;
using System.Web;

namespace webgdzc.Common
{
    /// <summary>
    ///common 的摘要说明
    /// </summary>
    public class common
    {
        // Methods
        public static string ParseTags(string HTMLStr)
        {
            return Regex.Replace(HTMLStr, "<[^>]*>", "");
        }

        #region 字符串截取
        public static string Sub_StringEx(string str, int length)
        {
            if (str.Length > length - 3)
            {
                return str.Substring(0, length - 3) + "...";
            }
            return str;



        }

        public static string Sub_String(string str, int lenghth)
        {
            if (str.Length > lenghth)
            {
                return str.Substring(0, lenghth);
            }
            return str;
        }
        #endregion

        #region 2.检查字符是否数字或字母

        /// <summary>
        /// 检查字符是否数字或字母
        /// </summary>
        /// <returns></returns>
        public static bool IsNumOrLetter(char c)
        {
            string Str = "abcdefghigklmnopqrstuvwxyzABCDEFGHIGKLMNOPQRSTUVWXYZ0123456789";
            if (Str.Contains(c.ToString()))
                return true;
            else
                return false;
        }

        #endregion

        #region 字符串处理
        /// <summary>
        /// 根据长度截取字符串
        /// </summary>
        /// <param name="strs">传入的字符串</param>
        /// <param name="count">传入要截取的字数</param>
        /// <returns>返回的字符串</returns>
        public static string GetStr(string strs, int count)
        {
            string str = StripHTML(HttpContext.Current.Server.HtmlDecode(strs));
            if (str.Length > count)
            {
                str = str.Substring(0, count) + "...";
            }
            return str;
        }
        /// <summary>
        /// 对数据库记录中存在HTML标签的数据进行处理
        /// </summary>
        /// <param name="strHtml">传入的字符串</param>
        /// <returns>返回的字符串</returns>
        public static string StripHTML(string Htmlstring)
        {
            //string[] aryReg ={
            //              @"<script[^>]*?>.*?</script>",
            //              @"<(\/\s*)?!?((\w+:)?\w+)(\w+(\s*=?\s*(([""'])(\\[""'tbnr]|[^\7])*?\7|\w+)|.{0})|\s)*?(\/\s*)?>",
            //              @"([\r\n])[\s]+",
            //              @"&(quot|#34);",
            //              @"&(amp|#38);",
            //              @"&(lt|#60);",
            //              @"&(gt|#62);",   
            //              @"&(nbsp|#160);",   
            //              @"&(iexcl|#161);",
            //              @"&(cent|#162);",
            //              @"&(pound|#163);",
            //              @"&(copy|#169);",
            //              @"&#(\d+);",
            //              @"-->",
            //              @"<!--.*\n"
            //            };

            //string[] aryRep =   {
            //                "",
            //                "",
            //                "",
            //                "\"",
            //                "&",
            //                "<",
            //                ">",
            //                "   ",
            //                "\xa1",//chr(161),
            //                "\xa2",//chr(162),
            //                "\xa3",//chr(163),
            //                "\xa9",//chr(169),
            //                "",
            //                "\r\n",
            //                ""
            //              };
            //string newReg = aryReg[0];
            //string strOutput = strHtml;
            //for (int i = 0; i < aryReg.Length; i++)
            //{
            //    Regex regex = new Regex(aryReg[i], RegexOptions.IgnoreCase);
            //    strOutput = regex.Replace(strOutput, aryRep[i]);
            //}
            //strOutput.Replace("<", "");
            //strOutput.Replace(">", "");
            //strOutput.Replace("\r\n", "");
            //return strOutput;

            Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);        //删除HTML           
            Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", " ", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"<img[^>]*>;", "", RegexOptions.IgnoreCase);
            Htmlstring.Replace("<", "");
            Htmlstring.Replace(">", "");
            Htmlstring.Replace("\r\n", "");
            Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();
            return Htmlstring;
        }
        #endregion

        #region 类型转换

        /// <summary>
        /// 转换成Int型数字
        /// </summary>
        /// <param name="o"></param>
        /// <param name="iDefault"></param>
        /// <returns></returns>
        public static int IntSafeConvert(object o, int iDefault)
        {
            if (o == null)
                return iDefault;
            string _s = o.ToString().Trim();
            if (_s.Length <= 0)
                return iDefault;
            int res = iDefault;
            return int.TryParse(_s, out res) ? res : iDefault;
        }
        /// <summary>
        /// 转换成Int型数字
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int IntSafeConvert(object o)
        {
            return IntSafeConvert(o, 0);
        }


        /// <summary>
        /// 转换成Byte型数字
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static byte ByteSafeConvert(object o)
        {
            return ByteSafeConvert(o, 0);
        }

        /// <summary>
        /// 转换成Byte型数字
        /// </summary>
        /// <param name="o"></param>
        /// <param name="iDefault"></param>
        /// <returns></returns>
        public static byte ByteSafeConvert(object o, byte iDefault)
        {
            if (o == null)
                return iDefault;
            string _s = o.ToString().Trim();
            if (_s.Length <= 0)
                return iDefault;
            byte res = iDefault;
            return byte.TryParse(_s, out res) ? res : iDefault;
        }

        #endregion

        #region 加解密

        private static string encryptkey = "Wlc8";    //密钥  

        #region   对数据进行加密
        /// <summary>
        /// 对数据进行加密
        /// </summary>
        /// <param name="encryptstring">需要加密的数据</param>
        /// <returns></returns>
        public static string DESEncrypt(string encryptstring)
        {
            string strRtn;
            try
            {
                DESCryptoServiceProvider desc = new DESCryptoServiceProvider();//des进行加密
                byte[] key = System.Text.Encoding.Unicode.GetBytes(encryptkey);
                byte[] data = System.Text.Encoding.Unicode.GetBytes(encryptstring);
                MemoryStream ms = new MemoryStream();//存储加密后的数据
                CryptoStream cs = new CryptoStream(ms, desc.CreateEncryptor(key, key), CryptoStreamMode.Write);
                cs.Write(data, 0, data.Length);//进行加密
                cs.FlushFinalBlock();
                strRtn = Convert.ToBase64String(ms.ToArray());
                return strRtn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region   对数据进行解密
        /// <summary>
        /// 对数据进行解密
        /// </summary>
        /// <param name="decryptstring">需要解密的数据</param>
        /// <returns></returns>
        public static string DESDecrypt(string decryptstring)
        {
            string strRtn;
            try
            {
                DESCryptoServiceProvider desc = new DESCryptoServiceProvider();
                byte[] key = System.Text.Encoding.Unicode.GetBytes(encryptkey);
                byte[] data = Convert.FromBase64String(decryptstring);
                MemoryStream ms = new MemoryStream();//存储解密后的数据
                CryptoStream cs = new CryptoStream(ms, desc.CreateDecryptor(key, key), CryptoStreamMode.Write);
                cs.Write(data, 0, data.Length);//解密数据
                cs.FlushFinalBlock();
                strRtn = System.Text.Encoding.Unicode.GetString(ms.ToArray());
                return strRtn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #endregion

        #region 格式化日期
        public static string FormatDate(string date)
        {
            DateTime d = Convert.ToDateTime(date);
            return d.ToString("yyyy-MM-dd");

        }
        public static string GetYear(string date)
        {
            DateTime d = Convert.ToDateTime(date);
            return d.ToString("yyyy");
        }
        #endregion

        /// <summary>
        /// 过滤HTML中的不安全标签
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns></returns>
        public static string RemoveUnsafeHtml(string str)
        {
            str = Regex.Replace(str, @"(\<|\s+)o([a-z]+\s?=)", "$1$2", RegexOptions.IgnoreCase);
            return Regex.Replace(str, @"(script|frame|form|meta|behavior|style)([\s|:|>])+", "$1.$2", RegexOptions.IgnoreCase);
        }

        #region 过滤危险字符
        public static string SafeSql(string sql)
        {
            sql = sql.Replace("<", "");
            sql = sql.Replace(">", "");
            sql = sql.Replace(" ", "");
            sql = sql.Replace("*", "");
            sql = sql.Replace("'", "");
            sql = sql.Replace("%", "");
            sql = sql.Replace("|", "");
            sql = sql.Replace("-", "");
            sql = sql.Replace("!", "");
            return sql;
        }
        #endregion

        /// <summary>
        /// 检测是否有Sql危险字符
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>判断结果</returns>
        public static bool IsSafeSqlString(string str)
        {
            return !Regex.IsMatch(str, @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']");
        }

    }
}