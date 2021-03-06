﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Упр)
	///</summary>
	[DataContract]
	public enum ВидыИзмененияПлановПоИзмерениям
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"3fb3fa1a-9a3c-4ddc-acc4-be09a6cac308\", \"Представление\":\"ФиксированноеЗначение\"}")]
		ФиксированноеЗначение = 0,//Фиксированное значение
		[EnumMember(Value = "{\"Ссылка\":\"f073b3cf-949b-41ee-8527-a460ea6d5ceb\", \"Представление\":\"ПоИсточникуДанныхРасчета\"}")]
		ПоИсточникуДанныхРасчета = 1,//По источнику данных расчета
		[EnumMember(Value = "{\"Ссылка\":\"cf0f8406-0532-4604-bd4e-9d50738b970d\", \"Представление\":\"ПоПрофилю_Распределение\"}")]
		ПоПрофилю_Распределение = 2,//По профилю: распределение
		[EnumMember(Value = "{\"Ссылка\":\"84d3f788-c057-407b-beda-209a7904ef80\", \"Представление\":\"ПоПрофилю_Умножение\"}")]
		ПоПрофилю_Умножение = 3,//По профилю: умножение
	}
	public static partial class ВидыИзмененияПлановПоИзмерениям_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ФиксированноеЗначение = new Guid("09bec4ac-caa6-08c3-4ddc-9a3c3fb3fa1a");//Фиксированное значение
		public static readonly Guid ПоИсточникуДанныхРасчета = new Guid("60a42785-6dea-eb5c-41ee-949bf073b3cf");//По источнику данных расчета
		public static readonly Guid ПоПрофилю_Распределение = new Guid("509d4ebd-8b73-0d97-4604-0532cf0f8406");//По профилю: распределение
		public static readonly Guid ПоПрофилю_Умножение = new Guid("9a20dabe-0479-80ef-407b-c05784d3f788");//По профилю: умножение
		public static ВидыИзмененияПлановПоИзмерениям Получить(this ВидыИзмененияПлановПоИзмерениям Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыИзмененияПлановПоИзмерениям Получить(this ВидыИзмененияПлановПоИзмерениям Значение, Guid Ссылка)
		{
			if(Ссылка == ФиксированноеЗначение)
			{
				return ВидыИзмененияПлановПоИзмерениям.ФиксированноеЗначение;
			}
			else if(Ссылка == ПоИсточникуДанныхРасчета)
			{
				return ВидыИзмененияПлановПоИзмерениям.ПоИсточникуДанныхРасчета;
			}
			else if(Ссылка == ПоПрофилю_Распределение)
			{
				return ВидыИзмененияПлановПоИзмерениям.ПоПрофилю_Распределение;
			}
			else if(Ссылка == ПоПрофилю_Умножение)
			{
				return ВидыИзмененияПлановПоИзмерениям.ПоПрофилю_Умножение;
			}
			return ВидыИзмененияПлановПоИзмерениям.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыИзмененияПлановПоИзмерениям Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыИзмененияПлановПоИзмерениям Значение)
		{
			switch (Значение)
			{
				case ВидыИзмененияПлановПоИзмерениям.ФиксированноеЗначение: return ФиксированноеЗначение;
				case ВидыИзмененияПлановПоИзмерениям.ПоИсточникуДанныхРасчета: return ПоИсточникуДанныхРасчета;
				case ВидыИзмененияПлановПоИзмерениям.ПоПрофилю_Распределение: return ПоПрофилю_Распределение;
				case ВидыИзмененияПлановПоИзмерениям.ПоПрофилю_Умножение: return ПоПрофилю_Умножение;
			}
			return Guid.Empty;
		}
	}
}