using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Endicia.Api
{
    public static class List
    {
        public static MultiSelectList ToMultiSelectList<T>(this List<T> list) where T : USPSShippingMethod
        {
            MultiSelectList result = new MultiSelectList(
                list,
                "MailClass",
                "Name");

            return result;
        }
        public static SelectList ToSelectListShipping<T>(this List<T> list) where T : USPSShippingMethod
        {
            SelectList result = new SelectList(
                list,
                "MailClass",
                "Name");

            return result;
        }
        public static SelectList ToSelectListSize<K>(this List<K> list) where K : LabelSizeClass
        {
            SelectList result = new SelectList(
                list,
                "LabelSize",
                "LabelSizeName");

            return result;
        }

        public static SelectList ToSelectListShape<K>(this List<K> list) where K : MailPieceClass
        {
            SelectList result = new SelectList(
                list,
                "MailPiece",
                "MailPieceName");

            return result;
        }
    }
}
