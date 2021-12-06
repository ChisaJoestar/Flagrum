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

namespace Black.Save.Party
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SavePartyStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Party.SavePartyMemberStruct member= new Black.Save.Party.SavePartyMemberStruct();
		public Black.Save.Party.SaveJobStruct job= new Black.Save.Party.SaveJobStruct();
		public Black.Save.Ability.SaveAbilityCountStruct ability_count= new Black.Save.Ability.SaveAbilityCountStruct();
		public Black.Save.Ability.SaveAbilityEffectCountStruct ability_effect_count= new Black.Save.Ability.SaveAbilityEffectCountStruct();
		public Black.Save.Ability.SaveAbilityInformationStruct ability_information= new Black.Save.Ability.SaveAbilityInformationStruct();
		public Black.Save.Party.SavePartyDataStruct data= new Black.Save.Party.SavePartyDataStruct();
		public Black.Save.Party.SaveSystemToggleStruct system_toggle= new Black.Save.Party.SaveSystemToggleStruct();
		public Black.Save.Party.SaveTrophyStruct trophy= new Black.Save.Party.SaveTrophyStruct();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SavePartyStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Party.SavePartyStruct", 0, Black.Save.Party.SavePartyStruct.ObjectType, null, properties, 0, 23880);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.Party.SavePartyStruct", null, -1047436391, -1064039247);
            
			fieldProperties.AddIndirectlyProperty(new Property("ability_count.id", 1991254344, "Black.Save.Ability.SaveAbilityCountOneStruct", 572, 4096, 1024, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("ability_effect_count.count", 1240267242, "int32_t", 4668, 1024, 256, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("data.usercontrol_player_save_number", 279540881, "Black.Save.SAVE_PLAYER", 22080, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.chapter", 3098623270, "int32_t", 22084, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.gil", 2784233511, "int32_t", 22088, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.medal", 729279584, "int32_t", 22092, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.coin", 4161405640, "int32_t", 22096, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.ability_point", 390707280, "int32_t", 22100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.reward_count", 1793305554, "int32_t", 22104, 256, 64, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("data.clear_count", 3136459562, "int32_t", 22360, 12, 3, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("data.newgame_plus", 1302556112, "bool", 22372, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.premium_camera_status", 1630186287, "bool", 22373, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.premium_camera_equipment", 481360439, "bool", 22374, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.element_power", 3459699117, "float", 22376, 68, 17, Property.PrimitiveType.Float, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("data.phantom_gauge", 2815435594, "float", 22444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.phantom_gauge_max", 2005884071, "float", 22448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.job_command_available", 900328742, "bool", 22452, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.job_command_gauge", 3643115118, "float", 22456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.job_command_gauge_max", 375613675, "float", 22460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.strategy_probability", 2916224084, "int32_t", 22464, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.camp_point_fixid", 493276856, "SQEX.Ebony.Std.Fixid", 22468, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.camp_point_area_file_path", 1041949788, "Ebony.Base.String", 22472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.isLoopDungeon", 1608473339, "bool", 22488, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.loopDungeonLevel", 3772286283, "int", 22492, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.before_camp_point_fixid", 1163162998, "SQEX.Ebony.Std.Fixid", 22496, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.link_count", 2711143245, "int32_t", 22500, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.death_count", 322670505, "int32_t", 22504, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.kill_count", 1718451245, "int32_t", 22508, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.picture_count", 2136218221, "int32_t", 22512, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.world_time", 3029178657, "int64_t", 22520, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.total_seconds", 1475853615, "int64_t", 22528, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.weather_key", 2966207543, "Ebony.Base.String", 22536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.weather_type", 3208775456, "Black.Weather.WeatherType", 22552, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.weather_index_command", 389569646, "uint32_t", 22556, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.move_distance_type", 3603024775, "Black.Save.MOVE_DISTANCE_TYPE", 22560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.move", 1968360848, "Black.Save.Party.SaveMoveDistanceStruct", 22568, 192, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("data.battle_result_rank", 3955802224, "int", 22760, 32, 8, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("data.battle_result_count", 1738783109, "int", 22792, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.camp_point_", 2297020666, "Luminous.Math.DoubleVector4", 22800, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.before_camp_point_", 3891935136, "Luminous.Math.DoubleVector4", 22832, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.loopDungeonBasePoint_", 2347319029, "Luminous.Math.DoubleVector4", 22864, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.loopDungeonCampPoint_", 4177448885, "Luminous.Math.DoubleVector4", 22896, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.reserve1", 348043946, "int32_t", 22928, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.reserve2", 331266327, "int32_t", 22932, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.reserve3", 314488708, "int32_t", 22936, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.reserve4", 297711089, "int32_t", 22940, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.reserve5", 280933470, "int32_t", 22944, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.reserve6", 264155851, "int32_t", 22948, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.reserve7", 247378232, "int32_t", 22952, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("data.reserve8", 230600613, "int32_t", 22956, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("member", 719708611, "Black.Save.Party.SavePartyMemberStruct", 0, 20, 5, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("job", 3721670620, "Black.Save.Party.SaveJobStruct", 20, 552, 6, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("ability_count", 1904179969, "Black.Save.Ability.SaveAbilityCountStruct", 572, 4096, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability_effect_count", 2728588471, "Black.Save.Ability.SaveAbilityEffectCountStruct", 4668, 1024, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability_information", 3490697500, "Black.Save.Ability.SaveAbilityInformationStruct", 5692, 16384, 1024, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("data", 3631407781, "Black.Save.Party.SavePartyDataStruct", 22080, 880, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("system_toggle", 3945033081, "Black.Save.Party.SaveSystemToggleStruct", 22960, 128, 128, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("trophy", 1002300159, "Black.Save.Party.SaveTrophyStruct", 23088, 792, 99, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}