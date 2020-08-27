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

using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security;
using Microsoft.VisualBasic.CompilerServices;

namespace Connect.Libraries.UserManagement
{
    public class Utilities
    {
        public static string GetVerificationCode(UserInfo User)
        {
            var ps = new PortalSecurity();
            string code = ps.EncryptString((User.PortalID + Conversions.ToDouble("-") + User.UserID).ToString(), Config.GetDecryptionkey());
            return code.Replace("+", ".").Replace("/", "-").Replace("=", "_");
        }
    }
}