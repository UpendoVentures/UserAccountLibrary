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

using System;
using System.Linq;
using System.Web.UI;
using DotNetNuke.Common.Lists;
using DotNetNuke.Common.Utilities;
using DotNetNuke.UI.WebControls;

namespace Connect.Libraries.UserManagement
{

    /// <summary>
    /// Provides a CheckboxList editor for the profile properties.
    /// Works the same as a list control but will display the list as checkboxes
    /// instead of a dropdown.
    /// </summary>
    /// <remarks></remarks>
    public class CheckboxListEditControl : DNNListEditControl
    {
        private int _columns = 3;

        /// <summary>
        /// Number of columns used to display the list
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Columns
        {
            get
            {
                return _columns;
            }

            set
            {
                _columns = value;
            }
        }

        protected override void RenderViewMode(HtmlTextWriter writer)
        {
            ControlStyle.AddAttributesToRender(writer);
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write(base.StringValue.Replace("|", "; "));
            writer.RenderEndTag();
        }

        protected override void RenderEditMode(HtmlTextWriter writer)
        {
            // Render the Select Tag
            ControlStyle.AddAttributesToRender(writer);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, UniqueID);
            if (AutoPostBack)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Onchange, Page.GetPostBackEventReference(this));
            }

            writer.RenderBeginTag(HtmlTextWriterTag.Table);
            int itemIndex = 0;
            int lastIndex = ListEntries.Count() - 1;
            var arrValues = base.StringValue.Split('|');
            while (itemIndex <= lastIndex)
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                for (int columnIndex = 0, loopTo = Columns - 1; columnIndex <= loopTo; columnIndex++)
                {
                    if (itemIndex <= lastIndex)
                    {
                        var item = List.Item(itemIndex);
                        string itemValue = GetItemValue(item);
                        string itemText = GetItemText(item);
                        string itemName = UniqueID;
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.AddAttribute(HtmlTextWriterAttribute.Type, "checkbox");
                        writer.AddAttribute(HtmlTextWriterAttribute.Value, itemValue);
                        writer.AddAttribute(HtmlTextWriterAttribute.Name, itemName);
                        foreach (string val in arrValues)
                        {
                            if ((itemValue ?? "") == (val ?? ""))
                            {
                                writer.AddAttribute(HtmlTextWriterAttribute.Checked, "checked");
                                break;
                            }
                        }

                        writer.RenderBeginTag(HtmlTextWriterTag.Input);
                        writer.Write(itemText);
                        writer.RenderEndTag();
                        writer.RenderEndTag();
                    }

                    itemIndex = itemIndex + 1;
                }

                writer.RenderEndTag();
            }

            // Close Table Tag
            writer.RenderEndTag();
        }

        private string GetItemValue(ListEntryInfo item)
        {
            // Add the Value Attribute
            switch (ValueField)
            {
                case ListBoundField.Id:
                    {
                        return item.EntryID.ToString();
                    }

                case ListBoundField.Text:
                    {
                        return item.Text;
                    }

                case ListBoundField.Value:
                    {
                        return item.Value;
                    }

                default:
                    {
                        return Null.NullString;
                    }
            }
        }

        private string GetItemText(ListEntryInfo item)
        {
            // Add the Value Attribute
            switch (TextField)
            {
                case ListBoundField.Id:
                    {
                        return item.EntryID.ToString();
                    }

                case ListBoundField.Text:
                    {
                        return item.Text;
                    }

                case ListBoundField.Value:
                    {
                        return item.Value;
                    }

                default:
                    {
                        return Null.NullString;
                    }
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (Page is object & EditMode == PropertyEditorMode.Edit)
            {
                Page.RegisterRequiresPostBack(this);
            }
        }
    }
}