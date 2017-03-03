using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Osiris.Tools
{
    public static class Commons
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="strSource">需要加密的明文</param>
        /// <returns>返回32位加密结果</returns>
        public static string Get_MD5(string strSource)
        {
            //new 
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            //获取密文字节数组
            byte[] bytResult = md5.ComputeHash(System.Text.Encoding.GetEncoding("ASCII").GetBytes(strSource));

            //转换成字符串，并取9到25位 
            //string strResult = BitConverter.ToString(bytResult, 4, 8);  
            //转换成字符串，32位 

            string strResult = BitConverter.ToString(bytResult);

            //BitConverter转换出来的字符串会在每个字符中间产生一个分隔符，需要去除掉 
            strResult = strResult.Replace("-", "");

            return strResult.ToLower();
        }

        /// <summary>
        /// 日期转换成unix时间戳
        /// 格林威治时间 1970年01月01日00时00分00秒（北京时间1970年01月01日08时00分00秒）
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long DateTimeToUnixTimestamp(DateTime dateTime)
        {
            var start = new DateTime(1970, 1, 1, 8, 0, 0, dateTime.Kind);
            return Convert.ToInt64((dateTime - start).TotalSeconds);
        }

        /// <summary>
        /// unix时间戳转换成日期
        /// </summary>
        /// <param name="unixTimeStamp">时间戳（秒）</param>
        /// <returns></returns>
        public static DateTime UnixTimestampToDateTime(this DateTime target, long timestamp)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);
            return start.AddSeconds(timestamp);
        }
    }
}
