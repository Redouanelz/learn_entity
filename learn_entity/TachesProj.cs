//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace learn_entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TachesProj
    {
        public Nullable<int> IDProj { get; set; }
        public int IDTache { get; set; }
        public string laTache { get; set; }
        public string StatutTache { get; set; }
        public Nullable<int> TacheAttribueA { get; set; }
        public string TacheAttribueANom { get; set; }
    
        public virtual EquipeProj EquipeProj { get; set; }
        public virtual FicheProj FicheProj { get; set; }
    }
}
