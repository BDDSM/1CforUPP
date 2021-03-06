﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//RegistraciyaProstoevRabotnikovOrganizacijj
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций","")]
	public class РегистрацияПростоевРаботниковОрганизацийЗапрос: V82.ДокументыСсылка.РегистрацияПростоевРаботниковОрганизаций,IReturn<РегистрацияПростоевРаботниковОрганизацийЗапрос>
	{
	}
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/ПоСсылке","{Ссылка}")]
	public class РегистрацияПростоевРаботниковОрганизацийНайтиПоСсылке: V82.ДокументыСсылка.РегистрацияПростоевРаботниковОрганизаций,IReturn<РегистрацияПростоевРаботниковОрганизацийНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/ПоНомеру","{Номер}")]
	public class РегистрацияПростоевРаботниковОрганизацийНайтиПоНомеру: V82.ДокументыСсылка.РегистрацияПростоевРаботниковОрганизаций,IReturn<РегистрацияПростоевРаботниковОрганизацийНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РегистрацияПростоевРаботниковОрганизацийВыбратьПоСсылке: V82.ДокументыСсылка.РегистрацияПростоевРаботниковОрганизаций,IReturn<РегистрацияПростоевРаботниковОрганизацийВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class РегистрацияПростоевРаботниковОрганизацийВыбратьПоНомеру: V82.ДокументыСсылка.РегистрацияПростоевРаботниковОрганизаций,IReturn<РегистрацияПростоевРаботниковОрганизацийВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class РегистрацияПростоевРаботниковОрганизацийСтраницаПоСсылке: V82.ДокументыСсылка.РегистрацияПростоевРаботниковОрганизаций,IReturn<РегистрацияПростоевРаботниковОрганизацийСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/РегистрацияПростоевРаботниковОрганизаций/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class РегистрацияПростоевРаботниковОрганизацийСтраницаПоНомеру: V82.ДокументыСсылка.РегистрацияПростоевРаботниковОрганизаций,IReturn<РегистрацияПростоевРаботниковОрганизацийСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class РегистрацияПростоевРаботниковОрганизацийОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class РегистрацияПростоевРаботниковОрганизацийСервис : Service
	{
		
		public object Get(РегистрацияПростоевРаботниковОрганизацийЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияПростоевРаботниковОрганизацийНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.РегистрацияПростоевРаботниковОрганизаций.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new РегистрацияПростоевРаботниковОрганизацийОтвет() { Ответ = "РегистрацияПростоевРаботниковОрганизаций c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(РегистрацияПростоевРаботниковОрганизацийНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.РегистрацияПростоевРаботниковОрганизаций.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new РегистрацияПростоевРаботниковОрганизацийОтвет() {Ответ = "РегистрацияПростоевРаботниковОрганизаций c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(РегистрацияПростоевРаботниковОрганизацийВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.РегистрацияПростоевРаботниковОрганизаций.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(РегистрацияПростоевРаботниковОрганизацийВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияПростоевРаботниковОрганизацийСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияПростоевРаботниковОрганизацийСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(РегистрацияПростоевРаботниковОрганизацийЗапрос Запрос)
		{
			return new РегистрацияПростоевРаботниковОрганизацийОтвет {Ответ = "РегистрацияПростоевРаботниковОрганизаций, "};
		}

		public object Post(РегистрацияПростоевРаботниковОрганизацийЗапрос ЗапросРегистрацияПростоевРаботниковОрганизаций)
		{
			var Ссылка = (ДокументыСсылка.РегистрацияПростоевРаботниковОрганизаций)ЗапросРегистрацияПростоевРаботниковОрганизаций;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}