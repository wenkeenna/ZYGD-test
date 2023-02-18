using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZYGD.Extensions
{
   static class ParameterCheck
    {
        //验证有效小数
      public static  bool IsValidDecimal(string strIn)
        {

            return Regex.IsMatch(strIn, @"[0].\d{1,2}|[1]");
        }

        /// <summary>
        /// 验证有效整数
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool IsValidInteger(string strIn)
        {

            return Regex.IsMatch(strIn, @"^[1-9]\d*$");
        }
        /// <summary>
        /// 验证有效布尔量
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool IsValidBoolean(string strIn)
        {

            return Regex.IsMatch(strIn, @"^[T][r][u][e]|[F][a][l][s][e]");
        }

    }
}
