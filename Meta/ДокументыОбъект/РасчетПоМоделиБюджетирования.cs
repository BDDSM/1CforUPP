﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Упр)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class РасчетПоМоделиБюджетирования:ДокументОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public DateTime Дата {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public DateTime ПрефиксНомера {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*11*/ Номер {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public bool Проведен {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public DateTime ДатаРасчета {get;set;}//Дата расчета
		[DataMember]
		[ProtoMember(10)]
		public V82.СправочникиСсылка.СценарииПланирования Сценарий {get;set;}
		[DataMember]
		[ProtoMember(11)]
		public bool ПересчитыватьРегламентно {get;set;}//Пересчитывать регламентно
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		[DataMember]
		[ProtoMember(13)]
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов Состояние {get;set;}
		///<summary>
		///Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(15)]
		public object ОсновнойИсточникДанных {get;set;}//Основной источник данных
		[DataMember]
		[ProtoMember(16)]
		public string/*(50)*/ КодОсновногоИсточника {get;set;}//Код основного источника
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для Документов.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Document426(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld10683
						,_Fld10684RRef
						,_Fld10685
						,_Fld10686RRef
						,_Fld10687RRef
						,_Fld10688
						,_Fld10690)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@ДатаРасчета
						,@Сценарий
						,@ПересчитыватьРегламентно
						,@Ответственный
						,@Состояние
						,@Комментарий
						,@КодОсновногоИсточника)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document426
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld10683	= @ДатаРасчета
						,_Fld10684RRef	= @Сценарий
						,_Fld10685	= @ПересчитыватьРегламентно
						,_Fld10686RRef	= @Ответственный
						,_Fld10687RRef	= @Состояние
						,_Fld10688	= @Комментарий
						,_Fld10690	= @КодОсновногоИсточника
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("ДатаРасчета", ДатаРасчета);
					Команда.Parameters.AddWithValue("ПересчитыватьРегламентно", ПересчитыватьРегламентно);
					Команда.Parameters.AddWithValue("Состояние", Состояние.Ключ());
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("КодОсновногоИсточника", КодОсновногоИсточника);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Document426
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}