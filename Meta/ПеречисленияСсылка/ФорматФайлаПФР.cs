﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ФорматФайлаПФР
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///формат 04.00
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"c079a0cb-db77-4e12-991d-24ed75868da3\", \"Представление\":\"Версия04\"}")]
		Версия04 = 0,//Версия 04.00 (текст)
	///<summary>
	///Формат 07.00
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"cc766935-ae4a-4a0c-8204-c9feb15864df\", \"Представление\":\"Версия07\"}")]
		Версия07 = 1,//Версия 07.00 (XML)
	}
	public static partial class ФорматФайлаПФР_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///формат 04.00
		///</summary>
		public static readonly Guid Версия04 = new Guid("ed241d99-8675-a38d-4e12-db77c079a0cb");//Версия 04.00 (текст)
		///<summary>
		///Формат 07.00
		///</summary>
		public static readonly Guid Версия07 = new Guid("fec90482-58b1-df64-4a0c-ae4acc766935");//Версия 07.00 (XML)
		public static ФорматФайлаПФР Получить(this ФорматФайлаПФР Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ФорматФайлаПФР Получить(this ФорматФайлаПФР Значение, Guid Ссылка)
		{
			if(Ссылка == Версия04)
			{
				return ФорматФайлаПФР.Версия04;
			}
			else if(Ссылка == Версия07)
			{
				return ФорматФайлаПФР.Версия07;
			}
			return ФорматФайлаПФР.ПустаяСсылка;
		}
		public static byte[] Ключ(this ФорматФайлаПФР Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ФорматФайлаПФР Значение)
		{
			switch (Значение)
			{
				case ФорматФайлаПФР.Версия04: return Версия04;
				case ФорматФайлаПФР.Версия07: return Версия07;
			}
			return Guid.Empty;
		}
	}
}