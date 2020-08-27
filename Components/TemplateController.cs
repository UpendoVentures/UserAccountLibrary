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


namespace Connect.Libraries.UserManagement
{
    public class TemplateController
    {
        public static string GetTemplate(string strPath)
        {
            if (System.IO.File.Exists(strPath))
            {
                string templ = "";
                var sr = new System.IO.StreamReader(strPath);
                templ = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                return templ;
            }
            else
            {
                return "Could not load template, sorry...";
            }
        }
    }
}