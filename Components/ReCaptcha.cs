// ***********************************************************************************
// Connect UsersLibrary
// 
// Copyright (C) 2013-2014 DNN-Connect Association, Philipp Becker
// http://dnn-connect.org
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
// 
// ***********************************************************************************

using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using DotNetNuke.Entities.Portals;

namespace Connect.Libraries.UserManagement
{
    public class ReCaptcha
    {
        public static void Validate(string PrivateKey, ref bool IsValid, ref string Result)
        {
            string strPrivateKey = PrivateKey;
            string strRemoteIp = HttpContext.Current.Request.UserHostAddress;
            string strChallenge = HttpContext.Current.Request.Form["recaptcha_challenge_field"];
            string strResponse = HttpContext.Current.Request.Form["recaptcha_response_field"];
            string postData = string.Format("privatekey={0}&remoteip={1}&challenge={2}&response={3}", strPrivateKey, strRemoteIp, strChallenge, strResponse);
            var byteArray = Encoding.UTF8.GetBytes(postData);
            string strProtocoll = "http";
            if (PortalSettings.Current.ActiveTab.IsSecure)
            {
                strProtocoll = "https";
            }

            var request = WebRequest.Create(string.Format("{0}://www.google.com/recaptcha/api/verify", strProtocoll));
            request.Method = "POST";
            request.ContentLength = byteArray.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            var dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            var response = request.GetResponse();
            dataStream = response.GetResponseStream();
            var reader = new StreamReader(dataStream);
            var lstResult = new List<string>();
            while (reader.Peek() >= 0)
                lstResult.Add(reader.ReadLine());
            reader.Close();
            dataStream.Close();
            response.Close();
            if (lstResult.Count > 0)
            {
                try
                {
                    IsValid = bool.Parse(lstResult[0]);
                }
                catch
                {
                }

                try
                {
                    Result = lstResult[1];
                }
                catch
                {
                }
            }
        }
    }
}