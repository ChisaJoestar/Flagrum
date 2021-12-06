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

namespace Black.Camera.Struct
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class CameraAngleLimit : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int tiltAngleLimitMode_;
		public float tiltAngleLimitMin_;
		public float tiltAngleLimitMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraAngleLimit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Camera.Struct.CameraAngleLimit", 0, Black.Camera.Struct.CameraAngleLimit.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Camera.Struct.CameraAngleLimit", base.GetFieldProperties(), -731158199, 589371655);
            
			
			
			fieldProperties.AddProperty(new Property("tiltAngleLimitMode_", 1066266112, "Black.Camera.CameraAngleLimitMode", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("tiltAngleLimitMin_", 1467894045, "float", 12, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("tiltAngleLimitMax_", 4037458655, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new CameraAngleLimit();
        }
		
    }
}