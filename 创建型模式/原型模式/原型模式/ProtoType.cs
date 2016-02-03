using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式
{
   abstract  class ProtoType
    {
       private string id;
       public string ID
       {
           get { return id; }
       }
       public ProtoType(string id)
       {
           this.id = id;
       }
       public abstract ProtoType Clone();
    }
   class ConCreateProtoType1 : ProtoType
   {
       public ConCreateProtoType1(string id)
           : base(id)
       { 
       
       }
       public override ProtoType Clone()
       {
           return (ProtoType)this.MemberwiseClone();   
       }
   }
   class ConCreateProtoType2 : ProtoType
   {
       public ConCreateProtoType2(string id)
           : base(id)
       { }

       public override ProtoType Clone()
       {
          return this.MemberwiseClone() as ProtoType;
       }
   }
}
