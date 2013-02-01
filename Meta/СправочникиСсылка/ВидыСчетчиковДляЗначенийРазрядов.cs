﻿
using System;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	[ProtoContract]
	[DataContract]
	public partial class ВидыСчетчиковДляЗначенийРазрядов:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("149d03e5-f04a-4738-a511-c96749cbce66");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221190650.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(3)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(4)]
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*50*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public decimal/*(2)*/ РазмерСчетчика {get;set;}//Размер счетчика
		[DataMember]
		[ProtoMember(8)]
		public bool ВПределахОрганизации {get;set;}//В пределах организации
		[DataMember]
		[ProtoMember(9)]
		public bool ВПределахПодразделения {get;set;}//В пределах подразделения
		[DataMember]
		[ProtoMember(10)]
		public bool ВПределахНоменклатурнойГруппы {get;set;}//В пределах номенклатурной группы
		[DataMember]
		[ProtoMember(11)]
		public bool ВПределахНоменклатуры {get;set;}//В пределах номенклатуры
		[DataMember]
		[ProtoMember(12)]
		public decimal/*(20)*/ НачальноеЗначение {get;set;}//Начальное значение
		[DataMember]
		[ProtoMember(13)]
		public decimal/*(20)*/ КонечноеЗначение {get;set;}//Конечное значение

		public V82.СправочникиОбъект.ВидыСчетчиковДляЗначенийРазрядов  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ВидыСчетчиковДляЗначенийРазрядов();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.РазмерСчетчика = РазмерСчетчика;
			Объект.ВПределахОрганизации = ВПределахОрганизации;
			Объект.ВПределахПодразделения = ВПределахПодразделения;
			Объект.ВПределахНоменклатурнойГруппы = ВПределахНоменклатурнойГруппы;
			Объект.ВПределахНоменклатуры = ВПределахНоменклатуры;
			Объект.НачальноеЗначение = НачальноеЗначение;
			Объект.КонечноеЗначение = КонечноеЗначение;
			return Объект;
		}

		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}
