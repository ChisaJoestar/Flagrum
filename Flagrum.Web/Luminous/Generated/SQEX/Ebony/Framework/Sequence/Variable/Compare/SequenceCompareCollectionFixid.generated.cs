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

namespace SQEX.Ebony.Framework.Sequence.Variable.Compare
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SequenceCompareCollectionFixid : SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public List<SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareFixid> conditions_= new List<SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareFixid>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceCompareCollectionFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionFixid", 0, SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionFixid.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionFixid", base.GetFieldProperties(), 2054332255, -530594396);
            
			
			
			fieldProperties.AddProperty(new Property("conditions_", 3387481400, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareFixid* >", 8, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceCompareCollectionFixid();
        }
		
    }
}