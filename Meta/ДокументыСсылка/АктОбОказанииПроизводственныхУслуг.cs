﻿
using System;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Общ)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class АктОбОказанииПроизводственныхУслуг:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("08c2cd5b-81b6-49c0-91c9-b65e97925411");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012032.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public DateTime Дата {get;set;}
		public DateTime ПрефиксНомера {get;set;}
		public string/*11*/ Номер {get;set;}
		public bool Проведен {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool АвтораспределениеПрочихЗатрат {get;set;}//Автоматически распределять прочие затраты на продукцию
		///<summary>
		///(Общ)
		///</summary>
		public bool АвтораспределениеМатериалов {get;set;}//Автоматически распределять материалы на продукцию
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации {get;set;}//Подразделение организации
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента {get;set;}//Договор контрагента
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента {get;set;}//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public object Сделка {get;set;}
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10)*/ КратностьВзаиморасчетов {get;set;}//Кратность взаиморасчетов
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10.4)*/ КурсВзаиморасчетов {get;set;}//Курс взаиморасчетов
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете {get;set;}//Отражать в управленческом учете
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public bool РаспределятьПропорциональноКоличеству {get;set;}//Распределять пропорционально количеству
		///<summary>
		///(Общ)
		///</summary>
		public bool СуммаВключаетНДС {get;set;}//Сумма включает НДС
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента {get;set;}//Сумма документа
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовПоАвансам {get;set;}//Счет учета расчетов по авансам
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом {get;set;}//Счет учета расчетов с контрагентом
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен {get;set;}//Тип цен
		///<summary>
		///(Общ)
		///</summary>
		public bool УчитыватьНДС {get;set;}//Учитывать НДС
		public object Проект {get;set;}
		public bool ИспользоватьМатериалы {get;set;}//Использовать материалы
		public bool ИспользоватьПрочиеЗатраты {get;set;}//Использовать прочие затраты
		public bool ИспользоватьЗаказы {get;set;}//Использовать заказы
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Грузополучатель {get;set;}
		public string/*(0)*/ АдресДоставки {get;set;}//Адрес доставки
		public string/*(0)*/ ДополнениеКАдресуДоставки {get;set;}//Дополнение к адресу доставки
		public V82.СправочникиСсылка.ФизическиеЛица Исполнитель {get;set;}
		public string/*(50)*/ ИсполнительПоПриказу {get;set;}//Исполнитель по приказу
		
		public АктОбОказанииПроизводственныхУслуг()
		{
		}
		
		public АктОбОказанииПроизводственныхУслуг(byte[] УникальныйИдентификатор)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Number [Номер]
					,_Fld2592 [ОтражатьВНалоговомУчете]
					,_Fld2581 [АвтораспределениеПрочихЗатрат]
					,_Fld2580 [АвтораспределениеМатериалов]
					,_Fld2589RRef [Организация]
					,_Fld2595RRef [ПодразделениеОрганизации]
					,_Fld2586RRef [Контрагент]
					,_Fld2583RRef [ДоговорКонтрагента]
					,_Fld2582RRef [ВалютаДокумента]
					,_Fld2584_TYPE [Сделка_Тип],_Fld2584_RRRef [Сделка],_Fld2584_RTRef [Сделка_Вид]
					,_Fld2585 [Комментарий]
					,_Fld2587 [КратностьВзаиморасчетов]
					,_Fld2591 [ОтражатьВБухгалтерскомУчете]
					,_Fld2588 [КурсВзаиморасчетов]
					,_Fld2593 [ОтражатьВУправленческомУчете]
					,_Fld2594RRef [Подразделение]
					,_Fld2590RRef [Ответственный]
					,_Fld2596 [РаспределятьПропорциональноКоличеству]
					,_Fld2597 [СуммаВключаетНДС]
					,_Fld2598 [СуммаДокумента]
					,_Fld2599RRef [СчетУчетаРасчетовПоАвансам]
					,_Fld2600RRef [СчетУчетаРасчетовСКонтрагентом]
					,_Fld2601RRef [ТипЦен]
					,_Fld2602 [УчитыватьНДС]
					,_Fld2603_TYPE [Проект_Тип],_Fld2603_RRRef [Проект],_Fld2603_RTRef [Проект_Вид]
					,_Fld2604 [ИспользоватьМатериалы]
					,_Fld2605 [ИспользоватьПрочиеЗатраты]
					,_Fld2606 [ИспользоватьЗаказы]
					,_Fld18722RRef [Грузополучатель]
					,_Fld18723 [АдресДоставки]
					,_Fld18724 [ДополнениеКАдресуДоставки]
					,_Fld26679RRef [Исполнитель]
					,_Fld26680 [ИсполнительПоПриказу]
					From _Document205(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Номер = Читалка.GetString(3);
							ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(4))[0]==1;
							АвтораспределениеПрочихЗатрат = ((byte[])Читалка.GetValue(5))[0]==1;
							АвтораспределениеМатериалов = ((byte[])Читалка.GetValue(6))[0]==1;
							Комментарий = Читалка.GetString(15);
							КратностьВзаиморасчетов = Читалка.GetDecimal(16);
							ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							КурсВзаиморасчетов = Читалка.GetDecimal(18);
							ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(19))[0]==1;
							РаспределятьПропорциональноКоличеству = ((byte[])Читалка.GetValue(22))[0]==1;
							СуммаВключаетНДС = ((byte[])Читалка.GetValue(23))[0]==1;
							СуммаДокумента = Читалка.GetDecimal(24);
							УчитыватьНДС = ((byte[])Читалка.GetValue(28))[0]==1;
							ИспользоватьМатериалы = ((byte[])Читалка.GetValue(32))[0]==1;
							ИспользоватьПрочиеЗатраты = ((byte[])Читалка.GetValue(33))[0]==1;
							ИспользоватьЗаказы = ((byte[])Читалка.GetValue(34))[0]==1;
							АдресДоставки = Читалка.GetString(36);
							ДополнениеКАдресуДоставки = Читалка.GetString(37);
							ИсполнительПоПриказу = Читалка.GetString(39);
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.ДокументыОбъект.АктОбОказанииПроизводственныхУслуг  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.АктОбОказанииПроизводственныхУслуг();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.ОтражатьВНалоговомУчете = ОтражатьВНалоговомУчете;
			Объект.АвтораспределениеПрочихЗатрат = АвтораспределениеПрочихЗатрат;
			Объект.АвтораспределениеМатериалов = АвтораспределениеМатериалов;
			Объект.Организация = Организация;
			Объект.ПодразделениеОрганизации = ПодразделениеОрганизации;
			Объект.Контрагент = Контрагент;
			Объект.ДоговорКонтрагента = ДоговорКонтрагента;
			Объект.ВалютаДокумента = ВалютаДокумента;
			Объект.Сделка = Сделка;
			Объект.Комментарий = Комментарий;
			Объект.КратностьВзаиморасчетов = КратностьВзаиморасчетов;
			Объект.ОтражатьВБухгалтерскомУчете = ОтражатьВБухгалтерскомУчете;
			Объект.КурсВзаиморасчетов = КурсВзаиморасчетов;
			Объект.ОтражатьВУправленческомУчете = ОтражатьВУправленческомУчете;
			Объект.Подразделение = Подразделение;
			Объект.Ответственный = Ответственный;
			Объект.РаспределятьПропорциональноКоличеству = РаспределятьПропорциональноКоличеству;
			Объект.СуммаВключаетНДС = СуммаВключаетНДС;
			Объект.СуммаДокумента = СуммаДокумента;
			Объект.СчетУчетаРасчетовПоАвансам = СчетУчетаРасчетовПоАвансам;
			Объект.СчетУчетаРасчетовСКонтрагентом = СчетУчетаРасчетовСКонтрагентом;
			Объект.ТипЦен = ТипЦен;
			Объект.УчитыватьНДС = УчитыватьНДС;
			Объект.Проект = Проект;
			Объект.ИспользоватьМатериалы = ИспользоватьМатериалы;
			Объект.ИспользоватьПрочиеЗатраты = ИспользоватьПрочиеЗатраты;
			Объект.ИспользоватьЗаказы = ИспользоватьЗаказы;
			Объект.Грузополучатель = Грузополучатель;
			Объект.АдресДоставки = АдресДоставки;
			Объект.ДополнениеКАдресуДоставки = ДополнениеКАдресуДоставки;
			Объект.Исполнитель = Исполнитель;
			Объект.ИсполнительПоПриказу = ИсполнительПоПриказу;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.АктОбОказанииПроизводственныхУслуг ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.АктОбОказанииПроизводственныхУслуг)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.АктОбОказанииПроизводственныхУслуг(УникальныйИдентификатор);
			Кэш.Add(УИ, Ссылка);
			return Ссылка;
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