//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblComment
    {
        public int ID { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
    
        public virtual tblBook tblBook { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
