//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.AI.StrongPoint
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class StrongPointArrayItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Id_;
		public uint groupId_;
		public uint elementId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StrongPointArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.StrongPoint.StrongPointArrayItem", 0, Black.AI.StrongPoint.StrongPointArrayItem.ObjectType, Construct, properties, 0, 24);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.AI.StrongPoint.StrongPointArrayItem", base.GetFieldProperties(), -397032856, -1760687817);
            
			
			
			fieldProperties.AddProperty(new Property("Id_", 3478900877, "uint32_t", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupId_", 3701625562, "SQEX.Ebony.Std.Fixid", 12, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("elementId_", 1896981983, "SQEX.Ebony.Std.Fixid", 16, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new StrongPointArrayItem();
        }
		
    }
}