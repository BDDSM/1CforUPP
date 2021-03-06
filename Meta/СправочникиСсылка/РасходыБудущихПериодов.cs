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
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	///<summary>
	///(Общ)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class РасходыБудущихПериодов:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("9abae386-a9bc-4f8c-82fd-1a97a39f239f");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012001.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public bool Предопределенный {get;set;}
		public V82.СправочникиСсылка.РасходыБудущихПериодов Родитель {get;set;}
		public bool ЭтоГруппа {get;set;}
		public string/*11*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*100*/ Наименование {get;set;}
		public V82.Перечисления/*Ссылка*/.ВидыРБП ВидРБП {get;set;}//Вид РБП
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаНачалаСписания {get;set;}//Дата начала списания
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаОкончанияСписания {get;set;}//Дата окончания списания
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.НоменклатурныеГруппы НоменклатурнаяГруппа {get;set;}//Номенклатурная группа
		public V82.СправочникиСсылка.ОбъектыСтроительства ОбъектСтроительства {get;set;}//Объект строительства
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации {get;set;}//Подразделение организации
		public V82.СправочникиСсылка.Номенклатура Продукция {get;set;}
		public V82.СправочникиСсылка.СерииНоменклатуры СерияПродукции {get;set;}//Серия продукции
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатрат {get;set;}//Статья затрат
		///<summary>
		///(Регл)
		///</summary>
		public object СчетБУ {get;set;}//Счет БУ
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоБУ1 {get;set;}//Субконто БУ 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоБУ2 {get;set;}//Субконто БУ 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоБУ3 {get;set;}//Субконто БУ 3
		///<summary>
		///(Регл)
		///</summary>
		public object СчетНУ {get;set;}//Счет НУ
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ1 {get;set;}//Субконто НУ 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ2 {get;set;}//Субконто НУ 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ3 {get;set;}//Субконто НУ 3
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(15.2)*/ Сумма {get;set;}
		public V82.СправочникиСсылка.ХарактеристикиНоменклатуры ХарактеристикаПродукции {get;set;}//Характеристика продукции
		public V82.Перечисления/*Ссылка*/.СпособыПризнанияРасходов СпособПризнанияРасходов {get;set;}//Способ признания расходов
		public V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск СпособРаспределенияЗатратНаВыпуск {get;set;}//Способ распределения затрат на выпуск
		public V82.Перечисления/*Ссылка*/.СпособыСтроительства СпособСтроительства {get;set;}//Способ строительства
		public V82.Перечисления/*Ссылка*/.ВидыАктивовДляРБП ВидАктива {get;set;}//Вид актива
		
		public РасходыБудущихПериодов()
		{
		}
		
		public РасходыБудущихПериодов(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public РасходыБудущихПериодов(byte[] УникальныйИдентификатор,int Глубина)
		{
			if (Глубина>3)
			{
				return;
			}
			if (new Guid(УникальныйИдентификатор) == Guid.Empty)
			{
				return;
			}
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1691RRef [ВидРБП]
					,_Fld1692 [ДатаНачалаСписания]
					,_Fld1693 [ДатаОкончанияСписания]
					,_Fld1694RRef [НоменклатурнаяГруппа]
					,_Fld1695RRef [ОбъектСтроительства]
					,_Fld1696RRef [Подразделение]
					,_Fld1697RRef [ПодразделениеОрганизации]
					,_Fld1698RRef [Продукция]
					,_Fld1699RRef [СерияПродукции]
					,_Fld1700RRef [СтатьяЗатрат]
					,_Fld1701RRef [СчетБУ]
					,_Fld1702RRef [СубконтоБУ1]
					,_Fld1703RRef [СубконтоБУ2]
					,_Fld1704RRef [СубконтоБУ3]
					,_Fld1705RRef [СчетНУ]
					,_Fld1706RRef [СубконтоНУ1]
					,_Fld1707RRef [СубконтоНУ2]
					,_Fld1708RRef [СубконтоНУ3]
					,_Fld1709 [Сумма]
					,_Fld1710RRef [ХарактеристикаПродукции]
					,_Fld1711RRef [СпособПризнанияРасходов]
					,_Fld18717RRef [СпособРаспределенияЗатратНаВыпуск]
					,_Fld18927RRef [СпособСтроительства]
					,_Fld26590RRef [ВидАктива]
					From _Reference137(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор  -- and _Folder = 0x01  ";
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
							Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Родитель = new V82.СправочникиСсылка.РасходыБудущихПериодов((byte[])Читалка.GetValue(4),Глубина+1);
							ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Код = Читалка.GetString(6);
							Наименование = Читалка.GetString(7);
							if(!ЭтоГруппа)
							{
								ВидРБП = V82.Перечисления/*Ссылка*/.ВидыРБП.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								ДатаНачалаСписания = Читалка.GetDateTime(9);
								ДатаОкончанияСписания = Читалка.GetDateTime(10);
								НоменклатурнаяГруппа = new V82.СправочникиСсылка.НоменклатурныеГруппы((byte[])Читалка.GetValue(11),Глубина+1);
								ОбъектСтроительства = new V82.СправочникиСсылка.ОбъектыСтроительства((byte[])Читалка.GetValue(12),Глубина+1);
								Подразделение = new V82.СправочникиСсылка.Подразделения((byte[])Читалка.GetValue(13),Глубина+1);
								ПодразделениеОрганизации = new V82.СправочникиСсылка.ПодразделенияОрганизаций((byte[])Читалка.GetValue(14),Глубина+1);
								Продукция = new V82.СправочникиСсылка.Номенклатура((byte[])Читалка.GetValue(15),Глубина+1);
								СерияПродукции = new V82.СправочникиСсылка.СерииНоменклатуры((byte[])Читалка.GetValue(16),Глубина+1);
								СтатьяЗатрат = new V82.СправочникиСсылка.СтатьиЗатрат((byte[])Читалка.GetValue(17),Глубина+1);
								Сумма = Читалка.GetDecimal(26);
								ХарактеристикаПродукции = new V82.СправочникиСсылка.ХарактеристикиНоменклатуры((byte[])Читалка.GetValue(27),Глубина+1);
								СпособПризнанияРасходов = V82.Перечисления/*Ссылка*/.СпособыПризнанияРасходов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
								СпособРаспределенияЗатратНаВыпуск = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск((byte[])Читалка.GetValue(29),Глубина+1);
								СпособСтроительства = V82.Перечисления/*Ссылка*/.СпособыСтроительства.ПустаяСсылка.Получить((byte[])Читалка.GetValue(30));
								ВидАктива = V82.Перечисления/*Ссылка*/.ВидыАктивовДляРБП.ПустаяСсылка.Получить((byte[])Читалка.GetValue(31));
							}
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
		
		public V82.СправочникиОбъект.РасходыБудущихПериодов  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.РасходыБудущихПериодов();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Родитель = Родитель;
			Объект.ЭтоГруппа = ЭтоГруппа;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.ВидРБП = ВидРБП;
			Объект.ДатаНачалаСписания = ДатаНачалаСписания;
			Объект.ДатаОкончанияСписания = ДатаОкончанияСписания;
			Объект.НоменклатурнаяГруппа = НоменклатурнаяГруппа;
			Объект.ОбъектСтроительства = ОбъектСтроительства;
			Объект.Подразделение = Подразделение;
			Объект.ПодразделениеОрганизации = ПодразделениеОрганизации;
			Объект.Продукция = Продукция;
			Объект.СерияПродукции = СерияПродукции;
			Объект.СтатьяЗатрат = СтатьяЗатрат;
			Объект.СчетБУ = СчетБУ;
			Объект.СубконтоБУ1 = СубконтоБУ1;
			Объект.СубконтоБУ2 = СубконтоБУ2;
			Объект.СубконтоБУ3 = СубконтоБУ3;
			Объект.СчетНУ = СчетНУ;
			Объект.СубконтоНУ1 = СубконтоНУ1;
			Объект.СубконтоНУ2 = СубконтоНУ2;
			Объект.СубконтоНУ3 = СубконтоНУ3;
			Объект.Сумма = Сумма;
			Объект.ХарактеристикаПродукции = ХарактеристикаПродукции;
			Объект.СпособПризнанияРасходов = СпособПризнанияРасходов;
			Объект.СпособРаспределенияЗатратНаВыпуск = СпособРаспределенияЗатратНаВыпуск;
			Объект.СпособСтроительства = СпособСтроительства;
			Объект.ВидАктива = ВидАктива;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.РасходыБудущихПериодов ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.РасходыБудущихПериодов)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.РасходыБудущихПериодов(УникальныйИдентификатор);
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