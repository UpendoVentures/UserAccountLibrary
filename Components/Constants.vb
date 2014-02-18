﻿
Imports DotNetNuke
Imports DotNetNuke.Entities.Users

Imports DotNetNuke.Common
Imports DotNetNuke.Common.Utilities
Imports System.Web.UI.WebControls

Imports DotNetNuke.Entities.Modules
Imports System.Web.UI
Imports DotNetNuke.Entities.Profile
Imports Telerik.Web.UI
Imports System
Imports DotNetNuke.Framework
Imports DotNetNuke.Services.Localization
Imports System.Data
Imports Microsoft.VisualBasic


Namespace Connect.Libraries.UserManagement

    Public Class Constants

        Public Const ControlId_ResetPasswordButton As String = "btnResetPassword"
        Public Const ControlId_LostPasswordButton As String = "btnLostPassword"
        Public Const ControlId_LoginButton As String = "btnLogin"
        Public Const ControlId_UpdateButton As String = "btnUpdate"
        Public Const ControlId_DeleteButton As String = "btnDelete"

        Public Const ControlId_UsernameForLogin As String = "ctl_Login_Username"
        Public Const ControlId_PasswordForLogin As String = "ctl_Login_Password"
        Public Const ControlId_RememberForLogin As String = "ctl_Login_Remember"

        Public Const ControlId_Username As String = "ctl_User_Username"
        Public Const LabelId_Username As String = "lbl_User_Username"
        Public Const ControlId_Displayname As String = "ctl_User_Displayname"
        Public Const ControlId_Firstname As String = "ctl_User_Firstname"
        Public Const ControlId_Lastname As String = "ctl_User_Lastname"
        Public Const ControlId_Email As String = "ctl_User_Email"
        Public Const ControlId_PasswordCurrent As String = "ctl_User_PasswordCurrent"
        Public Const ControlId_Password1 As String = "ctl_User_Password1"
        Public Const ControlId_Password2 As String = "ctl_User_Password2"
        Public Const ControlId_PasswordQuestion As String = "ctl_User_PasswordQuestion"
        Public Const ControlId_PasswordAnswer As String = "ctl_User_PasswordAnswer"
        Public Const ControlId_ImageSuffix As String = "img_ProfileImage_"
        Public Const ControlId_ImageRemoveSuffix As String = "rem_ProfileImage_"
        Public Const ControlId_FileSuffix As String = "img_ProfileFile_"
        Public Const ControlId_FileRemoveSuffix As String = "rem_ProfileFile_"
        Public Const ControlId_ProfileProperty As String = "ctl_Profile_"
        Public Const ControlId_Visiblity As String = "ctl_Visibility_"

        Public Const ControlId_DropdownSuffix As String = "Select_"
        Public Const ControlId_TextSuffix As String = "Text_"

        Public Const ControlId_PanelRequired As String = "pnl_Required_"
        Public Const ControlId_PanelError As String = "pnl_Error_"
        Public Const ControlId_PanelSuccess As String = "pnl_Success_"

        Public Const CssClass_ErrorPanel As String = "connect_error"
        Public Const CssClass_SuccessPanel As String = "connect_success"
        Public Const CssClass_RequiredPanel As String = "connect_required"

        Public Const User_Lastname As String = "Lastname"
        Public Const User_Firstname As String = "Firstname"
        Public Const User_Username As String = "Username"
        Public Const User_PasswordCurrent As String = "PasswordCurrent"
        Public Const User_Password1 As String = "Password1"
        Public Const User_Password2 As String = "Password2"
        Public Const User_PasswordQuestion As String = "PasswordQuestion"
        Public Const User_PasswordAnswer As String = "PasswordAnswer"
        Public Const User_Displayname As String = "Displayname"
        Public Const User_Email As String = "Email"

        Public Const TemplateName_Extension As String = ".txt"

        Public Const TemplateName_Form As String = "Form" & TemplateName_Extension
        Public Const TemplateName_EmailToUser As String = "Email.User" & TemplateName_Extension
        Public Const TemplateName_EmailToUser_Verified As String = "Email.User.Verified" & TemplateName_Extension
        Public Const TemplateName_EmailToUser_Private As String = "Email.User" & TemplateName_Extension
        Public Const TemplateName_EmailToAdmin As String = "Email.Admin" & TemplateName_Extension

        Public Const TemplateName_EmailAccountCreated As String = "Email.Account.Created" & TemplateName_Extension
        Public Const TemplateName_EmailAccountData As String = "Email.Account.Data" & TemplateName_Extension
        Public Const TemplateName_EmailAddedToRole As String = "Email.AddedToRole" & TemplateName_Extension
        Public Const TemplateName_EmailRemovedFromRole As String = "Email.RemovedFromRole" & TemplateName_Extension
        Public Const TemplateName_EmailPasswordReset As String = "Email.Password.Reset" & TemplateName_Extension

        Public Const TemplateName_ProfileForm As String = "Form.Profile" & TemplateName_Extension
        Public Const TemplateName_AccountForm As String = "Form.Account" & TemplateName_Extension
        Public Const TemplateName_CreateForm As String = "Form.Create" & TemplateName_Extension

    End Class

End Namespace

