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
    public class Constants
    {
        public const string ControlId_ResetPasswordButton = "btnResetPassword";
        public const string ControlId_LostPasswordButton = "btnLostPassword";
        public const string ControlId_LoginButton = "btnLogin";
        public const string ControlId_UpdateButton = "btnUpdate";
        public const string ControlId_DeleteButton = "btnDelete";
        public const string ControlId_UsernameForLogin = "ctl_Login_Username";
        public const string ControlId_PasswordForLogin = "ctl_Login_Password";
        public const string ControlId_RememberForLogin = "ctl_Login_Remember";
        public const string ControlId_Username = "ctl_User_Username";
        public const string LabelId_Username = "lbl_User_Username";
        public const string ControlId_Displayname = "ctl_User_Displayname";
        public const string ControlId_Firstname = "ctl_User_Firstname";
        public const string ControlId_Lastname = "ctl_User_Lastname";
        public const string ControlId_Email = "ctl_User_Email";
        public const string ControlId_PasswordCurrent = "ctl_User_PasswordCurrent";
        public const string ControlId_Password1 = "ctl_User_Password1";
        public const string ControlId_Password2 = "ctl_User_Password2";
        public const string ControlId_PasswordQuestion = "ctl_User_PasswordQuestion";
        public const string ControlId_PasswordAnswer = "ctl_User_PasswordAnswer";
        public const string ControlId_ImageSuffix = "img_ProfileImage_";
        public const string ControlId_ImageRemoveSuffix = "rem_ProfileImage_";
        public const string ControlId_FileSuffix = "img_ProfileFile_";
        public const string ControlId_FileRemoveSuffix = "rem_ProfileFile_";
        public const string ControlId_ProfileProperty = "ctl_Profile_";
        public const string ControlId_Visiblity = "ctl_Visibility_";
        public const string ControlId_RoleMembership = "ctl_RoleMembership_";
        public const string ControlId_DropdownSuffix = "Select_";
        public const string ControlId_TextSuffix = "Text_";
        public const string ControlId_PanelRequired = "pnl_Required_";
        public const string ControlId_PanelError = "pnl_Error_";
        public const string ControlId_PanelSuccess = "pnl_Success_";
        public const string CssClass_ErrorPanel = "connect_error";
        public const string CssClass_SuccessPanel = "connect_success";
        public const string CssClass_RequiredPanel = "connect_required";
        public const string User_Lastname = "Lastname";
        public const string User_Firstname = "Firstname";
        public const string User_Username = "Username";
        public const string User_PasswordCurrent = "PasswordCurrent";
        public const string User_Password1 = "Password1";
        public const string User_Password2 = "Password2";
        public const string User_PasswordQuestion = "PasswordQuestion";
        public const string User_PasswordAnswer = "PasswordAnswer";
        public const string User_Displayname = "Displayname";
        public const string User_Email = "Email";
        public const string TemplateName_Extension = ".txt";
        public const string TemplateName_Form = "Form" + TemplateName_Extension;
        public const string TemplateName_EmailToUser = "Email.User" + TemplateName_Extension;
        public const string TemplateName_EmailToUser_Verified = "Email.User.Verified" + TemplateName_Extension;
        public const string TemplateName_EmailToUser_Private = "Email.User.Private" + TemplateName_Extension;
        public const string TemplateName_EmailToAdmin = "Email.Admin" + TemplateName_Extension;
        public const string TemplateName_EmailAccountCreated = "Email.Account.Created" + TemplateName_Extension;
        public const string TemplateName_EmailAccountData = "Email.Account.Data" + TemplateName_Extension;
        public const string TemplateName_EmailAddedToRole = "Email.AddedToRole" + TemplateName_Extension;
        public const string TemplateName_EmailRemovedFromRole = "Email.RemovedFromRole" + TemplateName_Extension;
        public const string TemplateName_EmailRoleStatusChanged = "Email.RoleStatusChanged" + TemplateName_Extension;
        public const string TemplateName_EmailPasswordReset = "Email.Password.Reset" + TemplateName_Extension;
        public const string TemplateName_ProfileForm = "Form.Profile" + TemplateName_Extension;
        public const string TemplateName_AccountForm = "Form.Account" + TemplateName_Extension;
        public const string TemplateName_CreateForm = "Form.Create" + TemplateName_Extension;
    }
}