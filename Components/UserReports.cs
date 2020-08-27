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
using DotNetNuke.Common.Utilities;

namespace Connect.Libraries.UserManagement
{
    public class UserReportInfo
    {
        private int _reportid;
        private string _friendlyname;
        private string _sql;
        private bool _needsparameters;
        private int _portalid;

        public int ReportId
        {
            get
            {
                return _reportid;
            }

            set
            {
                _reportid = value;
            }
        }

        public string FriendlyName
        {
            get
            {
                return _friendlyname;
            }

            set
            {
                _friendlyname = value;
            }
        }

        public string Sql
        {
            get
            {
                return _sql;
            }

            set
            {
                _sql = value;
            }
        }

        public bool NeedsParameters
        {
            get
            {
                return _needsparameters;
            }

            set
            {
                _needsparameters = value;
            }
        }

        public int PortalId
        {
            get
            {
                return _portalid;
            }

            set
            {
                _portalid = value;
            }
        }
    }

    public class UserReportsController
    {
        public static UserReportInfo GetReport(int ReportId)
        {
            return CBO.FillObject<UserReportInfo>(DotNetNuke.Data.DataProvider.Instance().ExecuteReader("Connect_Users_GetReport", (object)ReportId));
        }

        public static List<UserReportInfo> GetReports(int PortalId)
        {
            return CBO.FillCollection<UserReportInfo>(DotNetNuke.Data.DataProvider.Instance().ExecuteReader("Connect_Users_GetReports", (object)PortalId));
        }

        public static void AddReport(UserReportInfo objReport)
        {
            DotNetNuke.Data.DataProvider.Instance().ExecuteNonQuery("Connect_Users_AddReport", objReport.PortalId, objReport.FriendlyName, objReport.Sql, objReport.NeedsParameters);
        }

        public static void UpdateReport(UserReportInfo objReport)
        {
            DotNetNuke.Data.DataProvider.Instance().ExecuteNonQuery("Connect_Users_UpdateReport", objReport.ReportId, objReport.PortalId, objReport.FriendlyName, objReport.Sql, objReport.NeedsParameters);
        }

        public static void DeleteReport(int ReportId)
        {
            DotNetNuke.Data.DataProvider.Instance().ExecuteNonQuery("Connect_Users_DeleteReport", (object)ReportId);
        }
    }
}