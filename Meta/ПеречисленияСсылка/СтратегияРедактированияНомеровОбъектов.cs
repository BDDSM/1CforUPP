﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum СтратегияРедактированияНомеровОбъектов
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"c53dc90c-ced1-4acf-b7b7-9de5eac08e15\", \"Представление\":\"НеДоступно\"}")]
		НеДоступно = 0,
		[EnumMember(Value = "{\"Ссылка\":\"17261935-2553-4233-98a3-a3f422165f26\", \"Представление\":\"Доступно\"}")]
		Доступно = 1,
	}
	public static partial class СтратегияРедактированияНомеровОбъектов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НеДоступно = new Guid("e59db7b7-c0ea-158e-4acf-ced1c53dc90c");
		public static readonly Guid Доступно = new Guid("f4a3a398-1622-265f-4233-255317261935");
		public static СтратегияРедактированияНомеровОбъектов Получить(this СтратегияРедактированияНомеровОбъектов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СтратегияРедактированияНомеровОбъектов Получить(this СтратегияРедактированияНомеровОбъектов Значение, Guid Ссылка)
		{
			if(Ссылка == НеДоступно)
			{
				return СтратегияРедактированияНомеровОбъектов.НеДоступно;
			}
			else if(Ссылка == Доступно)
			{
				return СтратегияРедактированияНомеровОбъектов.Доступно;
			}
			return СтратегияРедактированияНомеровОбъектов.ПустаяСсылка;
		}
		public static byte[] Ключ(this СтратегияРедактированияНомеровОбъектов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СтратегияРедактированияНомеровОбъектов Значение)
		{
			switch (Значение)
			{
				case СтратегияРедактированияНомеровОбъектов.НеДоступно: return НеДоступно;
				case СтратегияРедактированияНомеровОбъектов.Доступно: return Доступно;
			}
			return Guid.Empty;
		}
	}
}