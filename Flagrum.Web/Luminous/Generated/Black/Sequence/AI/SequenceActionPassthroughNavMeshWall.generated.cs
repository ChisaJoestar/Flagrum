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

namespace Black.Sequence.AI
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SequenceActionPassthroughNavMeshWall : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPassthrough_= new SQEX.Ebony.Framework.Node.GraphTriggerInputPin();
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin finishPassthrough_= new SQEX.Ebony.Framework.Node.GraphTriggerInputPin();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPassthroughNavMeshWall();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.AI.SequenceActionPassthroughNavMeshWall", 0, Black.Sequence.AI.SequenceActionPassthroughNavMeshWall.ObjectType, Construct, properties, 0, 456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.AI.SequenceActionPassthroughNavMeshWall", base.GetFieldProperties(), 683462896, -330601244);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.pinName_", 3335040042, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.name_", 3822690741, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.connections_", 213149741, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.pinValueType_", 4068350780, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPassthrough_.pinName_", 2030281571, "Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPassthrough_.name_", 2787037774, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPassthrough_.connections_", 4140976788, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 304, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("startPassthrough_.delayType_", 1522030650, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 336, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPassthrough_.delayTime_", 2014771213, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPassthrough_.delayMaxTime_", 3406696537, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishPassthrough_.pinName_", 284946364, "Base.String", 368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishPassthrough_.name_", 2895481191, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishPassthrough_.connections_", 2379399463, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("finishPassthrough_.delayType_", 2652575585, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 432, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishPassthrough_.delayTime_", 238298070, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishPassthrough_.delayMaxTime_", 390055804, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("actor_", 3434601855, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startPassthrough_", 1465200268, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 264, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finishPassthrough_", 3968500221, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 360, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionPassthroughNavMeshWall();
        }
		
    }
}