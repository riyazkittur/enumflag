using System;
using System.Collections.Generic;
using System.Text;

namespace EnumFlags
{
    //[Flags]
    public enum Access
    {
        
        Delete=1,//001
        Publish=2,//010
        Submit=4,//100
        Comment=8,
        Modify=16,
        Writer=Submit|Modify,
        Editor=Delete|Publish|Comment,
        Owner=Writer|Editor


    }
    //public static class EnumExtension
    //{
    //    public static bool HasFlag(this Access access,Access level)
    //    {
    //        bool result = false;
    //        Access AccessLevels;
    //        switch (access)
    //        {
    //            case Access.Writer:
    //                AccessLevels = Access.Submit | Access.Modify;
    //                return AccessLevels.HasFlag(level);
                   
    //            case Access.Editor:
    //                AccessLevels = Access.Delete | Access.Publish|Access.Comment;
    //                return AccessLevels.HasFlag(level);
                    
    //            case Access.Owner:
    //                AccessLevels = Access.Submit | Access.Modify| Access.Delete 
    //                    | Access.Publish | Access.Comment;
    //                return AccessLevels.HasFlag(level);
                   
    //            default:
    //                return result;

    //        }
            
          
    //    }
    //}
    
}
