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

namespace Black.Actor.Create
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class ActorTeamCreateSeed : Black.Actor.Create.ActorCreateSeedBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorTeamCreateSeed();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Create.ActorTeamCreateSeed", 0, Black.Actor.Create.ActorTeamCreateSeed.ObjectType, Construct, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Actor.Create.ActorTeamCreateSeed", base.GetFieldProperties(), -548011037, 1064305941);
            
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new ActorTeamCreateSeed();
        }
		
    }
}